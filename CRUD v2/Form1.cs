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

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SearchPattern sp = new SearchPattern();
            sp = cmbPatterns.SelectedItem as SearchPattern;

            b.Delete(sp);
            MessageBox.Show("Запись удалена");
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            SearchPattern sp = new SearchPattern();
            sp.RegularExpression = txtRegExp.Text;
            sp.Action = cmbCompare.Text;
            sp.CompareWith = cmbAction.Text;
            b.Insert(sp);
            MessageBox.Show("Запись успешно добавлена");

        }


        private void btnFillCombobox_Click(object sender, EventArgs e)
        {
            cmbPatterns.DataSource = b.FillCombobox();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SearchPattern oldPattern = new SearchPattern();
            SearchPattern newPattern = new SearchPattern();

            oldPattern = cmbPatterns.SelectedItem as SearchPattern;

            newPattern.RegularExpression = txtNewRegExp.Text;
            newPattern.CompareWith = cmbNewCompare.Text;
            newPattern.Action = cmbNewAction.Text;

            b.Update(oldPattern, newPattern);

            MessageBox.Show("Запись обновлена");
        }

        //строка соединения с БД
        private const string CONNECTION_STRING =
   "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SearchBase;Data Source=NADYA-PC";

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "searchBaseDataSetFileWithoutID.TFile". При необходимости она может быть перемещена или удалена.
            this.tFileTableAdapter1.Fill(this.searchBaseDataSetFileWithoutID.TFile);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "searchBaseDataSetFile.TFile". При необходимости она может быть перемещена или удалена.
            this.tFileTableAdapter.Fill(this.searchBaseDataSetFile.TFile);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "searchBaseDataSet.TAction". При необходимости она может быть перемещена или удалена.
            //выпадающий список для выбора "Действие"
            this.tActionTableAdapter.Fill(this.searchBaseDataSet.TAction);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "searchBaseDataSet.TCompare". При необходимости она может быть перемещена или удалена.
            //выпадающий список для выбора "Сравнивать с"
            this.tCompareTableAdapter.Fill(this.searchBaseDataSet.TCompare);


            //заполнить dataGridView при запуске формы
            DataSet ds = new DataSet();
            SqlConnection dataBaseConnection = new SqlConnection(CONNECTION_STRING);
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM TFile", dataBaseConnection);
            dataAdapter.Fill(ds, "TFile");
            dataGridView1.DataSource = ds.Tables["TFile"];
            dataGridView1.Columns[0].HeaderText = "Название";
            dataGridView1.Columns[1].HeaderText = "Ключевые слова";
            dataGridView1.Columns[2].HeaderText = "Размер, КБ"; 
            dataGridView1.Columns[3].HeaderText = "Формат";
            dataGridView1.Columns[4].HeaderText = "Содержание";
            dataGridView1.Columns[2].Width = 70;
            dataGridView1.Columns[3].Width = 70;
            dataGridView1.Columns[4].Width = 145;
        }
                      
        //  Пример активной записи
        private void btnInsertXYZ_Click(object sender, EventArgs e)
        {
            SearchPattern sp = new SearchPattern();
            sp.RegularExpression = "XYZ";
            sp.Action = "XYZ";
            sp.CompareWith = "XYZ";
            b.Insert(sp);
            MessageBox.Show("Запись " + "'XYZ'" + " успешно добавлена");
        }
 
        //  Поиск по ключевым словам
        private void btnSearchKeywords_Click(object sender, EventArgs e)    //  1
        {
            try // 2
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)     //  3
                {
                    row.Selected = false;
                    // Если в текстовом поле, отвечающем за поиск в первом столбце, что-то есть
                    if (txtKeywords.TextLength > 0) //  4
                    {
                        // Если текст совпадает
                        if (row.Cells[1].Value.ToString() == txtKeywords.Text)  // 5
                        {
                            // Выделяем строку
                            row.Selected = true;    // 6
                            // Завершаем поиск
                            break;
                        }
                       
                    } // 7

                } // 8
            } // 9

            catch 
            {
                MessageBox.Show("Ключевое слово отсутствует"); // 10
            } 
        } // 11

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked) //   doc   
            {
                dataGridView1.DataSource = b.SelectDoc();
            }

            if (checkBox2.Checked) //   docx
            {
                dataGridView1.DataSource = b.SelectDocx();
            }

            if (checkBox3.Checked) //   txt   
            {
                dataGridView1.DataSource = b.SelectTxt();
            }

            if (checkBox4.Checked) //   rtf    
            {
                dataGridView1.DataSource = b.SelectRtf();
            }

            if ((checkBox1.Checked) & (checkBox2.Checked)) //  doc & docx
            {
                dataGridView1.DataSource = b.SelectDocAndDocx();
            }

            if ((checkBox1.Checked) & (checkBox3.Checked)) //   doc & txt
            {
                dataGridView1.DataSource = b.SelectDocAndTxt();
            }

            if ((checkBox1.Checked) & (checkBox4.Checked)) //   doc & rtf
            {
                dataGridView1.DataSource = b.SelectDocAndRtf();
            }

            if ((checkBox2.Checked) & (checkBox3.Checked)) //   docx & txt
            {
                dataGridView1.DataSource = b.SelectDocxAndTxt();
            }

            if ((checkBox1.Checked) & (checkBox2.Checked) & (checkBox3.Checked)) // doc & docx & txt
            {
                dataGridView1.DataSource = b.SelectDocAndDocxAndTxt();
            }

            if ((checkBox1.Checked) & (checkBox2.Checked) & (checkBox3.Checked) & (checkBox4.Checked)) //   doc & docx & txt & rtf
            {
                dataGridView1.DataSource = b.SelectDocAndDocxAndTxtAndRtf();
            }
        } 


    }
}
