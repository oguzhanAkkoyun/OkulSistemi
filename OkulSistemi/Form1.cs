﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmOgrenciNotlar fr = new frmOgrenciNotlar();
            fr.number = textBox1.Text;
            fr.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmOgretmen fr = new frmOgretmen();
            fr.Show();
            this.Hide();
        }
    }
}
