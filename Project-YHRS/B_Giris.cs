using System.Data;
using System.Data.SqlClient;

namespace Project_YHRS
{
    public partial class YHRS : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        SqlDataReader dr;
        DataSet ds;
        public static string SqlCon = @"Data Source=THEHELLBOY\SQLEXPRESS;Initial Catalog=Project Hospital Veritabanư;Integrated Security=True";
        public YHRS()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            B_Kayit b_Kayit = new B_Kayit();
            b_Kayit.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (VeriTabanư.login==1)
            {
                S_HastaPanel s_HastaPanel = new S_HastaPanel();
                string passhash;
                passhash = VeriTabanư.SHA256Sifrele(textBox1.Text);
                string sorgu = "select * from HastalarTablosu where H_TCKimlik =@user and H_Sifre =@pass";
                con = new SqlConnection(SqlCon);
                cmd = new SqlCommand(sorgu, con);
                cmd.Parameters.AddWithValue("@user", textBox2.Text);
                cmd.Parameters.AddWithValue("@pass", passhash);
                con.Open();
                dr = cmd.ExecuteReader();

                VeriTabanư.LoginDataKontrol(textBox2.Text, textBox1.Text);



                if (dr.Read() == true)
                {

                    VeriTabanư.userpass = passhash;
                    VeriTabanư.usertc = dr["H_TCKimlik"].ToString();
                    VeriTabanư.h_name = (dr["H_Ad"].ToString());
                    VeriTabanư.h_surname = (dr["H_Soyad"].ToString());
                    VeriTabanư.h_gender = (dr["H_Cinsiyet"].ToString());
                    VeriTabanư.h_dogumyeri = (dr["H_DogumYeri"].ToString());
                    VeriTabanư.h_dogumtarihi = (dr["H_DogumTarihi"].ToString());
                    VeriTabanư.h_eposta = (dr["H_Eposta"].ToString());
                    VeriTabanư.h_tel = (dr["H_Telefon"].ToString());
                    s_HastaPanel.Show();

                    this.Hide();

                    con.Close();

                }
                else
                {
                    con.Close();
                    MessageBox.Show("Kullanưcư adư veya ₫ifre hatalưdưr.");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox2.Focus();

                }
            }

            else if (VeriTabanư.login == 2)
            {
                S_DoktorPanel s_DoktorPanel = new S_DoktorPanel();
                string passhash;
                passhash = VeriTabanư.SHA256Sifrele(textBox1.Text);
                string sorgu = "select * from DoktorlarTablosu where D_TCKimlik =@tc and D_Sifre =@pass"; con = new SqlConnection(SqlCon);
                cmd = new SqlCommand(sorgu, con);
                cmd.Parameters.AddWithValue("@tc", textBox2.Text);
                cmd.Parameters.AddWithValue("@pass", passhash);
                con.Open();
                dr = cmd.ExecuteReader();

                VeriTabanư.LoginDataKontrol(textBox2.Text, textBox1.Text);



                if (dr.Read() == true)
                {

                    VeriTabanư.d_userpass = passhash;
                    VeriTabanư.d_usertc = dr["D_TCKimlik"].ToString();
                    VeriTabanư.d_name = (dr["D_Ad"].ToString());
                    VeriTabanư.d_surname = (dr["D_Soyad"].ToString());
                    VeriTabanư.d_gender = (dr["D_Cinsiyet"].ToString());
                    VeriTabanư.d_dogumyeri = (dr["D_DogumYeri"].ToString());
                    VeriTabanư.d_dogumtarihi = (dr["D_DogumTarihi"].ToString());
                    VeriTabanư.d_eposta = (dr["D_Eposta"].ToString());
                    VeriTabanư.d_tel = (dr["D_Telefon"].ToString());
                    s_DoktorPanel.Show();

                    this.Hide();

                    con.Close();

                }
                else
                {
                    con.Close();
                    MessageBox.Show("Kullanưcư adư veya ₫ifre hatalưdưr.");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox2.Focus();

                }
            }

            else if (VeriTabanư.login == 3)
            {
                B_YoneticiPanel b_YoneticiPanel = new B_YoneticiPanel();
                string passhash;
                passhash = VeriTabanư.SHA256Sifrele(textBox1.Text);
                string sorgu = "select * from YoneticilerTablosu where Y_TCKimlik =@tc and Y_Sifre =@pass"; 
                con = new SqlConnection(SqlCon);
                cmd = new SqlCommand(sorgu, con);
                cmd.Parameters.AddWithValue("@tc", textBox2.Text);
                cmd.Parameters.AddWithValue("@pass", passhash);
                con.Open();
                dr = cmd.ExecuteReader();

                VeriTabanư.LoginDataKontrol(textBox2.Text, textBox1.Text);



                if (dr.Read() == true)
                {

                    VeriTabanư.y_userpass = passhash;
                    VeriTabanư.y_usertc = dr["Y_TCKimlik"].ToString();
                    VeriTabanư.y_name = (dr["Y_Ad"].ToString());
                    VeriTabanư.y_surname = (dr["Y_Soyad"].ToString());
                    VeriTabanư.y_gender = (dr["Y_Cinsiyet"].ToString());
                    VeriTabanư.y_dogumyeri = (dr["Y_DogumYeri"].ToString());
                    VeriTabanư.y_dogumtarihi = (dr["Y_DogumTarihi"].ToString());
                    VeriTabanư.y_eposta = (dr["Y_Eposta"].ToString());
                    VeriTabanư.y_tel = (dr["Y_Telefon"].ToString());
                    b_YoneticiPanel.Show();

                    this.Hide();

                    con.Close();

                }
                else
                {
                    con.Close();
                    MessageBox.Show("Kullanưcư adư veya ₫ifre hatalưdưr.");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox2.Focus();

                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbl_HastaGirisi.Visible = false;
            lbl_DoktorGirisi.Visible = true;
            lbl_YoneticiGirisi.Visible = false;
            VeriTabanư.login = 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbl_HastaGirisi.Visible = false;
            lbl_DoktorGirisi.Visible = false;
            lbl_YoneticiGirisi.Visible = true;
            VeriTabanư.login = 3;
        }

        private void YHRS_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            lbl_HastaGirisi.Visible = true;
            lbl_DoktorGirisi.Visible = false;
            lbl_YoneticiGirisi.Visible = false;
            VeriTabanư.login = 1;
        }
    }
}