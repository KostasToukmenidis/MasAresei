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
using MasAresei.Servicies.Validations;

namespace MasAresei
{
    public partial class FoodCategoryForm : Form
    {
        public FoodCategoryForm()
        {
            InitializeComponent();
        }

        public int foodCategoryId;
        public FoodCategory foodCategory = new FoodCategory();
        private readonly MasAreseiDbContext _context = new MasAreseiDbContext();
        private readonly ErrorProvider error = new ErrorProvider();

        #region Communication with database and Click Events

        private void FoodCategoryForm_Load(object sender, EventArgs e)
        {
            ClearData();
            SetDataInGrid();
        }

        private void saveOrEditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                foodCategory.Name = foodCategoryTbox.Text.Trim();

                if (FoodCategoryValidator.ValidateFoodCategoryName(foodCategory.Name) == true)
                {
                    if (foodCategoryId > 0)
                    {
                        _context.Entry(foodCategory).State = EntityState.Modified;
                    }
                    else
                    {
                        _context.FoodCategories.Add(foodCategory);
                    }

                    _context.SaveChanges();
                    ClearData();
                    SetDataInGrid();
                    MessageBox.Show("Record Save Successfully");
                }
                else
                    this.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Give a valid Food category.");
            }
        }

        private void foodCategoryGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (foodCategoryGrid.CurrentCell.RowIndex != -1)
            {
                if (foodCategoryGrid.CurrentRow != null)
                {
                    foodCategoryId = Convert.ToInt32(foodCategoryGrid.CurrentRow.Cells["Id"].Value);
                    foodCategory = _context.FoodCategories.FirstOrDefault(f => f.Id == foodCategoryId);
                    foodCategoryTbox.Text = foodCategory.Name;
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
                _context.FoodCategories.Remove(foodCategory);
                _context.SaveChanges();
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
            this.Hide();
        }

        #endregion

        #region Validation Events

        private void foodCategoryTbox_Validating(object sender, CancelEventArgs e)
        {
            ValidateFoodCategoryName();
        }

        #endregion

        #region Custom Methods for Validation

        public void ValidateFoodCategoryName()
        {
            if (string.IsNullOrEmpty(foodCategoryTbox.Text))
            {
                error.SetError(foodCategoryTbox, "Food category is necessary to procced.");
                //saveOrEditBtn.Enabled = false;
                foodCategoryTbox.Focus();
            }
            else if (foodCategoryTbox.Text.Length > 50)
            {
                error.SetError(foodCategoryTbox, "Food category can't be that long, try something shorter.");
                foodCategoryTbox.Focus();
            }
            else
            {
                error.SetError(foodCategoryTbox, "");
            }
        }

        #endregion

        #region Custom methods for reseting Form and setting data in the Grid

        //Reseting my form
        public void ClearData()
        {
            foodCategoryTbox.Text = string.Empty;
            deleteBtn.Enabled = false;
            deleteBtn.BackColor = Color.IndianRed;
            saveOrEditBtn.Text = "Save";
            foodCategoryId = 0;
        }

        //Setting data in the grid
        public void SetDataInGrid()
        {
            //foodCategoryGrid.AutoGenerateColumns = false;
            foodCategoryGrid.DataSource = _context.FoodCategories.ToList<FoodCategory>();
        }



        #endregion

    }
}
