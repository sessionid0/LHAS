namespace Project_YHRS
{
    public partial class YHRS : Form
    {
        public YHRS()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            B_Kayit b_Kayit = new B_Kayit();
            b_Kayit.Show();
            this.Hide();
        }
    }
}