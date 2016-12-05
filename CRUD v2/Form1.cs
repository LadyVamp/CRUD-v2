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
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            SearchPattern sp = new SearchPattern();
            sp.RegularExpression = txtRegExp.Text;
            sp.Action = cmbCompare.Text;
            sp.CompareWith = cmbAction.Text;

            b.Insert(sp);

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
        }







    }
}
