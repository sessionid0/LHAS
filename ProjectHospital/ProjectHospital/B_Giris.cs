namespace ProjectHospital
{
    public partial class B_Giris : Form
    {
        public B_Giris()
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
            this.Hide();
        }
    }
}