using System.Data;
using System.Data.SqlClient;

namespace Project_YHRS
{
    public partial class S_Ayarlar : Form
    {
        static SqlConnection con;
        static SqlDataAdapter da;
        static SqlCommand cmd;
        static SqlDataReader dr;
        static DataSet ds;
        public static string SqlCon = @"Data Source=DESKTOP-I8QAI56\SQLEXPRESS;Initial Catalog=Project Hospital Veritabanı;Integrated Security=True";
        public static int a = 0;
        public S_Ayarlar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {


            if (radioButton1.Checked == true)
            {
                VeriTabanı.tercih = true;
                string bilgilendirmetercih = "update HastalarTablosu set T_ID=@id where H_TCKimlik=@user";
                con = new SqlConnection(SqlCon);
                cmd = new SqlCommand(bilgilendirmetercih, con);
                cmd.Parameters.AddWithValue("@user", VeriTabanı.usertc);
                cmd.Parameters.AddWithValue("@id", true);
                con.Open();
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();
                VeriTabanı.KomutYollaParametreli(bilgilendirmetercih, cmd);
            }
            else
            {
                VeriTabanı.tercih = false;
                string bilgilendirmetercih = "update HastalarTablosu set T_ID=@id where H_TCKimlik=@user";
                con = new SqlConnection(SqlCon);
                cmd = new SqlCommand(bilgilendirmetercih, con);
                cmd.Parameters.AddWithValue("@user", VeriTabanı.usertc);
                cmd.Parameters.AddWithValue("@id", false);
                con.Open();
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();
                VeriTabanı.KomutYollaParametreli(bilgilendirmetercih, cmd);
            }

            MessageBox.Show("Bilgilendirme tercihiniz kaydedildi.", "YHRS",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (VeriTabanı.login == 1)
            {
                // MessageBox.Show("Veritabanına göre kimlik no:" + VeriTabanı.usertc + " ve sifre:" + VeriTabanı.userpass);

                if ((textBox1.Text) != null && (textBox2.Text) != null)
                {


                    if ((textBox1.Text) == (textBox2.Text))
                    {


                        string passupdate = "update HastalarTablosu set H_Sifre=@newpass where H_TCKimlik=@user and H_Sifre=@pass";
                        con = new SqlConnection(SqlCon);
                        cmd = new SqlCommand(passupdate, con);
                        cmd.Parameters.AddWithValue("@user", VeriTabanı.usertc);
                        cmd.Parameters.AddWithValue("@pass", VeriTabanı.userpass);
                        cmd.Parameters.AddWithValue("@newpass", VeriTabanı.SHA256Sifrele(textBox1.Text));
                        con.Open();
                        cmd.Connection = con;
                        cmd.ExecuteNonQuery();
                        con.Close();
                        VeriTabanı.KomutYollaParametreli(passupdate, cmd);
                        MessageBox.Show("Parolanız güncellenmiştir.", "YHRS",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox2.Clear();
                        textBox1.Clear();
                        this.Hide();
                    }

                    else
                    {

                        MessageBox.Show("Girdiğiniz iki parola birbiri ile uyuşmamaktadır. Lütfen kontrol ediniz.");
                    }



                }

                else
                {

                    MessageBox.Show("Lütfen tüm alanları doldurup yeniden deneyin.");

                }
            }
            else if (VeriTabanı.login == 2)
            {
                // MessageBox.Show("Veritabanına göre kimlik no:" + VeriTabanı.usertc + " ve sifre:" + VeriTabanı.userpass);

                if ((textBox1.Text) != null && (textBox2.Text) != null)
                {


                    if ((textBox1.Text) == (textBox2.Text))
                    {


                        string passupdate = "update DoktorlarTablosu set D_Sifre=@newpass where D_TCKimlik=@user and D_Sifre=@pass";
                        con = new SqlConnection(SqlCon);
                        cmd = new SqlCommand(passupdate, con);
                        cmd.Parameters.AddWithValue("@user", VeriTabanı.d_usertc);
                        cmd.Parameters.AddWithValue("@pass", VeriTabanı.d_userpass);
                        cmd.Parameters.AddWithValue("@newpass", VeriTabanı.SHA256Sifrele(textBox1.Text));
                        con.Open();
                        cmd.Connection = con;
                        cmd.ExecuteNonQuery();
                        con.Close();
                        VeriTabanı.KomutYollaParametreli(passupdate, cmd);
                        MessageBox.Show("Parolanız güncellenmiştir.", "YHRS",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox2.Clear();
                        textBox1.Clear();
                        this.Hide();
                    }

                    else
                    {

                        MessageBox.Show("Girdiğiniz iki parola birbiri ile uyuşmamaktadır. Lütfen kontrol ediniz.");
                    }



                }

                else
                {

                    MessageBox.Show("Lütfen tüm alanları doldurup yeniden deneyin.");

                }
            }
            else
            {
                // MessageBox.Show("Veritabanına göre kimlik no:" + VeriTabanı.usertc + " ve sifre:" + VeriTabanı.userpass);

                if ((textBox1.Text) != null && (textBox2.Text) != null)
                {


                    if ((textBox1.Text) == (textBox2.Text))
                    {


                        string passupdate = "update YoneticilerTablosu set Y_Sifre=@newpass where Y_TCKimlik=@user and Y_Sifre=@pass";
                        con = new SqlConnection(SqlCon);
                        cmd = new SqlCommand(passupdate, con);
                        cmd.Parameters.AddWithValue("@user", VeriTabanı.y_usertc);
                        cmd.Parameters.AddWithValue("@pass", VeriTabanı.y_userpass);
                        cmd.Parameters.AddWithValue("@newpass", VeriTabanı.SHA256Sifrele(textBox1.Text));
                        con.Open();
                        cmd.Connection = con;
                        cmd.ExecuteNonQuery();
                        con.Close();
                        VeriTabanı.KomutYollaParametreli(passupdate, cmd);
                        MessageBox.Show("Parolanız güncellenmiştir.", "YHRS",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox2.Clear();
                        textBox1.Clear();
                        this.Hide();
                    }

                    else
                    {

                        MessageBox.Show("Girdiğiniz iki parola birbiri ile uyuşmamaktadır. Lütfen kontrol ediniz.");
                    }



                }

                else
                {

                    MessageBox.Show("Lütfen tüm alanları doldurup yeniden deneyin.");

                }
            }
        }


        private void S_Ayarlar_Load(object sender, EventArgs e)
        {
            if (VeriTabanı.tercih = true)
            {
              radioButton1.Checked = true;
              radioButton2.Checked = false;

            }
            else
            {
                radioButton1.Checked = false;
                radioButton2.Checked = true;

            }
        }
    }
}

