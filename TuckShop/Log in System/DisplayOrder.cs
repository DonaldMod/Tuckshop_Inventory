using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Log_in_System
{
    
    public partial class DisplayOrder : Form
    {
        public DisplayOrder()
        {
            InitializeComponent();
        }

        private void dgvDisplayOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            String ulg;
            ulg = "ADMIN";
            frm_Home fh = new frm_Home(ulg);
            fh.Show();
            this.Close();
        }

        private void DisplayOrder_Load(object sender, EventArgs e)
        {
            Display();
        }

        public void Display()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = MakeOrder.ProductList;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
