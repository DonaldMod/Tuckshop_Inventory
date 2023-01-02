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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void Register_Load(object sender, EventArgs e)
        {
            
        }

        private void DGV_User_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tbllogTableAdapter.FillBy(this.loginDBAppData.tbllog);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
