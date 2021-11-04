using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasAresei.OrderFoodFormsCreationCode
{
    public class OrderFoodFormCreating
    {
        private static readonly MasAreseiDbContext _context = new MasAreseiDbContext();
        public static int CategoryId;

        public static void CreatingOrderFoodForms(Form form, string categoryName)
        {
            CategoryId = _context.FoodCategories.Where(fc => fc.Name == categoryName).Select(i=>i.Id).FirstOrDefault();
            
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Size = new Size(900, 600);
            form.Text = categoryName;
            form.Name = categoryName + "Form";
            form.AutoScroll = true;
            form.Controls.Add(SidebarMainPanel());
        }

        public static Panel SidebarMainPanel()
        {
            Panel panel = new Panel();
            panel.Name = "sideBarMainPanel";
            panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            panel.Dock = DockStyle.Left;
            panel.Size = new Size(250, 600);
            //panel.Controls.Add(SideBarBtnPanel());
            foreach (var item in _context.Foods.ToList().Where(f => f.FoodCategoryId == CategoryId))
            {
                panel.Controls.Add(SideBarButton(item.Name));
            }
            panel.Controls.Add(SideBarHeaderPanel());
            

            return panel;
        }

        public static Panel SideBarHeaderPanel()
        {
            Panel panel = new Panel();
            panel.Name = "sideBarHeaderPanel";
            panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(60)))));
            panel.Location = new Point(50, 50);
            panel.Size = new Size(250, 50);
            panel.Dock = DockStyle.Top;
            panel.SendToBack();

            return panel;
        }

        //public static Panel SideBarBtnPanel()
        //{
        //    Panel panel = new Panel();
        //    panel.Name = "sideBarBtnPanel";
        //    panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(60)))));
        //    panel.Location = new Point(50, 50);
        //    panel.Size = new Size(250, 550);
        //    panel.Dock = DockStyle.Top;
        //    panel.BringToFront();
            

        //    return panel;
        //}

        public static Button SideBarButton(string btnName)
        {
            Button button = new Button();
            button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            button.FlatAppearance.BorderSize = 0;
            button.FlatStyle = FlatStyle.Flat;
            button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(162)))), ((int)(((byte)(90)))));
            button.Location = new Point(250, 250);
            button.Dock = DockStyle.Top;
            button.Name = btnName + "Btn";
            button.Size = new Size(234, 78);
            button.TabIndex = 0;
            button.Text = btnName;
            button.UseVisualStyleBackColor = false;
            //button.BringToFront();

            return button;
        }
    }
}
