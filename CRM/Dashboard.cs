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

        private void btnAddConsumer_Click(object sender, EventArgs e)
        {

            Consumer consumer = new Consumer();
            consumer.Show();
            Visible = true;
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            Area area = new Area();
            area.Show();
            Visible = true;
        }

        private void btnAddAmtPen_Click(object sender, EventArgs e)
        {
            Amount_Recievable amount_Recievable = new Amount_Recievable();
            amount_Recievable.Show();
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
    }
}
