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
        private readonly ErrorProvider error = new ErrorProvider();

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
                ingredient.Name = ingredientTbox.Text.Trim();

                if (ingredient.Name.ValidateIngredientName())
                {
                    if (ingredientId > 0)
                    {
                        _context.Entry(ingredient).State = EntityState.Modified;
                    }
                    else
                    {
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
                    ingredientTbox.Text = ingredient.Name;
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

        #region Custom methods for reseting Form and setting data in the Grid

        //Reseting my form
        public void ClearData()
        {
            ingredientTbox.Text = string.Empty;
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
            ValidateIngredientName();
        }

        #endregion

        #region Custom Methods for Validation

        public void ValidateIngredientName()
        {
            if (string.IsNullOrEmpty(ingredientTbox.Text))
            {
                error.SetError(ingredientTbox, "Food category is necessary to procced.");
                //saveOrEditBtn.Enabled = false;
                ingredientTbox.Focus();
            }
            else if (ingredientTbox.Text.Length > 50)
            {
                error.SetError(ingredientTbox, "Food category can't be that long, try something shorter.");
                ingredientTbox.Focus();
            }
            else
            {
                error.SetError(ingredientTbox, "");
            }
        }

        #endregion

        
    }
}
