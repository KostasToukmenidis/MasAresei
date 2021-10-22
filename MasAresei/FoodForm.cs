using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MasAresei.Models;
using MasAresei.ViewModels;
using Exception = System.Exception;

namespace MasAresei
{
    public partial class FoodForm : Form
    {
        public FoodForm()
        {
            InitializeComponent();
        }

        public int foodId;
        public Food food = new Food();
        //public FoodViewModel foodViewModel = new FoodViewModel();
        private readonly MasAreseiDbContext _context = new MasAreseiDbContext();
        private readonly ErrorProvider error = new ErrorProvider();
        //public static List<FoodViewModel> foodList = new List<FoodViewModel>();


        private void FoodForm_Load(object sender, EventArgs e)
        {
            ClearData();
            SetDataInGrid();
            SetDataInComboBox();
        }

        private void saveOrEditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                food.Name = foodNameTbox.Text.Trim();
                food.Price = Convert.ToDecimal(foodPriceTbox.Text.Trim());
                food.FoodCategoryId = CategoryNameToCategoryId(foodCategoryCmbBox.Text);
                
                if (foodId > 0)
                {
                    _context.Entry(food).State = EntityState.Modified;
                }
                else
                {
                    _context.Foods.Add(food);
                }

                _context.SaveChanges();

                //foodViewModel.Id = food.Id;       //Testing if i can use custom vie model for foodGrid DataSource
                //foodViewModel.Name = food.Name;
                //foodViewModel.CategoryName = GetCategoryName(food.Id);
                //foodViewModel.Price = food.Price;
                //foodList.Add(foodViewModel);

                ClearData();
                SetDataInGrid();
                MessageBox.Show("Record Save Successfully");
            }
            catch (Exception)
            {
                MessageBox.Show("Fill the textboxes with valid info.");
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            ClearData();
            //Testing if list holds data
            //foreach (var item in foodList)
            //{
            //    MessageBox.Show(item.Name);
            //}
        }

        #region Custom methods for reseting Form and setting data in the Grid

        //Reseting my form
        public void ClearData()
        {
            foodNameTbox.Text = string.Empty;
            foodPriceTbox.Text = string.Empty;
            deleteBtn.Enabled = false;
            deleteBtn.BackColor = Color.IndianRed;
            saveOrEditBtn.Text = "Save";
            foodId = 0;
        }

        //Setting data in the grid
        public void SetDataInGrid()
        {
            foodGrid.ColumnCount = 4;
            foodGrid.Columns[0].Name = "Id";
            foodGrid.Columns[1].Name = "Name";
            foodGrid.Columns[2].Name = "Price";
            foodGrid.Columns[3].Name = "FoodCategory";
            foreach (var item in _context.Foods.ToList())
            {
                foodGrid.Rows.Add(item.Id, item.Name, item.Price, GetCategoryName(item.FoodCategoryId));
            }
            //foodGrid.DataSource = _context.Foods.ToList<Food>();
            //foodGrid.DataSource = foodList;
            //foodGrid.Columns.RemoveAt(2);
        }

        //Setting data in the Category Combo Box
        private void SetDataInComboBox()
        {
            foodCategoryCmbBox.DataSource = _context.FoodCategories.Select(c => c.Name).ToList();
        }

        #endregion

        private int CategoryNameToCategoryId(string name)
        {
            return  _context.FoodCategories.Where(n => n.Name == name).Select(n => n.Id).SingleOrDefault();
        }

        private string CategoryIdToCategoryName(int id)
        {
            return _context.FoodCategories.Where(i => i.Id == id).Select(i => i.Name).SingleOrDefault();
        }

        private string GetCategoryName(int foodId)
        {
            return _context.FoodCategories.Where(i => i.Id == foodId).Select(n => n.Name).FirstOrDefault();
        }
    }
}
