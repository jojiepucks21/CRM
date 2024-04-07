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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
