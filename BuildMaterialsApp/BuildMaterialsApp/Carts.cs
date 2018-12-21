using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace BuildMaterialsApp
{
    public partial class Carts : UserControl
    {
        string description;
        Image Image;
        string connstring = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\BuildDB.mdb";
        string product_name;
        public Carts()
        {
            InitializeComponent();
        }

        MainForm form;
        public Carts(string name, string count, string description, string country, Image image, MainForm form)
        {
            InitializeComponent();
            this.lNameProduct.Text = name;
            product_name = name;
            this.lCountProduct.Text = count;
            this.description = description;
            this.lCountryProduct.Text = country;
            this.pbImageProduct.Image = image;
            this.Image = image;
            this.form = form;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click_1(object sender, EventArgs e)
        {
            MoreInfoProductForm moreInfoProductForm = new MoreInfoProductForm(this.lNameProduct.Text, this.description, this.lCountryProduct.Text, this.Image);
            moreInfoProductForm.Show();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection(connstring);
            try
            {
                connection.Open();

                OleDbCommand oleDbCommand = new OleDbCommand("INSERT INTO Orders(ID_User, Order_Date, ID_Product) VALUES(?,?,?)", connection);

                OleDbParameter oleDbParameter = new OleDbParameter("ID_User", OleDbType.Integer);
                oleDbParameter.Value = getID_User(form);
                oleDbCommand.Parameters.Add(oleDbParameter);

                OleDbParameter oleDbParameter1 = new OleDbParameter("Order_Date", OleDbType.VarChar);
                oleDbParameter1.Value = DateTime.Now.ToShortDateString();
                oleDbCommand.Parameters.Add(oleDbParameter1);

                OleDbParameter oleDbParameter2 = new OleDbParameter("ID_Product", OleDbType.Integer);
                oleDbParameter2.Value = getID_Product();
                oleDbCommand.Parameters.Add(oleDbParameter2);

                oleDbCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        private int getID_Product()
        {
            string connstring = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\BuildDB.mdb";

            string ID = "";
            OleDbConnection connection = new OleDbConnection(connstring);
            try
            {
                connection.Open();
               
                OleDbCommand oleDbCommand = new OleDbCommand("SELECT ID FROM Products WHERE Product_Name = '" + product_name + "'", connection);
                OleDbDataReader reader = oleDbCommand.ExecuteReader();
                while (reader.Read())
                {
                    ID = reader[0].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return Convert.ToInt32(ID);

        }
        private int getID_User(MainForm form)
        {
            string connstring = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\BuildDB.mdb";

            string ID = "";
            OleDbConnection connection = new OleDbConnection(connstring);
            try
            {
                connection.Open();
                
                OleDbCommand oleDbCommand = new OleDbCommand("SELECT ID_User FROM Users WHERE Login_User = '"+form.mLogin_User.Text+"'", connection);
                OleDbDataReader reader = oleDbCommand.ExecuteReader();
                while (reader.Read())
                {
                    ID = reader[0].ToString();
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return Convert.ToInt32(ID);

        }
    }
}
