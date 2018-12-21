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
    public partial class Carts : UserControl
    {
        string description;
        Image Image;
        public Carts()
        {
            InitializeComponent();
        }
       
        
        public Carts(string name, string count, string description, string country, Image image)
        {
            InitializeComponent();
            this.lNameProduct.Text = name;
            this.lCountProduct.Text = count;
            this.description = description;
            this.lCountryProduct.Text = country;
            this.pbImageProduct.Image = image;
            this.Image = image;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click_1(object sender, EventArgs e)
        {
            MoreInfoProductForm moreInfoProductForm = new MoreInfoProductForm(this.lNameProduct.Text, this.description, this.lCountryProduct.Text, this.Image);
            moreInfoProductForm.Show();
        }
    }
}
