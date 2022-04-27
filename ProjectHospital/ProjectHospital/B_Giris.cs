namespace ProjectHospital
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            B_Kayit b_Kayit = new B_Kayit();
            b_Kayit.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // if (EÐER YÖNETÝCÝ GÝRÝÞÝ ÝSE)
           // {
           //
          //  }
          S_Hasta_Panel s_Hasta_Panel = new S_Hasta_Panel();
            s_Hasta_Panel.Show();
            this.Hide();
        }
    }
}