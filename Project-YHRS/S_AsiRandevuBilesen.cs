using System;
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
    public partial class S_AsiRandevuBilesen : Form
    {
        public S_AsiRandevuBilesen()
        {
            InitializeComponent();
            
        }

        private void S_AsiRandevuBilesen_Load(object sender, EventArgs e)
        {
            if(VeriTabanı.a == 1)
            {
                label1.Text = "Sinovac";
            }
            else if (VeriTabanı.a == 2)
            {
                label1.Text = "BionTech";
            }
            else
            {
                label1.Text = "Turcovac";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aşı randevusu başarıyla tamamlandı.", "YHRS",
        MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
