using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuildMaterialsApp
{
    public partial class MoreInfoProductForm : MetroFramework.Forms.MetroForm
    {
        string connstring = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\BuildDB.mdb";
        public int ID_User { get; set; }
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

        private void btnByProduct_Click(object sender, EventArgs e)
        {
          
        }
    }
}
