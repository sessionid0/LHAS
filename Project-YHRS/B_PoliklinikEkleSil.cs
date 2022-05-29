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
    public partial class B_PoliklinikEkleSil : Form
    {
        public static string polad = "";

        static SqlConnection con;
        static SqlDataAdapter da;
        static SqlCommand cmd;
        static SqlDataReader dr;
        static DataSet ds;
        public static string SqlCon = @"Data Source=DESKTOP-I8QAI56\SQLEXPRESS;Initial Catalog=Project Hospital Veritabanı;Integrated Security=True";
        public static int a = 0;

        public B_PoliklinikEkleSil()
        {
            InitializeComponent();
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
            string kayitSorgu = "insert into PolikliniklerTablosu (POL_Ad) values (@polad)";
            cmd = new SqlCommand(kayitSorgu, con);
            cmd.Parameters.AddWithValue("@polad", textBox1.Text);
            VeriTabanı.KomutYollaParametreli(kayitSorgu, cmd);

            MessageBox.Show("Poliklinik eklendi.", "YHRS",
            MessageBoxButtons.OK, MessageBoxIcon.Information);

            B_PoliklinikEkleSil_Load(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {


            B_PoliklinikEkleSil_Load(sender, e);
            string passupdate = "update PolikliniklerTablosu set POL_Ad=@polad where POL_ID=@polid";
            con = new SqlConnection(SqlCon);
            cmd = new SqlCommand(passupdate, con);
            cmd.Parameters.AddWithValue("@polad", textBox1.Text);
            cmd.Parameters.AddWithValue("@polid", Convert.ToInt64(textBox2.Text));

            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
            VeriTabanı.KomutYollaParametreli(passupdate, cmd);
          
            MessageBox.Show("Poliklinik güncellendi.", "YHRS",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
           
            B_PoliklinikEkleSil_Load(sender, e);
            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Poliklinik silindi.", "YHRS",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void B_PoliklinikEkleSil_Load(object sender, EventArgs e)
        {
            string sorgu = "select * from PolikliniklerTablosu";
            VeriTabanı.GridTumunuDoldur(dataGridView1, sorgu);
          
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
