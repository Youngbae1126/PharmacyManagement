using MetroSet_UI.Forms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PharmacyMngt_proj
{
    public partial class MainForm : MetroSetForm
    {
        MySqlConnection connection = new MySqlConnection("Server=localhost;Database=info;Uid=root;Pwd=Angel1024*;");

        public MainForm()
        {
            InitializeComponent();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO medicine_tb(company,medicine_name,location,input_date)VALUES('" + company_tbx.Text + "','" + name_tbx.Text + "','" + location_tbx.Text + "','" + date_picker.Text + "')";
            connection.Open();
            MySqlCommand command = new MySqlCommand(insertQuery, connection);

            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("정상적으로 입력됨");
                }
                else
                {
                    MessageBox.Show("비정상 입력");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            connection.Close();
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            datagridview.Rows.Clear();
            if (search_tbx.Text == "")
            {
                string selectQuery = "SELECT * from medicine_tb";
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(selectQuery, connection);
                MySqlDataReader table = cmd.ExecuteReader();

                while (table.Read())
                {
                    datagridview.Rows.Add(table["company"], table["medicine_name"], table["location"], table["input_date"]);
                }
                connection.Close();
            }
            else
            {
                string selectQuery = "SELECT * FROM medicine_tb WHERE medicine_name Like'%" + search_tbx.Text + "%'";
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(selectQuery, connection);
                MySqlDataReader table = cmd.ExecuteReader();

                ArrayList Test = new ArrayList();
                while (table.Read())
                {
                    Test.Add(table["medicine_name"]);
                    datagridview.Rows.Add(table["company"], table["medicine_name"], table["location"], table["input_date"]);
                }

                connection.Close();

            }
        }
    }
}
