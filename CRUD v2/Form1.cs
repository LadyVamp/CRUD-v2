﻿using System;
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

        SearchPattern s = new SearchPattern();
        File f = new File();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            SearchPatternAR sp = new SearchPatternAR();
            sp.RegularExpression = txtRegExp.Text;
            sp.Action = cmbCompare.Text;
            sp.CompareWith = cmbAction.Text;
            s.Create(sp);
            MessageBox.Show("Запись успешно добавлена");
        }

        //  Пример активной записи
        private void btnInsertXYZ_Click(object sender, EventArgs e)
        {
            SearchPatternAR sp = new SearchPatternAR();
            sp.RegularExpression = "XYZ";
            sp.Action = "XYZ";
            sp.CompareWith = "XYZ";
            s.Create(sp);
            MessageBox.Show("Запись " + "'XYZ'" + " успешно добавлена");
        }



        private void btnFillCombobox_Click(object sender, EventArgs e)
        {
            cmbPatterns.DataSource = s.Read();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SearchPatternAR oldPattern = new SearchPatternAR(); 
            SearchPatternAR newPattern = new SearchPatternAR(); 

            oldPattern = cmbPatterns.SelectedItem as SearchPatternAR; 

            newPattern.RegularExpression = txtNewRegExp.Text;
            newPattern.CompareWith = cmbNewCompare.Text;
            newPattern.Action = cmbNewAction.Text;

            s.Update(oldPattern, newPattern); 

            MessageBox.Show("Запись обновлена");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SearchPatternAR sp = new SearchPatternAR();
            sp = cmbPatterns.SelectedItem as SearchPatternAR;

            s.Delete(sp);
            MessageBox.Show("Запись удалена");
        }


        //строка соединения с БД
   //     private const string CONNECTION_STRING =
   //"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SearchBase;Data Source=NADYA-PC";
         private const string CONNECTION_STRING =
   "Data Source=DESKTOP-O9H5H8N;Initial Catalog=SearchBase;Integrated Security=True";
        

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "searchBaseDataSetActionCmb.TSearchPattern". При необходимости она может быть перемещена или удалена.
            this.tSearchPatternTableAdapter1.Fill(this.searchBaseDataSetActionCmb.TSearchPattern);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "searchBaseDataSetNewCompareCmb.TSearchPattern". При необходимости она может быть перемещена или удалена.
            this.tSearchPatternTableAdapter.Fill(this.searchBaseDataSetNewCompareCmb.TSearchPattern);
            
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
                      
        //  Поиск по ключевым словам
        private void btnSearchKeywords_Click(object sender, EventArgs e)   
        {
            try 
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)    
                {
                    row.Selected = false;
                    // Если в текстовом поле, отвечающем за поиск в первом столбце, что-то есть
                    if (txtKeywords.TextLength > 0) 
                    {
                        // Если текст совпадает
                        if (row.Cells[1].Value.ToString() == txtKeywords.Text)  
                        {
                            // Выделяем строку
                            row.Selected = true;    
                            // Завершаем поиск
                            break;
                        }
                       
                    } 

                } 
            }

            catch 
            {
                MessageBox.Show("Ключевое слово отсутствует"); 
            } 
        } 

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked) //   doc   
            {
                dataGridView1.DataSource = f.SelectDoc();
            }

            if (checkBox2.Checked) //   docx
            {
                dataGridView1.DataSource = f.SelectDocx();
            }

            if (checkBox3.Checked) //   txt   
            {
                dataGridView1.DataSource = f.SelectTxt();
            }

            if (checkBox4.Checked) //   rtf    
            {
                dataGridView1.DataSource = f.SelectRtf();
            }

            if ((checkBox1.Checked) & (checkBox2.Checked)) //  doc & docx
            {
                dataGridView1.DataSource = f.SelectDocAndDocx();
            }

            if ((checkBox1.Checked) & (checkBox3.Checked)) //   doc & txt
            {
                dataGridView1.DataSource = f.SelectDocAndTxt();
            }

            if ((checkBox1.Checked) & (checkBox4.Checked)) //   doc & rtf
            {
                dataGridView1.DataSource = f.SelectDocAndRtf();
            }

            if ((checkBox2.Checked) & (checkBox3.Checked)) //   docx & txt
            {
                dataGridView1.DataSource = f.SelectDocxAndTxt();
            }

            if ((checkBox3.Checked) & (checkBox4.Checked)) //   txt & rtf
            {
                dataGridView1.DataSource = f.SelectTxtAndRtf();
            }


            if ((checkBox1.Checked) & (checkBox2.Checked) & (checkBox3.Checked)) // doc & docx & txt
            {
                dataGridView1.DataSource = f.SelectDocAndDocxAndTxt();
            }

            if ((checkBox1.Checked) & (checkBox2.Checked) & (checkBox3.Checked) & (checkBox4.Checked)) //   doc & docx & txt & rtf
            {
                dataGridView1.DataSource = f.SelectDocAndDocxAndTxtAndRtf();
            }
        }

        private void btnEnterLogin_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            f.Show();
            //this.Hide();
        }

        private void btnAllFiles_Click(object sender, EventArgs e)
        {
            //заполнить dataGridView 
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


    }
}
