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

        private void button4_Click(object sender, EventArgs e)
        {
            // if hasta T.C.'si ve �ifresi do�ruysa alttaki kod �al��s�n
            S_HastaPanel s_HastaPanel = new S_HastaPanel();
            s_HastaPanel.Show();
            this.Hide();

            // if doktor butonuna t�kland�ysa (t�klan�nca bir de�i�ken true/false olacak ona g�re ilerleyecek program)
            // ve sonra giri� yap dendiyse 
            // doktor T.C.'si ve �ifresi do�ruysa alttaki kod �al��s�n:
            // lbl_DoktorGirisi.Visible = true;
            // S_DoktorPanel s_DoktorPanel = new S_DoktorPanel();
            // s_DoktorPanel.Show();
            // this.Hide();

            // if y�netici butonuna t�kland�ysa ve sonra giri� yap dendiyse 
            // y�netici T.C.'si ve �ifresi do�ruysa alttaki kod �al��s�n:
            // lbl_YoneticiGirisi.Visible = true;
            // B_YoneticiPanel b_YoneticiPanel = new B_YoneticiPanel();
            // b_YoneticiPanel.Show();
            // this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbl_DoktorGirisi.Visible = true;
            S_DoktorPanel s_DoktorPanel = new S_DoktorPanel();
            s_DoktorPanel.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbl_YoneticiGirisi.Visible = true;
            B_YoneticiPanel b_YoneticiPanel = new B_YoneticiPanel();
            b_YoneticiPanel.Show();
            this.Hide();
        }

        private void YHRS_Load(object sender, EventArgs e)
        {

        }
    }
}