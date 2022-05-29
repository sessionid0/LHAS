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
    public partial class S_Profilim : Form
    {
        static SqlConnection con;
        static SqlDataAdapter da;
        static SqlCommand cmd;
        static SqlDataReader dr;
        static DataSet ds;
        public static string SqlCon = @"Data Source=THEHELLBOY\SQLEXPRESS;Initial Catalog=Project Hospital Veritabanı;Integrated Security=True";
        public static int a = 0;
        public S_Profilim()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            VeriTabanı.LoginDataKontrol(VeriTabanı.usertc, VeriTabanı.userpass);
            string informationupdate = "update HastalarTablosu set H_Telefon=@telefon, H_Eposta=@mail  where H_TCKimlik=@user";
            con = new SqlConnection(SqlCon);
            cmd = new SqlCommand(informationupdate, con);
            cmd.Parameters.AddWithValue("@user", textBox1.Text);
            cmd.Parameters.AddWithValue("@telefon", textBox8.Text);
            cmd.Parameters.AddWithValue("@mail", textBox7.Text);
            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
            VeriTabanı.KomutYollaParametreli(informationupdate, cmd);
            MessageBox.Show("İletişim bilgileriniz güncellenmiştir. Uygulamayı bir sonraki açışınızda güncel haline ulaşabilirsiniz.", "YHRS",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            VeriTabanı.LoginDataKontrol(VeriTabanı.usertc, VeriTabanı.userpass);
            S_Profilim_Load(sender, e);
            this.Hide();

        }

        private void S_Profilim_Load(object sender, EventArgs e)
        {
            if (VeriTabanı.login == 1)
            {
                VeriTabanı.LoginDataKontrol(VeriTabanı.usertc, VeriTabanı.userpass);
                textBox1.Text = VeriTabanı.usertc;
                textBox2.Text = VeriTabanı.h_name;
                textBox3.Text = VeriTabanı.h_surname;
                textBox4.Text = VeriTabanı.h_gender;
                textBox5.Text = VeriTabanı.h_dogumyeri;
                dateTimePicker1.Text = DateTime.Now.ToString(VeriTabanı.h_dogumtarihi);
                textBox7.Text = VeriTabanı.h_eposta;
                textBox8.Text = VeriTabanı.h_tel;
            }
            else if(VeriTabanı.login==2) {
                VeriTabanı.LoginDataKontrol(VeriTabanı.d_usertc, VeriTabanı.d_userpass);
                textBox1.Text = VeriTabanı.d_usertc;
                textBox2.Text = VeriTabanı.d_name;
                textBox3.Text = VeriTabanı.d_surname;
                textBox4.Text = VeriTabanı.d_gender;
                textBox5.Text = VeriTabanı.d_dogumyeri;
                dateTimePicker1.Text = DateTime.Now.ToString(VeriTabanı.d_dogumtarihi);
                textBox7.Text = VeriTabanı.d_eposta;
                textBox8.Text = VeriTabanı.d_tel;
            }
            else if(VeriTabanı.login==3) 
            {
                VeriTabanı.LoginDataKontrol(VeriTabanı.y_usertc, VeriTabanı.y_userpass);
                textBox1.Text = VeriTabanı.y_usertc;
                textBox2.Text = VeriTabanı.y_name;
                textBox3.Text = VeriTabanı.y_surname;
                textBox4.Text = VeriTabanı.y_gender;
                textBox5.Text = VeriTabanı.y_dogumyeri;
                dateTimePicker1.Text = DateTime.Now.ToString(VeriTabanı.y_dogumtarihi);
                textBox7.Text = VeriTabanı.y_eposta;
                textBox8.Text = VeriTabanı.y_tel;
            }
        }
    }
}
