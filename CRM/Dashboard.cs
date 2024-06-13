using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CRM
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }


        private void btn_Areas_Click(object sender, EventArgs e)
        {
            Area area = new Area();
            area.Show();
            Visible = true;
        }

        private void btn_AddAmtPen_Click(object sender, EventArgs e)
        {

        }
        private void btnAddConsumer_Click_1(object sender, EventArgs e)
        {
            Consumer consumer = new Consumer();
            consumer.Show();
            Visible = true;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView(dGridView_Consumer);
        }

        public static void LoadDataIntoDataGridView(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
            string sql = "select * from tbl_consumer";
            using (MySqlConnection connection = new MySqlConnection(Database.CONNECTION_STRING))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DataGridViewRow row = new DataGridViewRow();

                            // Add cells to the row for each column in the fucking dataGridView
                            for (int i = 0; i < dataGridView.Columns.Count; i++)
                            {
                                DataGridViewCell cell = new DataGridViewTextBoxCell();

                                //if (i == 0) continue;
                                cell.Value = reader[i];

                                row.Cells.Add(cell);
                            }

                            dataGridView.Rows.Add(row);
                        }
                    }
                }
            }
        }

        private void dGridView_Consumer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGridView_Amount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cb_area_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_DeleteArea_Click(object sender, EventArgs e)
        {
            NewArea area = new NewArea();
            area.Show();
            Visible = true;
        }

        private void btn_UpdateArea_Click(object sender, EventArgs e)
        {
            NewArea area = new NewArea();
            area.Show();
            Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btn_UpdateRecievable_Click(object sender, EventArgs e)
        {
            Amount_Recievable amount_Recievable = new Amount_Recievable();
            amount_Recievable.Show();
            Visible = true;
        }

        private void btn_DeleteRecievable_Click(object sender, EventArgs e)
        {
            Amount_Recievable amount_Recievable = new Amount_Recievable();
            amount_Recievable.Show();
            Visible = true;
        }

        private void txt_FileImport_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Update button for consumer
            if (dGridView_Consumer.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dGridView_Consumer.SelectedRows[0];
                string[] values = new string[row.Cells.Count];
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = row.Cells[i].Value.ToString();
                }
                Consumer consumer = new Consumer(values);
                consumer.Show();
            }
        }
        MySqlConnection conn;
        MySqlCommand cmd;
        private void button5_Click(object sender, EventArgs e)
        {
            if (dGridView_Consumer.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dGridView_Consumer.SelectedRows[0];
                string id = row.Cells[0].Value.ToString();

                conn = new MySqlConnection(Database.CONNECTION_STRING);
                conn.Open();
                cmd = new MySqlCommand("DELETE FROM `tbl_consumer` WHERE `consumerId` = @consumerId;", conn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@consumerId", id);

                int enq = cmd.ExecuteNonQuery();
                if (enq > 0)
                {
                    MessageBox.Show("Record Successfully Deleted", "CRM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Record Deletion Failed!", "CRM", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                conn.Close();

            }
            Dashboard.LoadDataIntoDataGridView(Dashboard.dGridView_Consumer);
        }

    }
}
