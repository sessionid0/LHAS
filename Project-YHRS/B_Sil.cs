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
    public partial class B_Sil : Form
    {
        static SqlConnection con;
        static SqlDataAdapter da;
        static SqlCommand cmd;
        static SqlDataReader dr;
        static DataSet ds;
        public static string SqlCon = @"Data Source=THEHELLBOY\SQLEXPRESS;Initial Catalog=Project Hospital Veritabanı;Integrated Security=True";

        public B_Sil()
        {
            InitializeComponent();
        }

        private void B_Sil_Load(object sender, EventArgs e)
        {
            string Sql = "select D_Ad, D_Soyad from DoktorlarTablosu";
            SqlConnection conn = new SqlConnection(SqlCon);
            conn.Open();
            SqlCommand cmd = new SqlCommand(Sql, conn);
            SqlDataReader DR = cmd.ExecuteReader();

            while (DR.Read())
            {
                string dizi = DR[0] + " " + DR[1];
                comboBox2.Items.Add(dizi);

            }
        }
    }
}
