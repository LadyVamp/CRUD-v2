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

namespace CRUD_v2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e) 
        {
            SqlConnection con = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SearchBase;Data Source=NADYA-PC");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT Role FROM TUser WHERE Username='" + txtLogin.Text + "' AND Password='" + txtPassword.Text + "' ", con);
            DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {

            }
            else 
            { 
            
            }

        }




    }
}
