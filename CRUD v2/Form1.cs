using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using Session;

using System.Data.SqlClient;

namespace CRUD_v2
{
    public partial class Form1 : Form
    {

        Broker b = new Broker();
        //SearchPattern sp = new SearchPattern();

        SqlConnection con = new SqlConnection(@"Data Source=NADYA-PC;Initial Catalog=SearchBase;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }

        public void disp_data() 
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "SELECT * FROM TSearchPattern";
            cmd.CommandText = "SELECT regularExpression, compareWith, action FROM TSearchPattern";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "Шаблон";
            dataGridView1.Columns[1].HeaderText = "Сравнивать с";
            dataGridView1.Columns[2].HeaderText = "Действие";
            con.Close();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            //SearchPattern arsp = new SearchPattern();
            //arsp = cmbPatterns.SelectedItem as SearchPattern;

            //SearchPattern arsp = new SearchPattern();

            //b.Delete();
            ////MessageBox.Show("Запись удалена");
            //disp_data();

            //DataRow current = ((DataRowView)dataGridView1.CurrentRow.DataBoundItem).Row;
            //current.Delete();
            //MessageBox.Show("Запись удалена");
            //disp_data();

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "SELECT * FROM TSearchPattern";
            cmd.CommandText = "DELETE FROM TSearchPattern WHERE regularExpression='"+txtRegExp.Text+"'";
            cmd.ExecuteNonQuery();
            con.Close();
            disp_data();


        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            SearchPattern arsp = new SearchPattern();
            arsp.RegularExpression = txtRegExp.Text;
            arsp.Action = cmbCompare.Text;
            arsp.CompareWith = cmbAction.Text;
            b.Insert(arsp);
            MessageBox.Show("Запись успешно добавлена");
            disp_data();

        }


        private void btnFillCombobox_Click(object sender, EventArgs e)
        {
            //cmbPatterns.DataSource = b.FillCombobox();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //SearchPattern oldPattern = new SearchPattern();
            //SearchPattern newPattern = new SearchPattern();

            //oldPattern = cmbPatterns.SelectedItem as SearchPattern;

            //newPattern.RegularExpression = txtNewRegExp.Text;
            //newPattern.CompareWith = cmbNewCompare.Text;
            //newPattern.Action = cmbNewAction.Text;

            //b.Update(oldPattern, newPattern);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "searchBaseDataSet1.TSearchPattern". При необходимости она может быть перемещена или удалена.
            this.tSearchPatternTableAdapter.Fill(this.searchBaseDataSet1.TSearchPattern);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "searchBaseDataSet.TAction". При необходимости она может быть перемещена или удалена.
            //выпадающий список для выбора "Действие"
            this.tActionTableAdapter.Fill(this.searchBaseDataSet.TAction);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "searchBaseDataSet.TCompare". При необходимости она может быть перемещена или удалена.
            //выпадающий список для выбора "Сравнивать с"
            this.tCompareTableAdapter.Fill(this.searchBaseDataSet.TCompare);

            disp_data();

        }







    }
}
