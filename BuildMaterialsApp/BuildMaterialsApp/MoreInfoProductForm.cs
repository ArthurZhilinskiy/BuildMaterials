using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuildMaterialsApp
{
    public partial class MoreInfoProductForm : MetroFramework.Forms.MetroForm
    {
        public MoreInfoProductForm()
        {
            InitializeComponent();
        }
        public MoreInfoProductForm(string name, string description, string country, Image image)
        {
            InitializeComponent();
            this.pbImage.Image = image;
            this.lCountry.Text = country;
            this.lName.Text = name;
            this.tbDescription.Text = description;
        }

        private void MoreInfoProductForm_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
