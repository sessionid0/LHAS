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
    public partial class S_DoktorPanel : Form
    {
        static SqlConnection con;
        static SqlDataAdapter da;
        static SqlCommand cmd;
        static SqlDataReader dr;
        static DataSet ds;
        public static string SqlCon = @"Data Source=THEHELLBOY\SQLEXPRESS;Initial Catalog=Project Hospital Veritabanı;Integrated Security=True";
        public S_DoktorPanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)

        {
            S_DoktorPanel_Load(sender,e);
            VeriTabanı.recetehastatutucuad = textBox1.Text;
            VeriTabanı.recetehastatutucusoyad = textBox2.Text;
            this.Hide();

            

            S_ReceteOlustur s_ReceteOlustur = new S_ReceteOlustur();
            s_ReceteOlustur.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Hasta gelmedi olarak işaretlensin mi?", "YHRS",
    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result1 == DialogResult.Yes)
            {
                MessageBox.Show("Hasta gelmedi olarak işaretlendi.", "YHRS",
    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //boş kalacak.
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                textBox1.Text = row.Cells[0].Value.ToString();
                textBox2.Text = row.Cells[1].Value.ToString();
                textBox3.Text = row.Cells[2].Value.ToString();
                textBox4.Text = row.Cells[3].Value.ToString();


            }
        }

        private void S_DoktorPanel_Load(object sender, EventArgs e)
        {
            VeriTabanı.GridTumunuDoldur(dataGridView1, "select H_Ad 'Hasta Adı',H_Soyad 'Hasta Soyadı', H_Cinsiyet 'Cinsiyeti', H_DogumTarihi 'Doğum Tarihi' from HastalarTablosu");

        }
    }
}
