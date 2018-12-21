﻿using System;
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
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
