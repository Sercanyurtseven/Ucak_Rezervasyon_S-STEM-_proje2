using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ucak_Rezervasyon_SİSTEMİ_proje2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label8.Text = comboBox1.Text;
            comboBox1.Text = comboBox2.Text;
            comboBox2.Text = label8.Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(" Rota: " + comboBox1.Text + " - " + comboBox2.Text+ " Tarih: " + dateTimePicker1.Text + " Saat: " + textBox1.Text + " T.C: " + maskedTextBox3.Text+ "");
            MessageBox.Show("Biletiniz Alındı İyi Yolculuklar...");
        }
    }
}
