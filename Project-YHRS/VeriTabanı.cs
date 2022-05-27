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
        static SqlConnection con;
        static SqlDataAdapter da;
        static SqlCommand cmd;
        static SqlDataReader dr;
        static DataSet ds;
        public static string SqlCon = @"Data Source=THEHELLBOY\SQLEXPRESS;Initial Catalog=Project Hospital Veritabanı;Integrated Security=True";
        public static int a = 0;

        public static void KomutYollaParametreli(string sql, SqlCommand cmd)
        {
            con = new SqlConnection(SqlCon);
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            con.Close();
        }


        public static DataGridView GridTumunuDoldur(DataGridView gridim,string selectSqlSorgu)
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
