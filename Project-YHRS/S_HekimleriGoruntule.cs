using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Project_YHRS
{
    public partial class S_HekimleriGoruntule : Form
    {
        static SqlConnection con;
        static SqlDataAdapter da;
        static SqlCommand cmd;
        static SqlDataReader dr;
        static DataSet ds;
        public static string SqlCon = @"Data Source=DESKTOP-I8QAI56\SQLEXPRESS;Initial Catalog=Project Hospital Veritabanı;Integrated Security=True";

        public S_HekimleriGoruntule()
        {
            InitializeComponent();
        }

        private void S_HekimleriGoruntule_Load(object sender, EventArgs e)
        {
            VeriTabanı.GridTumunuDoldur(dataGridView1, "select D_Ad 'Adı', D_Soyad 'Soyadı', D_Cinsiyet 'Cinsiyeti', DPOL_Ad 'Polikliniği'  from DoktorlarTablosu");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            S_HastaPanel s_HastaPanel = new S_HastaPanel();
            s_HastaPanel.Show();
            this.Hide();
        }
    }
}
