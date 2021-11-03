using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MasAresei.Models;
using MasAresei.Servicies.Validations;
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
        private readonly MasAreseiDbContext _context = new MasAreseiDbContext();
        private readonly ErrorProvider _error = new ErrorProvider();

        #region Communication with Database and Click Events

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
                var ingredients = _context.Ingredients;
                food.Name = foodNameTbox.Text.Trim();
                food.Price = Convert.ToDecimal(foodPriceTbox.Text.Trim());
                food.FoodCategoryId = CategoryNameToCategoryId(foodCategoryCmbBox.Text);
                if (ValidateFood())
                {
                    if (foodId > 0)
                    {
                        _context.Entry(food).Collection(x => x.Ingredients).Load();
                        _context.Entry(food).State = EntityState.Modified;
                    }
                    else
                    {
                        food.Ingredients = _context.Ingredients.ToList();
                        _context.Foods.Add(food);
                    }

                    _context.SaveChanges();
                    //Thread.Sleep(2000);
                    ClearData();
                    SetDataInGrid();
                    MessageBox.Show("Record Save Successfully");
                }
                else
                {
                    this.Focus();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Fill all the fields with valid info.");
            }
        }

        private void foodGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (foodGrid.CurrentCell.RowIndex != -1)
            {
                if (foodGrid.CurrentRow != null)
                {
                    foodId = Convert.ToInt32(foodGrid.CurrentRow.Cells["Id"].Value);
                    food = _context.Foods.FirstOrDefault(f => f.Id == foodId);

                    foodNameTbox.Text = food.Name;
                    foodPriceTbox.Text = food.Price.ToString();
                    foodCategoryCmbBox.Text = CategoryIdToCategoryName(food.FoodCategoryId);
                }
                saveOrEditBtn.Text = "Edit";
                deleteBtn.Enabled = true;
                deleteBtn.BackColor = Color.Firebrick;
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record ?", "Delete ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _context.Foods.Remove(food);
                _context.SaveChanges();
                //Thread.Sleep(2000);
                ClearData();
                SetDataInGrid();
                MessageBox.Show("Record Deleted Successfully");
            }
        }
        
        private void clearBtn_Click(object sender, EventArgs e)
        {
            ClearData();
        }
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Custom methods to reset Form and set the data in the Grid

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
            foodGrid.DataSource = _context.Foods.Include(f => f.FoodCategory).Select(f => new FoodViewModel
            {
                Id = f.Id,
                Name = f.Name,
                Price = f.Price,
                CategoryName = f.FoodCategory.Name
            }).ToList();
        }

        //Setting data in the Category Combo Box
        private void SetDataInComboBox()
        {
            foodCategoryCmbBox.DataSource = _context.FoodCategories.Select(c => c.Name).ToList();
        }

        #endregion

        #region Validation Events

        private void foodNameTbox_Validating(object sender, CancelEventArgs e)
        {
            ValidateFoodNameTbox();
        }

        private void foodPriceTbox_Validating(object sender, CancelEventArgs e)
        {
            ValidatePriceTbox();
        }
        #endregion

        #region Custom Methods for Validation

        public bool ValidateFood()
        {
            if (food.Name.ValidateFoodName() && food.Price.ValidateFoodPrice())//Extension methods for validation first time use
            {
                return true;
            }
            else
                return false;
        }

        public void ValidateFoodNameTbox()
        {
            if (string.IsNullOrEmpty(foodNameTbox.Text))
            {
                _error.SetError(foodNameTbox, "Food name is necessary to procced.");
                foodNameTbox.Focus();
            }
            else if (foodNameTbox.Text.Length > 50)
            {
                _error.SetError(foodNameTbox, "Food name can't be that long, try something shorter.");
                foodNameTbox.Focus();
            }
            else
            {
                _error.SetError(foodNameTbox, "");
            }
        }

        public void ValidatePriceTbox()
        {
            char[] fPChars = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', ',', '.' };
            decimal d;
            if (string.IsNullOrEmpty(foodPriceTbox.Text))
            {
                _error.SetError(foodPriceTbox, "Food price is necessary to procced.");
                foodPriceTbox.Focus();
            }
            else if (!Decimal.TryParse(foodPriceTbox.Text, out d) || d < 0)
            {
                _error.SetError(foodPriceTbox, "Price is a number.");
                foodPriceTbox.Focus();
            }
            else
            {
                _error.SetError(foodPriceTbox, "");
            }
        }

        #endregion

        #region Methods to manipulate FoodCategoryComboBox

        private int CategoryNameToCategoryId(string name)
        {
            return _context.FoodCategories.Where(n => n.Name == name).Select(n => n.Id).FirstOrDefault();
        }
        private string CategoryIdToCategoryName(int foodId)
        {
            return _context.FoodCategories.Where(i => i.Id == foodId).Select(n => n.Name).FirstOrDefault();
        }

        #endregion

    }
}
