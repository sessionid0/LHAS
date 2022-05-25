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
    public partial class S_Profilim : Form
    {
        public S_Profilim()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İletişim bilgileriniz güncellenmiştir.", "YHRS",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }
    }
}
