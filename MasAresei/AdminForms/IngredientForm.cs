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
    public partial class IngredientForm : Form
    {
        public IngredientForm()
        {
            InitializeComponent();
        }

        public int ingredientId;
        public Ingredient ingredient = new Ingredient();
        private readonly MasAreseiDbContext _context = new MasAreseiDbContext();
        private readonly ErrorProvider _error = new ErrorProvider();

        #region Communication with database and Click Events

        private void IngredientForm_Load(object sender, EventArgs e)
        {
            ClearData();
            SetDataInGrid();
        }

        private void saveOrEditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ingredient.Name = ingredientNameTbox.Text.Trim();
                //ingredient.Foods = _context.Foods.ToList();//Populating FoodIngredients table auto created by EF

                if (ingredient.Name.ValidateIngredientName())
                {
                    if (ingredientId > 0)
                    {
                        _context.Entry(ingredient).Collection(x => x.Foods).Load();//updating many to many table
                        _context.Entry(ingredient).State = EntityState.Modified;
                    }
                    else
                    {
                        ingredient.Foods = _context.Foods.ToList();//loading many to many table
                        _context.Ingredients.Add(ingredient);
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
                MessageBox.Show("Give a valid Ingredient.");
            }
        }

        private void ingredientGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ingredientGrid.CurrentCell.RowIndex != -1)
            {
                if (ingredientGrid.CurrentRow != null)
                {
                    ingredientId = Convert.ToInt32(ingredientGrid.CurrentRow.Cells["Id"].Value);
                    ingredient = _context.Ingredients.FirstOrDefault(f => f.Id == ingredientId);
                    ingredientNameTbox.Text = ingredient.Name;
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
                _context.Ingredients.Remove(ingredient);
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

        #region Custom methods to reset Form and set the data in the Grid

        //Reseting my form
        public void ClearData()
        {
            ingredientNameTbox.Text = string.Empty;
            deleteBtn.Enabled = false;
            deleteBtn.BackColor = Color.IndianRed;
            saveOrEditBtn.Text = "Save";
            ingredientId = 0;
        }

        //Setting data in the grid
        public void SetDataInGrid()
        {
            //foodCategoryGrid.AutoGenerateColumns = false;
            ingredientGrid.DataSource = _context.Ingredients.ToList<Ingredient>();
        }



        #endregion

        #region Validation Events

        private void foodCategoryTbox_Validating(object sender, CancelEventArgs e)
        {
            ValidateIngredientNameTbox();
        }

        #endregion

        #region Custom Methods for Validation

        public void ValidateIngredientNameTbox()
        {
            if (string.IsNullOrEmpty(ingredientNameTbox.Text))
            {
                _error.SetError(ingredientNameTbox, "Food category is necessary to procced.");
                //saveOrEditBtn.Enabled = false;
                ingredientNameTbox.Focus();
            }
            else if (ingredientNameTbox.Text.Length > 50)
            {
                _error.SetError(ingredientNameTbox, "Food category can't be that long, try something shorter.");
                ingredientNameTbox.Focus();
            }
            else
            {
                _error.SetError(ingredientNameTbox, "");
            }
        }

        #endregion

    }
}
