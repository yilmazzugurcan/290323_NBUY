using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _290323_NBUY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            string ad = txtad.Text;
            listBox1.Items.Add(ad);
            txtad.Text = "Ad Girin";
            string soyad = txtsoyad.Text;
            listBox2.Items.Add(soyad);
            txtsoyad.Text = "Soyad Girin";
            string tc = txtTc.Text;
            listBox3.Items.Add(tc);
            txtTc.Text = "Tc Girin";
            string meslek = txtMeslek.Text;
            listBox6.Items.Add(meslek);
            txtMeslek.Text = "Meslek Girin";
            string tlf = txtTlf.Text;
            listBox4.Items.Add(tlf);
            txtTlf.Text = "Telefon Girin";
            string cinsiyet = comboBox1.SelectedItem.ToString();
            listBox5.Items.Add(cinsiyet);
            comboBox1.Items.Remove(cinsiyet);


        }

        private void txtad_Enter(object sender, EventArgs e)
        {
          //  txtad.Text = string.Empty;
        }

        private void txtsoyad_Enter(object sender, EventArgs e)
        {
          //  txtsoyad.Text = string.Empty;
        }

        private void txtTc_Enter(object sender, EventArgs e)
        {
           // txtTc.Text=string.Empty;
        }

        private void txtMeslek_Enter(object sender, EventArgs e)
        {
           // txtMeslek.Text = string.Empty;
        }

        private void txtTlf_Enter(object sender, EventArgs e)
        {
          //  txtTlf.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();
        }
    }
}
