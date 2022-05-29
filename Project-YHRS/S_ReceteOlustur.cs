using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Project_YHRS
{
    public partial class S_ReceteOlustur : Form
    {
        static SqlConnection con;
        static SqlDataAdapter da;
        static SqlCommand cmd;
        static SqlDataReader dr;
        static DataSet ds;
        public static string SqlCon = @"Data Source=THEHELLBOY\SQLEXPRESS;Initial Catalog=Project Hospital Veritabanı;Integrated Security=True";

        public S_ReceteOlustur()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VeriTabanı.receterandomcode = VeriTabanı.RandomString(7);
            string receteolustur = "update RandevularTablosu set R_BGerceklesme=@bitgerceklesme, R_Gerceklesme=@gerceklesme, H_ReceteKod=@recetekod  where R_Ad=@hastaname and R_Soyad=@hastasurname";
            con = new SqlConnection(SqlCon);
            cmd = new SqlCommand(receteolustur, con);
            cmd.Parameters.AddWithValue("@hastaname", VeriTabanı.recetehastatutucuad);
            cmd.Parameters.AddWithValue("@hastasurname", VeriTabanı.recetehastatutucusoyad);
            cmd.Parameters.AddWithValue("@recetekod", VeriTabanı.receterandomcode);
            cmd.Parameters.AddWithValue("@bitgerceklesme", true);
            cmd.Parameters.AddWithValue("@gerceklesme", "Tamamlanan randevu");
            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
            VeriTabanı.KomutYollaParametreli(receteolustur, cmd);
            MessageBox.Show("Reçete başarıyla oluşturuldu, reçete kodu: " + VeriTabanı.receterandomcode, "YHRS",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            S_DoktorPanel s_DoktorPanel = new S_DoktorPanel();
            s_DoktorPanel.Show();
            
            //MessageBox.Show("Reçete kaydedildi", "YHRS",
            // MessageBoxButtons.OK, MessageBoxIcon.Information);
            //this.Hide();
        }
    }
}
