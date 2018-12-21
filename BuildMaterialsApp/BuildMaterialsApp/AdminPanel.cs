using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuildMaterialsApp
{
    public partial class AdminPanel : UserControl
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void btnAddNewAdmin_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            NewAdminControl newAdminControl = new NewAdminControl(this);
            flowLayoutPanel1.Controls.Add(newAdminControl);
        }

        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            NewProductControl newProductControl = new NewProductControl(this);
            flowLayoutPanel1.Controls.Add(newProductControl);
        }

        private void btnChangeProduct_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            ChangeProductsControl newchangeProductsControl = new ChangeProductsControl();
            flowLayoutPanel1.Controls.Add(newchangeProductsControl);
        }
    }
}
