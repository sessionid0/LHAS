namespace Project_YHRS
{
    partial class S_HastaneRandevu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(S_HastaneRandevu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.a0 = new System.Windows.Forms.Button();
            this.a3 = new System.Windows.Forms.Button();
            this.a12 = new System.Windows.Forms.Button();
            this.a11 = new System.Windows.Forms.Button();
            this.a13 = new System.Windows.Forms.Button();
            this.a2 = new System.Windows.Forms.Button();
            this.a15 = new System.Windows.Forms.Button();
            this.a14 = new System.Windows.Forms.Button();
            this.a10 = new System.Windows.Forms.Button();
            this.a9 = new System.Windows.Forms.Button();
            this.a1 = new System.Windows.Forms.Button();
            this.a8 = new System.Windows.Forms.Button();
            this.a7 = new System.Windows.Forms.Button();
            this.a5 = new System.Windows.Forms.Button();
            this.a6 = new System.Windows.Forms.Button();
            this.a4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(542, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 519);
            this.panel1.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(48, 81);
            this.dateTimePicker1.MinDate = new System.DateTime(2022, 5, 28, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(386, 27);
            this.dateTimePicker1.TabIndex = 51;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(48, 307);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(386, 28);
            this.comboBox1.TabIndex = 50;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Ağız, Yüz ve Çene Cerrahisi",
            "Anestezi ve Reanimasyon",
            "Beyin ve Sinir Cerrahisi (Nöroşirürji)",
            "Dahiliye (İç Hastalıkları)",
            "Deri ve Zührevi Hastalıkları (Cildiye)",
            "Diyaliz",
            "Endokrinoloji",
            "Enfeksiyon Hastalıkları ve Klinik Mikrobiyoloji",
            "Estetik Cerrahi",
            "Fizik Tedavi ve Rehabilitasyon",
            "Fizyoloji",
            "Gastroenteroloji",
            "Genel Cerrahi",
            "Tıbbi Genetik",
            "Göğüs Cerrahisi",
            "Göğüs Hastalıkları",
            "Göz Hastalıkları",
            "Hematoloji (Kan Hastalıkları)",
            "Kadın Hastalıkları ve Doğum (Jinekoloji)",
            "Kalp ve Damar Cerrahisi",
            "Kardiyoloji",
            "Kulak Burun Boğaz (KBB)",
            "Nefroloji",
            "Nöroloji",
            "Odyoloji",
            "Onkoloji",
            "Ortopedi",
            "Patoloji",
            "Psikiyatri",
            "Radyoloji",
            "Üroloji",
            "Yeni doğan Yoğun Bakım Ünitesi",
            "Yoğun Bakım",
            "Covid-19 PCR Test Merkezi"});
            this.comboBox2.Location = new System.Drawing.Point(48, 189);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(386, 28);
            this.comboBox2.TabIndex = 48;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Project_YHRS.Properties.Resources.Giriş_Yap;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(48, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "İleri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(542, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(493, 516);
            this.panel2.TabIndex = 7;
            this.panel2.Visible = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.ForeColor = System.Drawing.Color.Black;
            this.richTextBox1.Location = new System.Drawing.Point(48, 310);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(407, 70);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Project_YHRS.Properties.Resources.Giriş_Yap;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(48, 402);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 46);
            this.button2.TabIndex = 5;
            this.button2.Text = "Randevuyu Tamamla";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.a0);
            this.groupBox1.Controls.Add(this.a3);
            this.groupBox1.Controls.Add(this.a12);
            this.groupBox1.Controls.Add(this.a11);
            this.groupBox1.Controls.Add(this.a13);
            this.groupBox1.Controls.Add(this.a2);
            this.groupBox1.Controls.Add(this.a15);
            this.groupBox1.Controls.Add(this.a14);
            this.groupBox1.Controls.Add(this.a10);
            this.groupBox1.Controls.Add(this.a9);
            this.groupBox1.Controls.Add(this.a1);
            this.groupBox1.Controls.Add(this.a8);
            this.groupBox1.Controls.Add(this.a7);
            this.groupBox1.Controls.Add(this.a5);
            this.groupBox1.Controls.Add(this.a6);
            this.groupBox1.Controls.Add(this.a4);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(48, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 155);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // a0
            // 
            this.a0.BackColor = System.Drawing.Color.White;
            this.a0.ForeColor = System.Drawing.Color.Black;
            this.a0.Location = new System.Drawing.Point(7, 17);
            this.a0.Name = "a0";
            this.a0.Size = new System.Drawing.Size(94, 29);
            this.a0.TabIndex = 43;
            this.a0.Text = "08:00";
            this.a0.UseVisualStyleBackColor = false;
            this.a0.Click += new System.EventHandler(this.a0_Click);
            // 
            // a3
            // 
            this.a3.BackColor = System.Drawing.Color.White;
            this.a3.ForeColor = System.Drawing.Color.Black;
            this.a3.Location = new System.Drawing.Point(306, 17);
            this.a3.Name = "a3";
            this.a3.Size = new System.Drawing.Size(94, 29);
            this.a3.TabIndex = 30;
            this.a3.Text = "09:30";
            this.a3.UseVisualStyleBackColor = false;
            this.a3.Click += new System.EventHandler(this.a3_Click);
            // 
            // a12
            // 
            this.a12.BackColor = System.Drawing.Color.White;
            this.a12.ForeColor = System.Drawing.Color.Black;
            this.a12.Location = new System.Drawing.Point(6, 121);
            this.a12.Name = "a12";
            this.a12.Size = new System.Drawing.Size(94, 29);
            this.a12.TabIndex = 39;
            this.a12.Text = "15:00";
            this.a12.UseVisualStyleBackColor = false;
            this.a12.Click += new System.EventHandler(this.a12_Click);
            // 
            // a11
            // 
            this.a11.BackColor = System.Drawing.Color.White;
            this.a11.ForeColor = System.Drawing.Color.Black;
            this.a11.Location = new System.Drawing.Point(306, 87);
            this.a11.Name = "a11";
            this.a11.Size = new System.Drawing.Size(94, 29);
            this.a11.TabIndex = 38;
            this.a11.Text = "14:30";
            this.a11.UseVisualStyleBackColor = false;
            this.a11.Click += new System.EventHandler(this.a11_Click);
            // 
            // a13
            // 
            this.a13.BackColor = System.Drawing.Color.White;
            this.a13.ForeColor = System.Drawing.Color.Black;
            this.a13.Location = new System.Drawing.Point(106, 122);
            this.a13.Name = "a13";
            this.a13.Size = new System.Drawing.Size(94, 29);
            this.a13.TabIndex = 40;
            this.a13.Text = "15:30";
            this.a13.UseVisualStyleBackColor = false;
            this.a13.Click += new System.EventHandler(this.a13_Click);
            // 
            // a2
            // 
            this.a2.BackColor = System.Drawing.Color.White;
            this.a2.ForeColor = System.Drawing.Color.Black;
            this.a2.Location = new System.Drawing.Point(206, 17);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(94, 29);
            this.a2.TabIndex = 29;
            this.a2.Text = "09:00";
            this.a2.UseVisualStyleBackColor = false;
            this.a2.Click += new System.EventHandler(this.a2_Click);
            // 
            // a15
            // 
            this.a15.BackColor = System.Drawing.Color.White;
            this.a15.ForeColor = System.Drawing.Color.Black;
            this.a15.Location = new System.Drawing.Point(306, 122);
            this.a15.Name = "a15";
            this.a15.Size = new System.Drawing.Size(94, 29);
            this.a15.TabIndex = 42;
            this.a15.Text = "16:30";
            this.a15.UseVisualStyleBackColor = false;
            this.a15.Click += new System.EventHandler(this.a15_Click);
            // 
            // a14
            // 
            this.a14.BackColor = System.Drawing.Color.White;
            this.a14.ForeColor = System.Drawing.Color.Black;
            this.a14.Location = new System.Drawing.Point(206, 122);
            this.a14.Name = "a14";
            this.a14.Size = new System.Drawing.Size(94, 29);
            this.a14.TabIndex = 41;
            this.a14.Text = "16:00";
            this.a14.UseVisualStyleBackColor = false;
            this.a14.Click += new System.EventHandler(this.a14_Click);
            // 
            // a10
            // 
            this.a10.BackColor = System.Drawing.Color.White;
            this.a10.ForeColor = System.Drawing.Color.Black;
            this.a10.Location = new System.Drawing.Point(206, 87);
            this.a10.Name = "a10";
            this.a10.Size = new System.Drawing.Size(94, 29);
            this.a10.TabIndex = 37;
            this.a10.Text = "14:00";
            this.a10.UseVisualStyleBackColor = false;
            this.a10.Click += new System.EventHandler(this.a10_Click);
            // 
            // a9
            // 
            this.a9.BackColor = System.Drawing.Color.White;
            this.a9.ForeColor = System.Drawing.Color.Black;
            this.a9.Location = new System.Drawing.Point(106, 87);
            this.a9.Name = "a9";
            this.a9.Size = new System.Drawing.Size(94, 29);
            this.a9.TabIndex = 36;
            this.a9.Text = "13:30";
            this.a9.UseVisualStyleBackColor = false;
            this.a9.Click += new System.EventHandler(this.a9_Click);
            // 
            // a1
            // 
            this.a1.BackColor = System.Drawing.Color.White;
            this.a1.ForeColor = System.Drawing.Color.Black;
            this.a1.Location = new System.Drawing.Point(106, 17);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(94, 29);
            this.a1.TabIndex = 28;
            this.a1.Text = "08:30";
            this.a1.UseVisualStyleBackColor = false;
            this.a1.Click += new System.EventHandler(this.a1_Click);
            // 
            // a8
            // 
            this.a8.BackColor = System.Drawing.Color.White;
            this.a8.ForeColor = System.Drawing.Color.Black;
            this.a8.Location = new System.Drawing.Point(6, 87);
            this.a8.Name = "a8";
            this.a8.Size = new System.Drawing.Size(94, 29);
            this.a8.TabIndex = 35;
            this.a8.Text = "13:00";
            this.a8.UseVisualStyleBackColor = false;
            this.a8.Click += new System.EventHandler(this.a8_Click);
            // 
            // a7
            // 
            this.a7.BackColor = System.Drawing.Color.White;
            this.a7.ForeColor = System.Drawing.Color.Black;
            this.a7.Location = new System.Drawing.Point(306, 52);
            this.a7.Name = "a7";
            this.a7.Size = new System.Drawing.Size(94, 29);
            this.a7.TabIndex = 34;
            this.a7.Text = "11:30";
            this.a7.UseVisualStyleBackColor = false;
            this.a7.Click += new System.EventHandler(this.a7_Click);
            // 
            // a5
            // 
            this.a5.BackColor = System.Drawing.Color.White;
            this.a5.ForeColor = System.Drawing.Color.Black;
            this.a5.Location = new System.Drawing.Point(106, 52);
            this.a5.Name = "a5";
            this.a5.Size = new System.Drawing.Size(94, 29);
            this.a5.TabIndex = 32;
            this.a5.Text = "10:30";
            this.a5.UseVisualStyleBackColor = false;
            this.a5.Click += new System.EventHandler(this.a5_Click);
            // 
            // a6
            // 
            this.a6.BackColor = System.Drawing.Color.White;
            this.a6.ForeColor = System.Drawing.Color.Black;
            this.a6.Location = new System.Drawing.Point(206, 52);
            this.a6.Name = "a6";
            this.a6.Size = new System.Drawing.Size(94, 29);
            this.a6.TabIndex = 33;
            this.a6.Text = "11:00";
            this.a6.UseVisualStyleBackColor = false;
            this.a6.Click += new System.EventHandler(this.a6_Click);
            // 
            // a4
            // 
            this.a4.BackColor = System.Drawing.Color.White;
            this.a4.ForeColor = System.Drawing.Color.Black;
            this.a4.Location = new System.Drawing.Point(6, 52);
            this.a4.Name = "a4";
            this.a4.Size = new System.Drawing.Size(94, 29);
            this.a4.TabIndex = 31;
            this.a4.Text = "10:00";
            this.a4.UseVisualStyleBackColor = false;
            this.a4.Click += new System.EventHandler(this.a4_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.BackgroundImage = global::Project_YHRS.Properties.Resources.CikisYap;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(980, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(48, 52);
            this.button6.TabIndex = 16;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::Project_YHRS.Properties.Resources.up_bttn;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(926, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(48, 52);
            this.button3.TabIndex = 17;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // S_HastaneRandevu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackgroundImage = global::Project_YHRS.Properties.Resources.Randevu_Oluşturun;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1040, 640);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "S_HastaneRandevu";
            this.Text = "YHRS";
            this.Load += new System.EventHandler(this.S_HastaneRandevu_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private RichTextBox richTextBox1;
        private Button button2;
        private GroupBox groupBox1;
        private Button a0;
        private Button a3;
        private Button a12;
        private Button a11;
        private Button a13;
        private Button a2;
        private Button a15;
        private Button a14;
        private Button a10;
        private Button a9;
        private Button a1;
        private Button a8;
        private Button a7;
        private Button a5;
        private Button a6;
        private Button a4;
        private Button button1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private Button button6;
        private Button button3;
    }
}