﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_YHRS
{
    public partial class B_DoktorEkleSil : Form
    {
        public B_DoktorEkleSil()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            S_Profilim s_Profilim = new S_Profilim();
            s_Profilim.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            S_Ayarlar s_Ayarlar = new S_Ayarlar();
            s_Ayarlar.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult result2 = MessageBox.Show("Uygulamadan çıkmak istiyor musunuz?", "YHRS",
    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result2 == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                //boş kalacak.
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                MessageBox.Show("Doktor eklendi.", "YHRS",
    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (radioButton2.Checked)
            {
                MessageBox.Show("Yönetici eklendi.", "YHRS",
    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen doktor/yönetici seçiniz.", "YHRS",
    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                MessageBox.Show("Doktor güncellendi.", "YHRS",
    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (radioButton2.Checked)
            {
                MessageBox.Show("Yönetici güncellendi.", "YHRS",
    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen doktor/yönetici seçiniz.", "YHRS",
    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                MessageBox.Show("Doktor silindi.", "YHRS",
    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (radioButton2.Checked)
            {
                MessageBox.Show("Yönetici silindi.", "YHRS",
    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen doktor/yönetici seçiniz.", "YHRS",
    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
