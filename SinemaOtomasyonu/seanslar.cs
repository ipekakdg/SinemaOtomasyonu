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
 
namespace SinemaOtomasyonu
{
    public partial class seanslar : Form
    {
        public seanslar()
        {
            InitializeComponent();
        }
        
        SqlConnection baglanti = new SqlConnection("Data Source=localhost\\SQLExpress; initial Catalog=sinema; Integrated Security=true");

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand ekle = new SqlCommand("insert into seans(seans_adi,seans_tarih,seans_saat) values('" + textBox1.Text + "','" + dateTimePicker1.Text + "','" + maskedTextBox1.Text + "')", baglanti);
            ekle.ExecuteNonQuery();
            ekle.Dispose();
            baglanti.Close();
            MessageBox.Show("Seans Ekleme İşlemi Başarılı");
            textBox1.Text = "";
            maskedTextBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void seanslar_Load(object sender, EventArgs e)
        {

        }
    }
}
