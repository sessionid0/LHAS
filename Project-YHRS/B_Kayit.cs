using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace Project_YHRS
{
    public partial class B_Kayit : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        SqlDataReader dr;
        DataSet ds;
        public static string SqlCon = @"Data Source=THEHELLBOY\SQLEXPRESS;Initial Catalog=Project Hospital Veritabanı;Integrated Security=True";
       
        public B_Kayit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kayitSorgu = "insert into HastalarTablosu (H_Ad,H_Soyad,H_TCKimlik,H_Telefon,H_DogumYeri,H_DogumTarihi,H_Cinsiyet,H_Eposta,H_Sifre) values (@ad, @soyad, @tc, @tel, @dogumyeri, @dogumtarihi, @cinsiyet, @eposta, @sifre)";
            string passhash;
            passhash = VeriTabanı.SHA256Sifrele(textBox5.Text);
            cmd = new SqlCommand(kayitSorgu, con);
            cmd.Parameters.AddWithValue("@ad", textBox1.Text);
            cmd.Parameters.AddWithValue("@soyad", textBox2.Text);
            cmd.Parameters.AddWithValue("@tc", textBox6.Text);
            cmd.Parameters.AddWithValue("@tel", textBox3.Text);
            cmd.Parameters.AddWithValue("@dogumyeri", comboBox1.Text);
            cmd.Parameters.AddWithValue("@dogumtarihi", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@cinsiyet", comboBox2.Text);
            cmd.Parameters.AddWithValue("@eposta", textBox4.Text);
            cmd.Parameters.AddWithValue("@sifre", passhash);
            VeriTabanı.KomutYollaParametreli(kayitSorgu, cmd);

            MessageBox.Show("Kayıt olundu.", "YHRS",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
