using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace sqlite_test
{
    public partial class Form1 : Form
    {
        int idx;
        SQLiteConnection conn;
        SQLiteCommand command;
        DataTable dt;

        public Form1()
        {
            InitializeComponent();

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;   // 행을 추가하기 위한 옵션이 사용자에게 표시되는 지 여부

            try
            {
                conn = new SQLiteConnection("Data Source = " + Application.StartupPath + "/medicine_info.db");
                conn.Open();

                command = new SQLiteCommand(conn);
                command.CommandText = "CREATE TABLE IF NOT EXISTS medicine_info (" + "company TEXT NOT NULL, " + "name TEXT NOT NULL, " + "location TEXT NOT NULL)";
                command.ExecuteNonQuery();

                command.CommandText = "SELECT * FROM medicine_info";
                SQLiteDataReader reader = command.ExecuteReader();
                dt = new DataTable();
                dt.Load(reader);
                dataGridView1.DataSource = dt;
                reader.Close();

                dataGridView1.Columns[0].HeaderText = "COMPANY";
                dataGridView1.Columns[1].HeaderText = "MEDICINE NAME";
                dataGridView1.Columns[2].HeaderText = "LOCATION";

                comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBox1.SelectedIndex = 1;
                comboBox2.SelectedIndex = 1;

                conn.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
       
        private void add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SQLiteConnection("Data Source = " + Application.StartupPath + "/medicine_info.db");
                conn.Open();

                command = new SQLiteCommand(conn);
                command.CommandText = "INSERT INTO medicine_info (company, name, location) VALUES('" + company_tbx.Text + "','" +
                    name_tbx.Text + "','" + location_tbx.Text + "')";
                command.ExecuteNonQuery();

                conn.Close();

                dt.Rows.Add(company_tbx.Text, name_tbx.Text, location_tbx.Text);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string filter;
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        filter = "company";
                        break;
                    case 1:
                        filter = "name";
                        break;
                    default:
                        filter = "name";
                        break;
                }
                conn = new SQLiteConnection("Data Source = " + Application.StartupPath + "/medicine_info.db");
                conn.Open();
                command = new SQLiteCommand(conn);

                if (dataGridView1.Rows.Count == 0)
                {
                    command.CommandText = "SELECT * FROM medicine_info";
                }
                else
                {
                    command.CommandText = "SELECT * FROM medicine_info WHERE " + filter.Trim() + " LIKE '%" + search_tbx.Text + "%'";
                }
                SQLiteDataReader reader = command.ExecuteReader();
                dt = new DataTable();
                dt.Load(reader);
                dataGridView1.DataSource = dt;
                reader.Close();

                conn.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 1)
                return;
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            company_tbx.Text = row.Cells[0].Value.ToString();
            name_tbx.Text = row.Cells[1].Value.ToString();
            location_tbx.Text = row.Cells[2].Value.ToString();
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string Check = string.Format("{0}의 데이터를 정말 삭제 하시겠습니까?", dataGridView1.SelectedRows[0].Cells[1].Value);
                if (MessageBox.Show(Check,"삭제",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    conn = new SQLiteConnection("Data Source = " + Application.StartupPath + "/medicine_info.db");
                    conn.Open();

                    command = new SQLiteCommand(conn);
                    command.CommandText = "DELETE FROM medicine_info WHERE name = '" + name_tbx.Text + "'";
                    command.Parameters.Add("name", DbType.String).Value = name_tbx.Text.Trim();
                    command.ExecuteNonQuery();

                    conn.Close();

                    DataGridViewRow row = dataGridView1.SelectedRows[0];
                    dataGridView1.Rows.Remove(row);
                }
                else
                {
                    //MessageBox.Show("삭제하지 않았습니다.");
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idx = e.RowIndex;
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow newdata = dataGridView1.Rows[idx];
                string filter;
                string edit_text;
                string text;
                switch (comboBox2.SelectedIndex)
                {
                    case 0:
                        filter = "company";
                        edit_text = company_tbx.Text;
                        text = newdata.Cells[0].Value.ToString();
                        break;
                    case 1:
                        filter = "name";
                        edit_text = name_tbx.Text;
                        text = newdata.Cells[1].Value.ToString();
                        break;
                    case 2:
                        filter = "location";
                        edit_text = location_tbx.Text;
                        text = newdata.Cells[2].Value.ToString();
                        break;
                    default:
                        filter = "name";
                        edit_text = name_tbx.Text;
                        text = newdata.Cells[1].Value.ToString();
                        break;
                }
                conn = new SQLiteConnection("Data Source = " + Application.StartupPath + "/medicine_info.db");
                conn.Open();

                command = new SQLiteCommand(conn);
                command.CommandText = "UPDATE medicine_info SET " + filter + " = '" + edit_text.Trim() +
                    "' WHERE " + filter.Trim() + " = '" + text.Trim() + "'";

                SQLiteDataReader reader = command.ExecuteReader();
                dt = new DataTable();
                dt.Load(reader);
                dataGridView1.DataSource = dt;
                reader.Close();

                conn.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        private void show_btn_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SQLiteConnection("Data Source = " + Application.StartupPath + "/medicine_info.db");
                conn.Open();
                command = new SQLiteCommand(conn);
                command.CommandText = "SELECT * FROM medicine_info";

                SQLiteDataReader reader = command.ExecuteReader();
                dt = new DataTable();
                dt.Load(reader);
                dataGridView1.DataSource = dt;
                reader.Close();

                conn.Close();

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            String rowIdx = (e.RowIndex + 1).ToString();

            StringFormat centerFormat = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            Rectangle headerBound = new Rectangle(e.RowBounds.Left, e.RowBounds.Top,
                dataGridView1.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, Font, SystemBrushes.ControlText, headerBound, centerFormat);
        }
    }
}
