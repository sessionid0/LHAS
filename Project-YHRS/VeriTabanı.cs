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
    internal class VeriTabanı

    {
        public static string h_name = "";
        public static string h_surname = "";
        public static string h_gender = "";
        public static string h_dogumyeri = "";
        public static string h_dogumtarihi = "";
        public static string h_eposta = "";
        public static string h_tel = "";
        public static string userpass = "";
        public static string usertc = "";



        static SqlConnection con;
        static SqlDataAdapter da;
        static SqlCommand cmd;
        static SqlDataReader dr;
        static DataSet ds;
        public static string SqlCon = @"Data Source=DESKTOP-I8QAI56\SQLEXPRESS;Initial Catalog=Project Hospital Veritabanı;Integrated Security=True";
        public static int a = 0;

        public static string SHA256Sifrele(string sifremetin)
        {
            SHA256 sHA256Hash = SHA256.Create();
            //byte[] dizi = sHA256Hash.ComputeHash(Encoding.UTF8.GetBytes(sifremetin));
            byte[] dizi = Encoding.UTF8.GetBytes(sifremetin);
            dizi = sHA256Hash.ComputeHash(dizi);

            StringBuilder stringBuilder = new StringBuilder();
            foreach (byte item in dizi)
            {
                stringBuilder.Append(item.ToString("x2").ToLower());
            }


            return stringBuilder.ToString();
        }

        public static void KomutYollaParametreli(string sql, SqlCommand cmd)
        {
            con = new SqlConnection(SqlCon);
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static void LoginDataKontrol(string kullaniciadi, string sifre)
        {
            string passhash;
            passhash = VeriTabanı.SHA256Sifrele(sifre);
            string sorgu = "select * from HastalarTablosu where H_TCKimlik =@tc and H_Sifre =@pass";
            con = new SqlConnection(SqlCon);
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@tc", kullaniciadi);
            cmd.Parameters.AddWithValue("@pass", passhash);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {
                
                userpass = passhash;
                usertc = kullaniciadi;
                h_name= (dr["H_Ad"].ToString());
                h_surname = (dr["H_Soyad"].ToString());
                h_gender = (dr["H_Cinsiyet"].ToString());
                h_dogumyeri = (dr["H_DogumYeri"].ToString());
                h_dogumtarihi = (dr["H_DogumTarihi"].ToString());
                h_eposta = (dr["H_Eposta"].ToString());
                h_tel = (dr["H_Telefon"].ToString());

                con.Close();


            }
            else
            {
                
                con.Close();

            }

        }



        public static DataGridView GridTumunuDoldur(DataGridView gridim, string selectSqlSorgu)
        {
            con = new SqlConnection(SqlCon);
            da = new SqlDataAdapter("select * from " + selectSqlSorgu, con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, selectSqlSorgu);

            gridim.DataSource = ds.Tables[selectSqlSorgu];
            con.Close();
            return gridim;
        }
        public static bool BaglantiDurum()
        {
            //Veritabanı bağlantı kontrolü
            using (con = new SqlConnection(SqlCon))
            {
                try
                {
                    con.Open();
                    MessageBox.Show("Bağlantı kuruldu.");
                    return true;
                }
                catch (SqlException)
                {
                    MessageBox.Show("Bağlantı kurulamadı.");
                    return false;
                }
            }
        }
    }
}