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
    public partial class OrdersControl : UserControl
    {
        MainForm form;
        public OrdersControl(MainForm form)
        {
            InitializeComponent();
            this.form = form;
            LoadDataOnDataGrid();
        }
        string connstring = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\BuildDB.mdb";

        private int getID_User(MainForm form)
        {
            string connstring = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\BuildDB.mdb";

            string ID = "";
            OleDbConnection connection = new OleDbConnection(connstring);
            try
            {
                connection.Open();

                OleDbCommand oleDbCommand = new OleDbCommand("SELECT ID_User FROM Users WHERE Login_User = '" + form.mLogin_User.Text + "'", connection);
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

        void LoadDataOnDataGrid()
        {
            OleDbConnection connection = new OleDbConnection(connstring);
            try
            {
                connection.Open();
                //OleDbCommand command = new OleDbCommand("SELECT Products.Product_name, Products.Product_description, Products.Product_cutegory, Products.Product_country, Orders.Order_Date FROM Products inner join Orders on Products.ID = Orders.ID_Product", connection);
                OleDbCommand command = new OleDbCommand("SELECT DISTINCT Products.Product_name, Products.Product_description, Products.Product_cutegory, Products.Product_country, Orders.Order_Date FROM Products, Orders WHERE Products.ID IN (SELECT DISTINCT ID_Product FROM Orders WHERE ID_User = "+getID_User(form)+")", connection);

                OleDbDataReader reader = command.ExecuteReader();

                List<string[]> data = new List<string[]>();
                while (reader.Read())
                {
                    data.Add(new string[5]);
                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();
                }

                foreach (string[] s in data)
                    metroGrid1.Rows.Add(s);
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
    }
}
