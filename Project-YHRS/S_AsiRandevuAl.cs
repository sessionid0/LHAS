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
    public partial class S_AsiRandevuAl : Form
    {
        public static int a = 0;
        public S_AsiRandevuAl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            S_AsiRandevuBilesen s_AsiRandevuBilesen = new S_AsiRandevuBilesen();
            VeriTabanı.a = 1;
            s_AsiRandevuBilesen.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            S_AsiRandevuBilesen s_AsiRandevuBilesen = new S_AsiRandevuBilesen();
            VeriTabanı.a = 2;
            s_AsiRandevuBilesen.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            S_AsiRandevuBilesen s_AsiRandevuBilesen = new S_AsiRandevuBilesen();
            VeriTabanı.a = 3;
            s_AsiRandevuBilesen.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            S_HastaPanel s_HastaPanel = new S_HastaPanel();
            s_HastaPanel.Show();
            this.Hide();
        }

        private void S_AsiRandevuAl_Load(object sender, EventArgs e)
        {

        }
    }
}
