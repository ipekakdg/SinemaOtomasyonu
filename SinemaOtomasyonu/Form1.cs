﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SinemaOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            seanslar seans = new seanslar();
            seans.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            salonlar salon = new salonlar();
            salon.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bilet_Kes frm = new Bilet_Kes();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            filmler flm = new filmler();
            flm.Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }
    }
}
