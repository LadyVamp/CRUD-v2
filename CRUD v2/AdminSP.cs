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
    public partial class AdminSP : Form
    {
        public AdminSP()
        {
            InitializeComponent();
        }

        private const string CONNECTION_STRING =
   "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SearchBase;Data Source=NADYA-PC";


        private void AdminSP_Load(object sender, EventArgs e)
        {

        }


            SqlConnection con = new SqlConnection(CONNECTION_STRING);

            private void btnSave_Click(object sender, EventArgs e)
            {
                con.Open();
                string query = "INSERT INTO TSearchPattern (regularExpression, compareWith, action) VALUES ('" + txtRegExp.Text + "','" + cmbCompare.Text + "','" + cmbAction.Text + "')";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record inserted!");
            }

            private void btnUpd_Click(object sender, EventArgs e)
            {
                con.Open();
                string query = "UPDATE TSearchPattern SET regularExpression ='" + txtRegExp.Text + "', compareWith='" + cmbCompare.Text + "', action='" + cmbAction.Text + "' WHERE regularExpression=" + txtRegExp.Text;
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                con.Close();
                MessageBox.Show("Record updated!");
            }

            private void btnView_Click(object sender, EventArgs e)
            {
                con.Open();
                string query = "SELECT * FROM TSearchPattern";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

            }

            private void btnDel_Click(object sender, EventArgs e)
            {
                con.Open();
                string query = "DELETE FROM TSearchPattern WHERE regularExpression='" + txtRegExp.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                con.Close();
                MessageBox.Show("Record deleted!");

            }

            private void AdminSP_Load_1(object sender, EventArgs e)
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "searchBaseSP.TSearchPattern". При необходимости она может быть перемещена или удалена.
                this.tSearchPatternTableAdapter.Fill(this.searchBaseSP.TSearchPattern);

            }

            //private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
            //{
            //    txtRegExp.Text = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            //    cmbCompare.Text = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            //    cmbAction.Text = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            //}

        //TODO
        //1. delete
        //2. при выделении строки запихнуть значения в textbox
        //3. builder






    }
}
