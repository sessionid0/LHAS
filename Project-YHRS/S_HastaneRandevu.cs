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
    public partial class S_HastaneRandevu : Form
    {
        static SqlConnection con;
        static SqlDataAdapter da;
        static SqlCommand cmd;
        static SqlDataReader dr;
        static DataSet ds;
        public static string SqlCon = @"Data Source=DESKTOP-I8QAI56\SQLEXPRESS;Initial Catalog=Project Hospital Veritabanı;Integrated Security=True";

        public S_HastaneRandevu()
        {
            InitializeComponent();
        }

        private void panel2_Load(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Show();
            panel1.Hide();
        }


        private void a0_CheckStateChanged(object sender, EventArgs e)
        {


        }

        private void a0_Click(object sender, EventArgs e)
        {
            if (a0.BackColor == Color.White)
            {
                a0.BackColor = System.Drawing.ColorTranslator.FromHtml("#03989E");
                a0.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
                a1.Enabled = false;
                a2.Enabled = false;
                a3.Enabled = false;
                a4.Enabled = false;
                a5.Enabled = false;
                a6.Enabled = false;
                a7.Enabled = false;
                a8.Enabled = false;
                a9.Enabled = false;
                a10.Enabled = false;
                a11.Enabled = false;
                a12.Enabled = false;
                a13.Enabled = false;
                a14.Enabled = false;
                a15.Enabled = false;

            }

            else
            {
                a0.BackColor = Color.White;
                a0.ForeColor = Color.Black;
                a1.Enabled = true;
                a2.Enabled = true;
                a3.Enabled = true;
                a4.Enabled = true;
                a5.Enabled = true;
                a6.Enabled = true;
                a7.Enabled = true;
                a8.Enabled = true;
                a9.Enabled = true;
                a10.Enabled = true;
                a11.Enabled = true;
                a12.Enabled = true;
                a13.Enabled = true;
                a14.Enabled = true;
                a15.Enabled = true;
                //checkdisabledbuttons on DB   

            }
        }

        private void a1_Click(object sender, EventArgs e)
        {
            if (a1.BackColor == Color.White)
            {
                a1.BackColor = System.Drawing.ColorTranslator.FromHtml("#03989E");
                a1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
                a0.Enabled = false;
                a2.Enabled = false;
                a3.Enabled = false;
                a4.Enabled = false;
                a5.Enabled = false;
                a6.Enabled = false;
                a7.Enabled = false;
                a8.Enabled = false;
                a9.Enabled = false;
                a10.Enabled = false;
                a11.Enabled = false;
                a12.Enabled = false;
                a13.Enabled = false;
                a14.Enabled = false;
                a15.Enabled = false;

            }

            else
            {
                a1.BackColor = Color.White;
                a1.ForeColor = Color.Black;
                a0.Enabled = true;
                a2.Enabled = true;
                a3.Enabled = true;
                a4.Enabled = true;
                a5.Enabled = true;
                a6.Enabled = true;
                a7.Enabled = true;
                a8.Enabled = true;
                a9.Enabled = true;
                a10.Enabled = true;
                a11.Enabled = true;
                a12.Enabled = true;
                a13.Enabled = true;
                a14.Enabled = true;
                a15.Enabled = true;
                //checkdisabledbuttons on DB   

            }
        }

        private void a2_Click(object sender, EventArgs e)
        {

            {
                if (a2.BackColor == Color.White)
                {
                    a2.BackColor = System.Drawing.ColorTranslator.FromHtml("#03989E");
                    a2.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
                    a1.Enabled = false;
                    a0.Enabled = false;
                    a3.Enabled = false;
                    a4.Enabled = false;
                    a5.Enabled = false;
                    a6.Enabled = false;
                    a7.Enabled = false;
                    a8.Enabled = false;
                    a9.Enabled = false;
                    a10.Enabled = false;
                    a11.Enabled = false;
                    a12.Enabled = false;
                    a13.Enabled = false;
                    a14.Enabled = false;
                    a15.Enabled = false;

                }

                else
                {
                    a2.BackColor = Color.White;
                    a2.ForeColor = Color.Black;
                    a1.Enabled = true;
                    a0.Enabled = true;
                    a3.Enabled = true;
                    a4.Enabled = true;
                    a5.Enabled = true;
                    a6.Enabled = true;
                    a7.Enabled = true;
                    a8.Enabled = true;
                    a9.Enabled = true;
                    a10.Enabled = true;
                    a11.Enabled = true;
                    a12.Enabled = true;
                    a13.Enabled = true;
                    a14.Enabled = true;
                    a15.Enabled = true;
                    //checkdisabledbuttons on DB   

                }
            }
        }

        private void a3_Click(object sender, EventArgs e)
        {

            if (a3.BackColor == Color.White)
            {
                a3.BackColor = System.Drawing.ColorTranslator.FromHtml("#03989E");
                a3.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
                a1.Enabled = false;
                a2.Enabled = false;
                a0.Enabled = false;
                a4.Enabled = false;
                a5.Enabled = false;
                a6.Enabled = false;
                a7.Enabled = false;
                a8.Enabled = false;
                a9.Enabled = false;
                a10.Enabled = false;
                a11.Enabled = false;
                a12.Enabled = false;
                a13.Enabled = false;
                a14.Enabled = false;
                a15.Enabled = false;

            }

            else
            {
                a3.BackColor = Color.White;
                a3.ForeColor = Color.Black;
                a1.Enabled = true;
                a2.Enabled = true;
                a0.Enabled = true;
                a4.Enabled = true;
                a5.Enabled = true;
                a6.Enabled = true;
                a7.Enabled = true;
                a8.Enabled = true;
                a9.Enabled = true;
                a10.Enabled = true;
                a11.Enabled = true;
                a12.Enabled = true;
                a13.Enabled = true;
                a14.Enabled = true;
                a15.Enabled = true;
                //checkdisabledbuttons on DB   

            }
        }

        private void a4_Click(object sender, EventArgs e)
        {
            if (a4.BackColor == Color.White)
            {
                a4.BackColor = System.Drawing.ColorTranslator.FromHtml("#03989E");
                a4.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
                a1.Enabled = false;
                a2.Enabled = false;
                a3.Enabled = false;
                a0.Enabled = false;
                a5.Enabled = false;
                a6.Enabled = false;
                a7.Enabled = false;
                a8.Enabled = false;
                a9.Enabled = false;
                a10.Enabled = false;
                a11.Enabled = false;
                a12.Enabled = false;
                a13.Enabled = false;
                a14.Enabled = false;
                a15.Enabled = false;

            }

            else
            {
                a4.BackColor = Color.White;
                a4.ForeColor = Color.Black;
                a1.Enabled = true;
                a2.Enabled = true;
                a3.Enabled = true;
                a0.Enabled = true;
                a5.Enabled = true;
                a6.Enabled = true;
                a7.Enabled = true;
                a8.Enabled = true;
                a9.Enabled = true;
                a10.Enabled = true;
                a11.Enabled = true;
                a12.Enabled = true;
                a13.Enabled = true;
                a14.Enabled = true;
                a15.Enabled = true;
                //checkdisabledbuttons on DB   

            }

        }

        private void a5_Click(object sender, EventArgs e)
        {
            if (a5.BackColor == Color.White)
            {
                a5.BackColor = System.Drawing.ColorTranslator.FromHtml("#03989E");
                a5.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
                a1.Enabled = false;
                a2.Enabled = false;
                a3.Enabled = false;
                a4.Enabled = false;
                a0.Enabled = false;
                a6.Enabled = false;
                a7.Enabled = false;
                a8.Enabled = false;
                a9.Enabled = false;
                a10.Enabled = false;
                a11.Enabled = false;
                a12.Enabled = false;
                a13.Enabled = false;
                a14.Enabled = false;
                a15.Enabled = false;

            }

            else
            {
                a5.BackColor = Color.White;
                a5.ForeColor = Color.Black;
                a1.Enabled = true;
                a2.Enabled = true;
                a3.Enabled = true;
                a4.Enabled = true;
                a0.Enabled = true;
                a6.Enabled = true;
                a7.Enabled = true;
                a8.Enabled = true;
                a9.Enabled = true;
                a10.Enabled = true;
                a11.Enabled = true;
                a12.Enabled = true;
                a13.Enabled = true;
                a14.Enabled = true;
                a15.Enabled = true;
                //checkdisabledbuttons on DB   

            }
        }

        private void a6_Click(object sender, EventArgs e)
        {
            if (a6.BackColor == Color.White)
            {
                a6.BackColor = System.Drawing.ColorTranslator.FromHtml("#03989E");
                a6.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
                a1.Enabled = false;
                a2.Enabled = false;
                a3.Enabled = false;
                a4.Enabled = false;
                a5.Enabled = false;
                a0.Enabled = false;
                a7.Enabled = false;
                a8.Enabled = false;
                a9.Enabled = false;
                a10.Enabled = false;
                a11.Enabled = false;
                a12.Enabled = false;
                a13.Enabled = false;
                a14.Enabled = false;
                a15.Enabled = false;

            }

            else
            {
                a6.BackColor = Color.White;
                a6.ForeColor = Color.Black;
                a1.Enabled = true;
                a2.Enabled = true;
                a3.Enabled = true;
                a4.Enabled = true;
                a5.Enabled = true;
                a0.Enabled = true;
                a7.Enabled = true;
                a8.Enabled = true;
                a9.Enabled = true;
                a10.Enabled = true;
                a11.Enabled = true;
                a12.Enabled = true;
                a13.Enabled = true;
                a14.Enabled = true;
                a15.Enabled = true;
                //checkdisabledbuttons on DB   

            }
        }

        private void a7_Click(object sender, EventArgs e)
        {
            if (a7.BackColor == Color.White)
            {
                a7.BackColor = System.Drawing.ColorTranslator.FromHtml("#03989E");
                a7.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
                a1.Enabled = false;
                a2.Enabled = false;
                a3.Enabled = false;
                a4.Enabled = false;
                a5.Enabled = false;
                a6.Enabled = false;
                a0.Enabled = false;
                a8.Enabled = false;
                a9.Enabled = false;
                a10.Enabled = false;
                a11.Enabled = false;
                a12.Enabled = false;
                a13.Enabled = false;
                a14.Enabled = false;
                a15.Enabled = false;

            }

            else
            {
                a7.BackColor = Color.White;
                a7.ForeColor = Color.Black;
                a1.Enabled = true;
                a2.Enabled = true;
                a3.Enabled = true;
                a4.Enabled = true;
                a5.Enabled = true;
                a6.Enabled = true;
                a0.Enabled = true;
                a8.Enabled = true;
                a9.Enabled = true;
                a10.Enabled = true;
                a11.Enabled = true;
                a12.Enabled = true;
                a13.Enabled = true;
                a14.Enabled = true;
                a15.Enabled = true;
                //checkdisabledbuttons on DB   

            }
        }

        private void a8_Click(object sender, EventArgs e)
        {
            if (a8.BackColor == Color.White)
            {
                a8.BackColor = System.Drawing.ColorTranslator.FromHtml("#03989E");
                a8.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
                a1.Enabled = false;
                a2.Enabled = false;
                a3.Enabled = false;
                a4.Enabled = false;
                a5.Enabled = false;
                a6.Enabled = false;
                a7.Enabled = false;
                a0.Enabled = false;
                a9.Enabled = false;
                a10.Enabled = false;
                a11.Enabled = false;
                a12.Enabled = false;
                a13.Enabled = false;
                a14.Enabled = false;
                a15.Enabled = false;

            }

            else
            {
                a8.BackColor = Color.White;
                a8.ForeColor = Color.Black;
                a1.Enabled = true;
                a2.Enabled = true;
                a3.Enabled = true;
                a4.Enabled = true;
                a5.Enabled = true;
                a6.Enabled = true;
                a7.Enabled = true;
                a0.Enabled = true;
                a9.Enabled = true;
                a10.Enabled = true;
                a11.Enabled = true;
                a12.Enabled = true;
                a13.Enabled = true;
                a14.Enabled = true;
                a15.Enabled = true;
                //checkdisabledbuttons on DB   

            }
        }

        private void a9_Click(object sender, EventArgs e)
        {
            if (a9.BackColor == Color.White)
            {
                a9.BackColor = System.Drawing.ColorTranslator.FromHtml("#03989E");
                a9.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
                a1.Enabled = false;
                a2.Enabled = false;
                a3.Enabled = false;
                a4.Enabled = false;
                a5.Enabled = false;
                a6.Enabled = false;
                a7.Enabled = false;
                a8.Enabled = false;
                a0.Enabled = false;
                a10.Enabled = false;
                a11.Enabled = false;
                a12.Enabled = false;
                a13.Enabled = false;
                a14.Enabled = false;
                a15.Enabled = false;

            }

            else
            {
                a9.BackColor = Color.White;
                a9.ForeColor = Color.Black;
                a1.Enabled = true;
                a2.Enabled = true;
                a3.Enabled = true;
                a4.Enabled = true;
                a5.Enabled = true;
                a6.Enabled = true;
                a7.Enabled = true;
                a8.Enabled = true;
                a0.Enabled = true;
                a10.Enabled = true;
                a11.Enabled = true;
                a12.Enabled = true;
                a13.Enabled = true;
                a14.Enabled = true;
                a15.Enabled = true;
                //checkdisabledbuttons on DB   

            }
        }

        private void a10_Click(object sender, EventArgs e)
        {
            if (a10.BackColor == Color.White)
            {
                a10.BackColor = System.Drawing.ColorTranslator.FromHtml("#03989E");
                a10.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
                a1.Enabled = false;
                a2.Enabled = false;
                a3.Enabled = false;
                a4.Enabled = false;
                a5.Enabled = false;
                a6.Enabled = false;
                a7.Enabled = false;
                a8.Enabled = false;
                a9.Enabled = false;
                a0.Enabled = false;
                a11.Enabled = false;
                a12.Enabled = false;
                a13.Enabled = false;
                a14.Enabled = false;
                a15.Enabled = false;

            }

            else
            {
                a10.BackColor = Color.White;
                a10.ForeColor = Color.Black;
                a1.Enabled = true;
                a2.Enabled = true;
                a3.Enabled = true;
                a4.Enabled = true;
                a5.Enabled = true;
                a6.Enabled = true;
                a7.Enabled = true;
                a8.Enabled = true;
                a9.Enabled = true;
                a0.Enabled = true;
                a11.Enabled = true;
                a12.Enabled = true;
                a13.Enabled = true;
                a14.Enabled = true;
                a15.Enabled = true;
                //checkdisabledbuttons on DB   

            }
        }

        private void a11_Click(object sender, EventArgs e)
        {
            if (a11.BackColor == Color.White)
            {
                a11.BackColor = System.Drawing.ColorTranslator.FromHtml("#03989E");
                a11.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
                a1.Enabled = false;
                a2.Enabled = false;
                a3.Enabled = false;
                a4.Enabled = false;
                a5.Enabled = false;
                a6.Enabled = false;
                a7.Enabled = false;
                a8.Enabled = false;
                a9.Enabled = false;
                a10.Enabled = false;
                a0.Enabled = false;
                a12.Enabled = false;
                a13.Enabled = false;
                a14.Enabled = false;
                a15.Enabled = false;

            }

            else
            {
                a11.BackColor = Color.White;
                a11.ForeColor = Color.Black;
                a1.Enabled = true;
                a2.Enabled = true;
                a3.Enabled = true;
                a4.Enabled = true;
                a5.Enabled = true;
                a6.Enabled = true;
                a7.Enabled = true;
                a8.Enabled = true;
                a9.Enabled = true;
                a10.Enabled = true;
                a0.Enabled = true;
                a12.Enabled = true;
                a13.Enabled = true;
                a14.Enabled = true;
                a15.Enabled = true;
                //checkdisabledbuttons on DB   

            }
        }

        private void a12_Click(object sender, EventArgs e)
        {
            if (a12.BackColor == Color.White)
            {
                a12.BackColor = System.Drawing.ColorTranslator.FromHtml("#03989E");
                a12.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
                a1.Enabled = false;
                a2.Enabled = false;
                a3.Enabled = false;
                a4.Enabled = false;
                a5.Enabled = false;
                a6.Enabled = false;
                a7.Enabled = false;
                a8.Enabled = false;
                a9.Enabled = false;
                a10.Enabled = false;
                a11.Enabled = false;
                a0.Enabled = false;
                a13.Enabled = false;
                a14.Enabled = false;
                a15.Enabled = false;

            }

            else
            {
                a12.BackColor = Color.White;
                a12.ForeColor = Color.Black;
                a1.Enabled = true;
                a2.Enabled = true;
                a3.Enabled = true;
                a4.Enabled = true;
                a5.Enabled = true;
                a6.Enabled = true;
                a7.Enabled = true;
                a8.Enabled = true;
                a9.Enabled = true;
                a10.Enabled = true;
                a11.Enabled = true;
                a0.Enabled = true;
                a13.Enabled = true;
                a14.Enabled = true;
                a15.Enabled = true;
                //checkdisabledbuttons on DB   

            }
        }

        private void a13_Click(object sender, EventArgs e)
        {
            if (a13.BackColor == Color.White)
            {
                a13.BackColor = System.Drawing.ColorTranslator.FromHtml("#03989E");
                a13.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
                a1.Enabled = false;
                a2.Enabled = false;
                a3.Enabled = false;
                a4.Enabled = false;
                a5.Enabled = false;
                a6.Enabled = false;
                a7.Enabled = false;
                a8.Enabled = false;
                a9.Enabled = false;
                a10.Enabled = false;
                a11.Enabled = false;
                a12.Enabled = false;
                a0.Enabled = false;
                a14.Enabled = false;
                a15.Enabled = false;

            }

            else
            {
                a13.BackColor = Color.White;
                a13.ForeColor = Color.Black;
                a1.Enabled = true;
                a2.Enabled = true;
                a3.Enabled = true;
                a4.Enabled = true;
                a5.Enabled = true;
                a6.Enabled = true;
                a7.Enabled = true;
                a8.Enabled = true;
                a9.Enabled = true;
                a10.Enabled = true;
                a11.Enabled = true;
                a12.Enabled = true;
                a0.Enabled = true;
                a14.Enabled = true;
                a15.Enabled = true;
                //checkdisabledbuttons on DB   

            }
        }

        private void a14_Click(object sender, EventArgs e)
        {
            if (a14.BackColor == Color.White)
            {
                a14.BackColor = System.Drawing.ColorTranslator.FromHtml("#03989E");
                a14.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
                a1.Enabled = false;
                a2.Enabled = false;
                a3.Enabled = false;
                a4.Enabled = false;
                a5.Enabled = false;
                a6.Enabled = false;
                a7.Enabled = false;
                a8.Enabled = false;
                a9.Enabled = false;
                a10.Enabled = false;
                a11.Enabled = false;
                a12.Enabled = false;
                a13.Enabled = false;
                a0.Enabled = false;
                a15.Enabled = false;

            }

            else
            {
                a14.BackColor = Color.White;
                a14.ForeColor = Color.Black;
                a1.Enabled = true;
                a2.Enabled = true;
                a3.Enabled = true;
                a4.Enabled = true;
                a5.Enabled = true;
                a6.Enabled = true;
                a7.Enabled = true;
                a8.Enabled = true;
                a9.Enabled = true;
                a10.Enabled = true;
                a11.Enabled = true;
                a12.Enabled = true;
                a13.Enabled = true;
                a0.Enabled = true;
                a15.Enabled = true;
                //checkdisabledbuttons on DB   

            }
        }

        private void a15_Click(object sender, EventArgs e)
        {
            if (a15.BackColor == Color.White)
            {
                a15.BackColor = System.Drawing.ColorTranslator.FromHtml("#03989E");
                a15.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
                a1.Enabled = false;
                a2.Enabled = false;
                a3.Enabled = false;
                a4.Enabled = false;
                a5.Enabled = false;
                a6.Enabled = false;
                a7.Enabled = false;
                a8.Enabled = false;
                a9.Enabled = false;
                a10.Enabled = false;
                a11.Enabled = false;
                a12.Enabled = false;
                a13.Enabled = false;
                a14.Enabled = false;
                a0.Enabled = false;

            }

            else
            {
                a15.BackColor = Color.White;
                a15.ForeColor = Color.Black;
                a1.Enabled = true;
                a2.Enabled = true;
                a3.Enabled = true;
                a4.Enabled = true;
                a5.Enabled = true;
                a6.Enabled = true;
                a7.Enabled = true;
                a8.Enabled = true;
                a9.Enabled = true;
                a10.Enabled = true;
                a11.Enabled = true;
                a12.Enabled = true;
                a13.Enabled = true;
                a14.Enabled = true;
                a0.Enabled = true;
                //checkdisabledbuttons on DB   

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Buttons başlangıç
            if (a0.Enabled == true && a1.Enabled == false)
            {
                VeriTabanı.butonlar = a0.Text;
                VeriTabanı.caution = 0;
            }
            else if (a1.Enabled == true && a0.Enabled == false)
            {
                VeriTabanı.caution = 0;
                VeriTabanı.butonlar = a1.Text;
            }
            else if (a2.Enabled == true && a0.Enabled == false)
            {
                VeriTabanı.caution = 0;
                VeriTabanı.butonlar = a2.Text;
            }
            else if (a3.Enabled == true && a0.Enabled == false)
            {
                VeriTabanı.caution = 0;
                VeriTabanı.butonlar = a3.Text;
            }
            else if (a4.Enabled == true && a0.Enabled == false)
            {
                VeriTabanı.caution = 0;
                VeriTabanı.butonlar = a4.Text;
            }
            else if (a5.Enabled == true && a0.Enabled == false)
            {
                VeriTabanı.caution = 0;
                VeriTabanı.butonlar = a5.Text;
            }
            else if (a6.Enabled == true && a0.Enabled == false)
            {
                VeriTabanı.caution = 0;
                VeriTabanı.butonlar = a6.Text;
            }
            else if (a7.Enabled == true && a0.Enabled == false)
            {
                VeriTabanı.caution = 0;
                VeriTabanı.butonlar = a7.Text;
            }
            else if (a8.Enabled == true && a0.Enabled == false)
            {
                VeriTabanı.caution = 0;
                VeriTabanı.butonlar = a8.Text;
            }
            else if (a9.Enabled == true && a0.Enabled == false)
            {
                VeriTabanı.caution = 0;
                VeriTabanı.butonlar = a9.Text;
            }
            else if (a10.Enabled == true && a0.Enabled == false)
            {
                VeriTabanı.caution = 0;
                VeriTabanı.butonlar = a10.Text;
            }
            else if (a11.Enabled == true && a0.Enabled == false)
            {
                VeriTabanı.caution = 0;
                VeriTabanı.butonlar = a11.Text;
            }
            else if (a12.Enabled == true && a0.Enabled == false)
            {
                VeriTabanı.caution = 0;
                VeriTabanı.butonlar = a12.Text;
            }
            else if (a13.Enabled == true && a0.Enabled == false)
            {
                VeriTabanı.caution = 0;
                VeriTabanı.butonlar = a13.Text;
            }
            else if (a14.Enabled == true && a0.Enabled == false)
            {
                VeriTabanı.caution = 0;
                VeriTabanı.butonlar = a14.Text;
            }
            else if (a15.Enabled == true && a0.Enabled == false)
            {
                VeriTabanı.caution = 0;
                VeriTabanı.butonlar = a15.Text;
            }
            else
            {
                VeriTabanı.caution = 1;

            }

            //Buttons bitiş

            if (VeriTabanı.caution == 1)
            {
                MessageBox.Show("Lütfen bir saat seçimi yapınız.");
            }
            else
            {
                string hastanerandevu = "insert into RandevularTablosu (RD_Ad,POL_Ad, R_Tarih,R_Saat,R_Ad,R_Soyad,R_Aciklama, R_Gerceklesme) values (@dokad, @polad, @tarih, @saat, @ad, @soyad, @aciklama, @gerceklesme )";
                cmd = new SqlCommand(hastanerandevu, con);

                cmd.Parameters.AddWithValue("@dokad", comboBox1.Text);
                cmd.Parameters.AddWithValue("@polad", comboBox2.Text);
                cmd.Parameters.AddWithValue("@gerceklesme", false);
                cmd.Parameters.AddWithValue("@tarih", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@saat", VeriTabanı.butonlar);
                cmd.Parameters.AddWithValue("@ad", VeriTabanı.h_name);
                cmd.Parameters.AddWithValue("@soyad", VeriTabanı.h_surname);
                //cmd.Parameters.AddWithValue("@id", "404");
                cmd.Parameters.AddWithValue("@aciklama", "Poliklinik Randevusu");

                VeriTabanı.KomutYollaParametreli(hastanerandevu, cmd);

                MessageBox.Show("Hastane randevunuz başarıyla alınmıştır.", "YHRS",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();

            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void S_HastaneRandevu_Load(object sender, EventArgs e)
        {
            string Sql = "select D_Ad, D_Soyad from DoktorlarTablosu";
            SqlConnection conn = new SqlConnection(SqlCon);
            conn.Open();
            SqlCommand cmd = new SqlCommand(Sql, conn);
            SqlDataReader DR = cmd.ExecuteReader();

            while (DR.Read())
            {
                string dizi = DR[0] + " " + DR[1];
                comboBox1.Items.Add(dizi);

            }
            conn.Close();

            string Sqlh = "select POL_Ad from PolikliniklerTablosu";
            SqlConnection cohn = new SqlConnection(SqlCon);
            cohn.Open();
            SqlCommand cma = new SqlCommand(Sqlh, cohn);
            SqlDataReader DRf = cma.ExecuteReader();

            while (DRf.Read())
            {
                string dizim = "" + DRf[0] + "";
                comboBox1.Items.Add(dizim);

            }
            cohn.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            S_HastaPanel s_HastaPanel = new S_HastaPanel();
            s_HastaPanel.Show();
            this.Hide();
        }
    }

}
