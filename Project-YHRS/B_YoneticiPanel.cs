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
    public partial class B_YoneticiPanel : Form
    {
        public B_YoneticiPanel()
        {
            InitializeComponent();
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
    }
}
