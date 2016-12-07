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

namespace CRUD_v2
{
    public partial class Form1 : Form
    {

        Broker b = new Broker();
        //SearchPattern sp = new SearchPattern();

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

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "searchBaseDataSet.TAction". При необходимости она может быть перемещена или удалена.
            //выпадающий список для выбора "Действие"
            this.tActionTableAdapter.Fill(this.searchBaseDataSet.TAction);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "searchBaseDataSet.TCompare". При необходимости она может быть перемещена или удалена.
            //выпадающий список для выбора "Сравнивать с"
            this.tCompareTableAdapter.Fill(this.searchBaseDataSet.TCompare);

        }







    }
}
