﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_v2
{
    public partial class MainAP : Form
    {
        public MainAP(string role)
        {
            InitializeComponent();
            lblRole.Text = role;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminSP f = new AdminSP();
            f.Show();
        }

    }
}