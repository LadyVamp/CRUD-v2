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
            //admin; pass
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-O9H5H8N;Initial Catalog=SearchBase;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT Role FROM TUser WHERE Username='" + txtLogin.Text + "' AND Password='" + txtPassword.Text + "' ", con);
            DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                this.Hide();
                MainAP ss = new MainAP(dt.Rows[0][0].ToString());
                ss.Show();
            }

            else
            {
                MessageBox.Show("Неверный логин или пароль!");
            }

        }




    }
}
