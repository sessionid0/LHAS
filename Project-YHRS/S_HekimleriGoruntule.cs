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
    public partial class S_HekimleriGoruntule : Form
    {
        public S_HekimleriGoruntule()
        {
            InitializeComponent();
        }

        private void S_HekimleriGoruntule_Load(object sender, EventArgs e)
        {
            VeriTabanı.GridTumunuDoldur(dataGridView1, "DoktorTablosu");
        }
    }
}
