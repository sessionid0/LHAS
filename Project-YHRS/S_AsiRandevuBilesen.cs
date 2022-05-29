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
    public partial class S_AsiRandevuBilesen : Form
    {

        static SqlConnection con;
        static SqlDataAdapter da;
        static SqlCommand cmd;
        static SqlDataReader dr;
        static DataSet ds;
        public static string SqlCon = @"Data Source=THEHELLBOY\SQLEXPRESS;Initial Catalog=Project Hospital Veritabanı;Integrated Security=True";

        public S_AsiRandevuBilesen()
        {
            InitializeComponent();

        }

        private void S_AsiRandevuBilesen_Load(object sender, EventArgs e)
        {

            if (VeriTabanı.a == 1)
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
            string asirandevu = "insert into RandevularTablosu (R_Tarih,R_Saat,R_Ad,R_Soyad,R_Aciklama,AR_Tur,POL_Ad) values (@tarih, @saat, @ad, @soyad, @aciklama, @tur, @tur)";
            cmd = new SqlCommand(asirandevu, con);
            cmd.Parameters.AddWithValue("@tarih", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@saat", comboBox1.Text);
            cmd.Parameters.AddWithValue("@ad", VeriTabanı.h_name);
            cmd.Parameters.AddWithValue("@soyad", VeriTabanı.h_surname);
            cmd.Parameters.AddWithValue("@tur", label1.Text);
            //cmd.Parameters.AddWithValue("@id", "404");
            cmd.Parameters.AddWithValue("@aciklama", "Aşı Randevusu");

            VeriTabanı.KomutYollaParametreli(asirandevu, cmd);
            MessageBox.Show("Aşı randevusu başarıyla tamamlandı.", "YHRS",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            S_HastaPanel s_HastaPanel = new S_HastaPanel();
            s_HastaPanel.Show();
            this.Hide();
        }
    }
}
