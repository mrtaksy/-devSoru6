﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÖdevSoru6
{
    public partial class Form3 : Form
    {
        public Form1 frm1;
        public Form3()
        {
            InitializeComponent();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            frm1.Show();
            this.Hide();
        }
    }
}
