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


namespace Project_YHRS
{
    public partial class B_DoktorEkleSil : Form
    {
        static SqlConnection con;
        static SqlDataAdapter da;
        static SqlCommand cmd;
        static SqlDataReader dr;
        static DataSet ds;
        public static string SqlCon = @"Data Source=THEHELLBOY\SQLEXPRESS;Initial Catalog=Project Hospital Veritabanı;Integrated Security=True";
        public B_DoktorEkleSil()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

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

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult result2 = MessageBox.Show("Uygulamadan çıkmak istiyor musunuz?", "YHRS",
    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result2 == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                //boş kalacak.
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                string kayitSorgu = "insert into DoktorlarTablosu (D_Ad,D_Soyad,D_TCKimlik,D_Sifre,D_Cinsiyet,DPOL_Ad,D_DogumYeri) values (@ad, @soyad, @tc, @sifre, @cinsiyet, @polad, @dogumyeri)";
                string passhash;
                passhash = VeriTabanı.SHA256Sifrele(textBox5.Text);
                cmd = new SqlCommand(kayitSorgu, con);
                cmd.Parameters.AddWithValue("@ad", textBox1.Text);
                cmd.Parameters.AddWithValue("@soyad", textBox2.Text);
                cmd.Parameters.AddWithValue("@cinsiyet", comboBox1.Text);
                cmd.Parameters.AddWithValue("@tc", textBox3.Text);
                cmd.Parameters.AddWithValue("@sifre", passhash);
                cmd.Parameters.AddWithValue("@polad", comboBox2.Text);
                cmd.Parameters.AddWithValue("@dogumyeri", comboBox3.Text);
                VeriTabanı.KomutYollaParametreli(kayitSorgu, cmd);
                MessageBox.Show("Doktor eklendi.", "YHRS",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (radioButton2.Checked)
            {
                string kayitSorgu = "insert into YoneticilerTablosu (Y_Ad,Y_Soyad,Y_TCKimlik,Y_Sifre,Y_Cinsiyet,Y_DogumYeri) values (@ad, @soyad, @tc, @sifre, @cinsiyet, @dogumyeri)";
                string passhash;
                passhash = VeriTabanı.SHA256Sifrele(textBox5.Text);
                cmd = new SqlCommand(kayitSorgu, con);
                cmd.Parameters.AddWithValue("@ad", textBox1.Text);
                cmd.Parameters.AddWithValue("@soyad", textBox2.Text);
                cmd.Parameters.AddWithValue("@cinsiyet", comboBox1.Text);
                cmd.Parameters.AddWithValue("@tc", textBox3.Text);
                cmd.Parameters.AddWithValue("@sifre", passhash);
                cmd.Parameters.AddWithValue("@dogumyeri", comboBox3.Text);
                VeriTabanı.KomutYollaParametreli(kayitSorgu, cmd);
                MessageBox.Show("Yönetici eklendi.", "YHRS",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen doktor/yönetici seçiniz.", "YHRS",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            B_Sil b_Sil = new B_Sil();
            b_Sil.Show();
        }

        private void B_DoktorEkleSil_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label6.Visible = false;
            comboBox2.Visible = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label6.Visible = true;
            comboBox2.Visible = true;
        }
    }
}
