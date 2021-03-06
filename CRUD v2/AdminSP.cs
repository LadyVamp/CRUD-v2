﻿using System;
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
   "Data Source=DESKTOP-O9H5H8N;Initial Catalog=SearchBase;Integrated Security=True";


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
                MessageBox.Show("Запись добавлена");
            }

            private void btnUpd_Click(object sender, EventArgs e)
            {
                con.Open();
                string query = "UPDATE TSearchPattern SET regularExpression ='" + txtRegExp.Text + "', compareWith='" + cmbCompare.Text + "', action='" + cmbAction.Text + "' WHERE regularExpression=" + txtRegExp.Text;
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                con.Close();
                MessageBox.Show("Запись обновлена");
            }

            private void btnView_Click(object sender, EventArgs e)
            {
                con.Open();
                string query = "SELECT * FROM TSearchPattern ORDER BY ID";
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
                MessageBox.Show("Запись удалена");
            }

            private void AdminSP_Load_1(object sender, EventArgs e) //заполнить dataGridView1 при загрузке формы
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "searchBaseSP.TSearchPattern". При необходимости она может быть перемещена или удалена.
                //this.tSearchPatternTableAdapter.Fill(this.searchBaseSP.TSearchPattern);
                con.Open();
                string query = "SELECT * FROM TSearchPattern ORDER BY ID";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }

    }
}
