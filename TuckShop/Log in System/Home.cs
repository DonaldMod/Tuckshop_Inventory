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
    public partial class frm_Home : Form
    {
        public frm_Home(string ulg)
        {
            InitializeComponent();
            lbl_Log_User.Text = ulg;
        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            frm_Login flog = new frm_Login();
            flog.Show();
            this.Close();
        }

        private void btn_Add_New_User_Click(object sender, EventArgs e)
        {
            frm_Add_New_User fdn = new frm_Add_New_User();
            fdn.Show();
            this.Close();
        }

        private void frm_Home_Load(object sender, EventArgs e)
        {

        }

        private void lbl_Log_User_Click(object sender, EventArgs e)
        {

        }

        private void btndisplayregister_Click(object sender, EventArgs e)
        {
            Register rs = new Register();
            rs.Show();
            this.Close();
        }

        private void btnorder_Click(object sender, EventArgs e)
        {
            MakeOrder makeOrder = new MakeOrder();
            makeOrder.Show();
            this.Close();

        }

        private void btnorderdisplay_Click(object sender, EventArgs e)
        {
            DisplayOrder DO = new DisplayOrder();
            DO.Show();
            this.Close();
        }

        private void btnUpdDel_Click(object sender, EventArgs e)
        {
            SearchItem Search = new SearchItem();
            Search.Show();
            this.Close();
        }
    }
}
