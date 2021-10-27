﻿using System;
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
        private ErrorProvider error = new ErrorProvider();
        //public List<FoodViewModel> foodList = new List<FoodViewModel>();


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
                //Thread.Sleep(2000);
                ClearData();
                SetDataInGrid();
                MessageBox.Show("Record Save Successfully");
            }
            catch (Exception)
            {
                MessageBox.Show("Fill the textboxes with valid info.");
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
                    foodCategoryCmbBox.Text = GetFoodCategoryName(food.FoodCategoryId);
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

        #endregion

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
            foodGrid.DataSource = _context.Foods.Include(f => f.FoodCategory).Select(f => new FoodViewModel
            {
                Id = f.Id,
                Name = f.Name,
                Price = f.Price,
                CategoryName = f.FoodCategory.Name

            }).ToList();
            //var fcList = _context.FoodCategories.ToList<FoodCategory>();
            //foreach (var item in _context.Foods)
            //{
            //    FoodViewModel foodViewModel = new FoodViewModel();
            //    foodViewModel.Id = item.Id;
            //    foodViewModel.Name = item.Name;
            //    foodViewModel.Price = item.Price;
            //    foodViewModel.CategoryName = fcList.Where(n => n.Id == item.FoodCategoryId).Select(m => m.Name).FirstOrDefault();
            //    foodList.Add(foodViewModel);
            //}
            //foodGrid.DataSource = foodList;
            //foodGrid.Update();
            //foodGrid.Refresh();
        }

        //Setting data in the Category Combo Box
        private void SetDataInComboBox()
        {
            foodCategoryCmbBox.DataSource = _context.FoodCategories.Select(c => c.Name).ToList();
        }

        #endregion

        private int CategoryNameToCategoryId(string name)
        {
            return _context.FoodCategories.Where(n => n.Name == name).Select(n => n.Id).FirstOrDefault();
        }
        private string GetFoodCategoryName(int foodId)
        {
            return _context.FoodCategories.Where(i => i.Id == foodId).Select(n => n.Name).FirstOrDefault();
        }
    }
}
