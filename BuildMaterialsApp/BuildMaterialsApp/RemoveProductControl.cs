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
    public partial class RemoveProductControl : UserControl
    {
        string connstring = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\BuildDB.mdb";

        public RemoveProductControl()
        {
            InitializeComponent();
            LoadDataOnDataGrid();
        }

        void LoadDataOnDataGrid()
        {
            OleDbConnection connection = new OleDbConnection(connstring);
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand("SELECT * FROM Products", connection);
                OleDbDataReader reader = command.ExecuteReader();

                List<string[]> data = new List<string[]>();
                while (reader.Read())
                {
                    data.Add(new string[6]);
                    data[data.Count - 1][0] = reader["ID"].ToString();
                    data[data.Count - 1][1] = reader["Product_name"].ToString();
                    data[data.Count - 1][2] = reader["Product_cutegory"].ToString();
                    data[data.Count - 1][3] = reader["Product_count"].ToString();
                    data[data.Count - 1][4] = reader["Product_description"].ToString();
                    data[data.Count - 1][5] = reader["Product_country"].ToString();
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
        string ID_Product;
        private void metroGrid1_SelectionChanged(object sender, EventArgs e)
        {
            ID_Product = (string)metroGrid1.CurrentRow.Cells[0].Value;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection(connstring);
            try
            {
                connection.Open();
                OleDbCommand oleDbCommand = new OleDbCommand("DELETE FROM PRODUCTS WHERE ID = ?", connection);

                OleDbParameter oleDbParameter = new OleDbParameter("Product_name", OleDbType.VarChar);
                oleDbParameter.Value = ID_Product;
                oleDbCommand.Parameters.Add(oleDbParameter);

                oleDbCommand.ExecuteNonQuery();

                metroGrid1.Rows.Clear();
                LoadDataOnDataGrid();

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
