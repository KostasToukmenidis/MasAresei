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
        private readonly MasAreseiDbContext _context = new MasAreseiDbContext();
        private readonly ErrorProvider error = new ErrorProvider();


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
            //foodCategoryGrid.AutoGenerateColumns = false;
            //var a = _context.Foods.Where(d => d.FoodCategoryId == d.FoodCategory.Id).Select(d => d.FoodCategory.Name);
            
            foodGrid.DataSource = _context.Foods.ToList<Food>();
        }

        //Setting data in the Category Combo Box
        private void SetDataInComboBox()
        {
            foodCategoryCmbBox.DataSource = _context.FoodCategories.Select(c => c.Name).ToList(); ;
        }

        #endregion

        private int CategoryNameToCategoryId(string name)
        {
            var id = _context.FoodCategories.Where(n => n.Name == name).Select(n => n.Id).SingleOrDefault();
            return id;
        }

        private string CategoryIdToCategoryName(int id)
        {
            var name = _context.FoodCategories.Where(i => i.Id == id).Select(i => i.Name).SingleOrDefault();
            return name;
        }
    }
}
