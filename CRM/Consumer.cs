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
    public partial class Consumer : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;

        string[]? ConsumerValues;
        public Consumer()
        {
            InitializeComponent();
            conn = new MySqlConnection(Database.CONNECTION_STRING);
            ConsumerValues = null;
        }

        public Consumer(string[] consumer)
        {
            InitializeComponent();
            conn = new MySqlConnection(Database.CONNECTION_STRING);
            ConsumerValues = consumer;
        }

        private void Save_Click(object sender, EventArgs e)
        {

            if (ConsumerValues == null)
            {
                CreateConsumer();
            }
            else
            {
                UpdateConsumer();
            }

            Dashboard.LoadDataIntoDataGridView(Dashboard.dGridView_Consumer);

        }

        private void Consumer_Load(object sender, EventArgs e)
        {
            int start_index = 1;
            if (ConsumerValues != null)
            {
                txt_AccountNumber.Text = ConsumerValues[start_index];
                txt_MeterNumber.Text = ConsumerValues[start_index + 1];
                txt_ConsumerName.Text = ConsumerValues[start_index + 2];
                cbo_Status.Text = ConsumerValues[start_index + 3];
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CreateConsumer()
        {
            if ((txt_AccountNumber.Text == string.Empty) || (txt_ConsumerName.Text == string.Empty) || (txt_MeterNumber.Text == string.Empty) || (cbo_Status.Text == string.Empty))
            {
                MessageBox.Show("Warning : Required Fill Filed?", "CRM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                conn.Open();
                cmd = new MySqlCommand("INSERT INTO `tbl_consumer`(`acctNo`, `meterNo`, `consumerNames`, `c_status`) VALUES (@acctNo, @meterNo, @consumerNames, @c_status);", conn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@acctNo", txt_AccountNumber.Text);
                cmd.Parameters.AddWithValue("@meterNo", txt_MeterNumber.Text);
                cmd.Parameters.AddWithValue("@consumerNames", txt_ConsumerName.Text);
                cmd.Parameters.AddWithValue("@c_status", cbo_Status.Text);

                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Record Successfully Saved", "CRM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Record Save Failed!", "CRM", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                conn.Close();

            };
        }

        private void UpdateConsumer()
        {
            if ((txt_AccountNumber.Text == string.Empty) || (txt_ConsumerName.Text == string.Empty) || (txt_MeterNumber.Text == string.Empty) || (cbo_Status.Text == string.Empty) || ConsumerValues == null)
            {
                MessageBox.Show("Warning : Required Fill Field?", "CRM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                conn.Open();
                cmd = new MySqlCommand("UPDATE `tbl_consumer` SET `acctNo` = @acctNo, `meterNo` = @meterNo, `consumerNames` = @consumerNames, `c_status` = @c_status WHERE `consumerId` = @consumerId;", conn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@consumerId", ConsumerValues[0]);
                cmd.Parameters.AddWithValue("@acctNo", txt_AccountNumber.Text);
                cmd.Parameters.AddWithValue("@meterNo", txt_MeterNumber.Text);
                cmd.Parameters.AddWithValue("@consumerNames", txt_ConsumerName.Text);
                cmd.Parameters.AddWithValue("@c_status", cbo_Status.Text);

                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Record Successfully Updated", "CRM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Record Update Failed!", "CRM", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                conn.Close();
            };

        }
    }
}
