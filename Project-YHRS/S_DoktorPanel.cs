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
    public partial class S_DoktorPanel : Form
    {
        public S_DoktorPanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            S_ReceteOlustur s_ReceteOlustur  = new S_ReceteOlustur();
            s_ReceteOlustur.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Hasta gelmedi olarak işaretlensin mi?", "YHRS",
    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result1 == DialogResult.Yes)
            {
                MessageBox.Show("Hasta gelmedi olarak işaretlendi.", "YHRS",
    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
              //boş kalacak.
            }
        }
    }
}
