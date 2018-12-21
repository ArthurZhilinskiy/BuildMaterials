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
        public OrdersControl()
        {
            InitializeComponent();
            LoadDataOnDataGrid();
        }
        string connstring = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\BuildDB.mdb";

        void LoadDataOnDataGrid()
        {
            OleDbConnection connection = new OleDbConnection(connstring);
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand("SELECT Products.Product_name, Products.Product_description, Products.Product_cutegory, Products.Product_country, Orders.Order_Date FROM Products inner join Orders on Products.ID = Orders.ID_Product", connection);
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
