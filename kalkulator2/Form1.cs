using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulator2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b, c;
                a = double.Parse(nilai1.Text);
                b = double.Parse(nilai2.Text);
                c = a + b;
                hasil.Text = c.ToString();
            }
            catch (FormatException a) {
                MessageBox.Show("Harap masukkan angka terlebih dahulu");
            }
            
        }

        private void btn_kurang_Click(object sender, EventArgs e)
        {          
            try
            {
                double a, b, c;
                a = double.Parse(nilai1.Text);
                b = double.Parse(nilai2.Text);
                c = a - b;
                hasil.Text = c.ToString();
            }
            catch (FormatException a)
            {
                MessageBox.Show("Harap masukkan angka terlebih dahulu");
            }
        }

        private void btn_kali_Click(object sender, EventArgs e)
        {           
            try
            {
                double a, b, c;
                a = double.Parse(nilai1.Text);
                b = double.Parse(nilai2.Text);
                c = a * b;
                hasil.Text = c.ToString();
            }
            catch (FormatException a)
            {
                MessageBox.Show("Harap masukkan angka terlebih dahulu");
            }
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {         
            try
            {
                double a, b, c;
                a = double.Parse(nilai1.Text);
                b = double.Parse(nilai2.Text);
                c = a / b;
                hasil.Text = c.ToString();
            }
            catch (FormatException a)
            {
                MessageBox.Show("Harap masukkan angka terlebih dahulu");
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            {
                nilai1.Clear();
                nilai2.Clear();
                hasil.Clear();
            }
        }
    }
}
