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
    public partial class frm_Add_New_User : Form
    {
        public frm_Add_New_User()
        {
            InitializeComponent();
        }
        
        private void frm_Add_New_User_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'loginDBAppData.tbllog' table. You can move, or remove it, as needed.
            this.tbllogTableAdapter.Fill(this.loginDBAppData.tbllog);
            Edit(false);
        }
        private void Edit(bool value)
        {
            txt_User_Name.Enabled = value;
            txt_Password.Enabled = value;
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(true);
                loginDBAppData.tbllog.AddtbllogRow(loginDBAppData.tbllog.NewtbllogRow());
                tbllogBindingSource.MoveLast();
                txt_User_Name.Focus();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loginDBAppData.tbllog.RejectChanges();
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Edit(true);
            txt_User_Name.Focus();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(false);
                tbllogBindingSource.EndEdit();
                tbllogTableAdapter.Update(loginDBAppData.tbllog);
                DGV_User.Refresh();
                txt_User_Name.Focus();
                MessageBox.Show("Your data has been successfully saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loginDBAppData.tbllog.RejectChanges();
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
            {
                tbllogBindingSource.RemoveCurrent();
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Edit(false);
            tbllogBindingSource.ResetBindings(false);
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            String ulg;
            ulg = "ADMIN";
            frm_Home fh = new frm_Home(ulg);
            fh.Show();
            this.Close();
        }

        private void DGV_User_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
