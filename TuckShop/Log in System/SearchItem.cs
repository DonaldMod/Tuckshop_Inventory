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
    public partial class SearchItem : Form
    {

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            Search();
        }

        private void SearchItem_Load(object sender, EventArgs e)
        {
            List();

        }

        public void List()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = MakeOrder.ProductList;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            String ulg;
            ulg = "ADMIN";
            frm_Home fh = new frm_Home(ulg);
            fh.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public SearchItem()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbxProduct_TextChanged(object sender, EventArgs e)
        {

        }

        public void Search()
        {
            int Value = 0, Index = 900000000;
            

            foreach (var item in MakeOrder.ProductList)
            {
                if (item.NameOfProduct == tbxProduct.Text.ToString())
                {
                    Index = Value;
                }
                Value++;
            }

            if (Index != 900000000)
            {
                dataGridView1.ClearSelection();
                dataGridView1.Rows[Index].Selected = true;
                MessageBox.Show("Search completed.");
            }
            else
            {
                MessageBox.Show("Product Item does not exist.");
            }
        }
    }
}
