using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Log_in_System
{
    public partial class frm_Login : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.LoginDBConnectionString);
        SqlDataAdapter da;
        SqlCommand cmd;
        public frm_Login()
        {
            InitializeComponent();
        }
        String ulg;
        private void btn_Login_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("SELECT * FROM tbllog WHERE UserName='"+txt_UserName.Text+"' and Password='"+txt_Passsword.Text+"'", con);
            da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            int i = ds.Tables[0].Rows.Count;
            if (i == 1)
            {
                ulg = "Welcome: " + txt_UserName.Text;
                frm_Home fh = new frm_Home(ulg);
                fh.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please check your User Name or Password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_UserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frm_Login_Load(object sender, EventArgs e)
        {

        }

        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
