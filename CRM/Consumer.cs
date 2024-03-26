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
        MySqlDataReader dr;
        int i = 0;

        dbconnection dbconn = new dbconnection();

        public Consumer()
        {
            InitializeComponent();
            conn = new MySqlConnection(dbconn.dbconnect());
        }

        private void Save_Click(object sender, EventArgs e)
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

                i=cmd.ExecuteNonQuery();
                if(i > 0) {
                    MessageBox.Show("Record Succesfully Saved", "CRM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Record Save Failed!", "CRM", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                conn.Close();

            };
                

            /* string sql = "select * from tbl_consumer";
             MySqlCommand cmd = new MySqlCommand(sql, connection);
             MySqlDataReader reader = cmd.ExecuteReader();*/

        }

        private void Consumer_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
