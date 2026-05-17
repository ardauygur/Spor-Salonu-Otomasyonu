namespace sporSalonu
{
    partial class YeniKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YeniKayit));
            this.adTxt = new System.Windows.Forms.TextBox();
            this.telefonMtb = new System.Windows.Forms.MaskedTextBox();
            this.cinsiyetCmb = new System.Windows.Forms.ComboBox();
            this.kaydetBtn = new System.Windows.Forms.Button();
            this.temizleBtn = new System.Windows.Forms.Button();
            this.geriDonBtn = new System.Windows.Forms.Button();
            this.label0 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.kayitGroupBox = new System.Windows.Forms.GroupBox();
            this.baslikLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.adresTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.kanGrubuCmb = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.kayitTarihiDtp = new System.Windows.Forms.DateTimePicker();
            this.uyelikTuruCmb = new System.Windows.Forms.ComboBox();
            this.logoPb = new System.Windows.Forms.PictureBox();
            this.soyadTxt = new System.Windows.Forms.TextBox();
            this.ucretTxt = new System.Windows.Forms.TextBox();
            this.yasTxt = new System.Windows.Forms.TextBox();
            this.arkaPlanPb = new System.Windows.Forms.PictureBox();
            this.tcMtb = new System.Windows.Forms.MaskedTextBox();
            this.kayitGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arkaPlanPb)).BeginInit();
            this.SuspendLayout();
            // 
            // adTxt
            // 
            this.adTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.adTxt.Location = new System.Drawing.Point(164, 67);
            this.adTxt.Name = "adTxt";
            this.adTxt.Size = new System.Drawing.Size(150, 26);
            this.adTxt.TabIndex = 1;
            // 
            // telefonMtb
            // 
            this.telefonMtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.telefonMtb.Location = new System.Drawing.Point(164, 175);
            this.telefonMtb.Mask = "(000) 000 00 00";
            this.telefonMtb.Name = "telefonMtb";
            this.telefonMtb.Size = new System.Drawing.Size(150, 26);
            this.telefonMtb.TabIndex = 4;
            // 
            // cinsiyetCmb
            // 
            this.cinsiyetCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cinsiyetCmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cinsiyetCmb.FormattingEnabled = true;
            this.cinsiyetCmb.Items.AddRange(new object[] {
            "Kadın",
            "Erkek",
            "Belirtmek İstemiyor"});
            this.cinsiyetCmb.Location = new System.Drawing.Point(164, 247);
            this.cinsiyetCmb.Name = "cinsiyetCmb";
            this.cinsiyetCmb.Size = new System.Drawing.Size(150, 28);
            this.cinsiyetCmb.TabIndex = 6;
            // 
            // kaydetBtn
            // 
            this.kaydetBtn.BackColor = System.Drawing.Color.White;
            this.kaydetBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kaydetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.kaydetBtn.Font = new System.Drawing.Font("Reem Kufi", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaydetBtn.ForeColor = System.Drawing.Color.Black;
            this.kaydetBtn.Location = new System.Drawing.Point(93, 478);
            this.kaydetBtn.Name = "kaydetBtn";
            this.kaydetBtn.Size = new System.Drawing.Size(212, 93);
            this.kaydetBtn.TabIndex = 30;
            this.kaydetBtn.Text = "Kaydet";
            this.kaydetBtn.UseVisualStyleBackColor = false;
            this.kaydetBtn.Click += new System.EventHandler(this.kaydetBtn_Click);
            // 
            // temizleBtn
            // 
            this.temizleBtn.BackColor = System.Drawing.Color.White;
            this.temizleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.temizleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.temizleBtn.Font = new System.Drawing.Font("Reem Kufi", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.temizleBtn.ForeColor = System.Drawing.Color.Black;
            this.temizleBtn.Location = new System.Drawing.Point(374, 478);
            this.temizleBtn.Name = "temizleBtn";
            this.temizleBtn.Size = new System.Drawing.Size(212, 93);
            this.temizleBtn.TabIndex = 31;
            this.temizleBtn.Text = "Temizle";
            this.temizleBtn.UseVisualStyleBackColor = false;
            this.temizleBtn.Click += new System.EventHandler(this.temizleBtn_Click);
            // 
            // geriDonBtn
            // 
            this.geriDonBtn.BackColor = System.Drawing.Color.White;
            this.geriDonBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.geriDonBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.geriDonBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.geriDonBtn.Font = new System.Drawing.Font("Reem Kufi", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.geriDonBtn.ForeColor = System.Drawing.Color.Black;
            this.geriDonBtn.Location = new System.Drawing.Point(640, 478);
            this.geriDonBtn.Name = "geriDonBtn";
            this.geriDonBtn.Size = new System.Drawing.Size(212, 94);
            this.geriDonBtn.TabIndex = 32;
            this.geriDonBtn.Text = "Geri Dön";
            this.geriDonBtn.UseVisualStyleBackColor = false;
            this.geriDonBtn.Click += new System.EventHandler(this.geriDonBtn_Click);
            // 
            // label0
            // 
            this.label0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label0.AutoSize = true;
            this.label0.BackColor = System.Drawing.Color.Transparent;
            this.label0.Font = new System.Drawing.Font("Reem Kufi", 15F, System.Drawing.FontStyle.Bold);
            this.label0.ForeColor = System.Drawing.Color.Black;
            this.label0.Location = new System.Drawing.Point(110, 59);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(48, 36);
            this.label0.TabIndex = 14;
            this.label0.Tag = "";
            this.label0.Text = "Ad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Reem Kufi", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(78, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 36);
            this.label1.TabIndex = 15;
            this.label1.Tag = "";
            this.label1.Text = "Soyad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Reem Kufi", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 36);
            this.label2.TabIndex = 16;
            this.label2.Tag = "";
            this.label2.Text = "TC Kimlik No :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Reem Kufi", 15F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(67, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 36);
            this.label3.TabIndex = 17;
            this.label3.Tag = "";
            this.label3.Text = "Telefon :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Reem Kufi", 15F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(103, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 36);
            this.label4.TabIndex = 18;
            this.label4.Tag = "";
            this.label4.Text = "Yaş :";
            // 
            // kayitGroupBox
            // 
            this.kayitGroupBox.AutoSize = true;
            this.kayitGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.kayitGroupBox.Controls.Add(this.tcMtb);
            this.kayitGroupBox.Controls.Add(this.yasTxt);
            this.kayitGroupBox.Controls.Add(this.ucretTxt);
            this.kayitGroupBox.Controls.Add(this.soyadTxt);
            this.kayitGroupBox.Controls.Add(this.uyelikTuruCmb);
            this.kayitGroupBox.Controls.Add(this.kayitTarihiDtp);
            this.kayitGroupBox.Controls.Add(this.label10);
            this.kayitGroupBox.Controls.Add(this.label9);
            this.kayitGroupBox.Controls.Add(this.label8);
            this.kayitGroupBox.Controls.Add(this.kanGrubuCmb);
            this.kayitGroupBox.Controls.Add(this.label7);
            this.kayitGroupBox.Controls.Add(this.adresTxt);
            this.kayitGroupBox.Controls.Add(this.label6);
            this.kayitGroupBox.Controls.Add(this.label5);
            this.kayitGroupBox.Controls.Add(this.label4);
            this.kayitGroupBox.Controls.Add(this.label3);
            this.kayitGroupBox.Controls.Add(this.label2);
            this.kayitGroupBox.Controls.Add(this.label1);
            this.kayitGroupBox.Controls.Add(this.label0);
            this.kayitGroupBox.Controls.Add(this.cinsiyetCmb);
            this.kayitGroupBox.Controls.Add(this.telefonMtb);
            this.kayitGroupBox.Controls.Add(this.adTxt);
            this.kayitGroupBox.Location = new System.Drawing.Point(145, 148);
            this.kayitGroupBox.Name = "kayitGroupBox";
            this.kayitGroupBox.Size = new System.Drawing.Size(652, 324);
            this.kayitGroupBox.TabIndex = 19;
            this.kayitGroupBox.TabStop = false;
            this.kayitGroupBox.Text = "Kayıt";
            // 
            // baslikLbl
            // 
            this.baslikLbl.AutoSize = true;
            this.baslikLbl.BackColor = System.Drawing.Color.Transparent;
            this.baslikLbl.Font = new System.Drawing.Font("Reem Kufi", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslikLbl.Location = new System.Drawing.Point(257, 25);
            this.baslikLbl.Name = "baslikLbl";
            this.baslikLbl.Size = new System.Drawing.Size(450, 86);
            this.baslikLbl.TabIndex = 20;
            this.baslikLbl.Text = "YENİ   ÜYE   KAYDI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Reem Kufi", 15F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(340, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 36);
            this.label5.TabIndex = 19;
            this.label5.Tag = "";
            this.label5.Text = "Adres : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Reem Kufi", 15F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(340, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 36);
            this.label6.TabIndex = 20;
            this.label6.Tag = "";
            this.label6.Text = "Kan Grubu :";
            // 
            // adresTxt
            // 
            this.adresTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.adresTxt.Location = new System.Drawing.Point(425, 211);
            this.adresTxt.Multiline = true;
            this.adresTxt.Name = "adresTxt";
            this.adresTxt.Size = new System.Drawing.Size(193, 72);
            this.adresTxt.TabIndex = 11;
            this.adresTxt.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Reem Kufi", 15F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(59, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 36);
            this.label7.TabIndex = 23;
            this.label7.Tag = "";
            this.label7.Text = "Cinsiyet :";
            // 
            // kanGrubuCmb
            // 
            this.kanGrubuCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kanGrubuCmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.kanGrubuCmb.FormattingEnabled = true;
            this.kanGrubuCmb.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "0+",
            "0-"});
            this.kanGrubuCmb.Location = new System.Drawing.Point(468, 67);
            this.kanGrubuCmb.Name = "kanGrubuCmb";
            this.kanGrubuCmb.Size = new System.Drawing.Size(150, 28);
            this.kanGrubuCmb.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Reem Kufi", 15F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(385, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 36);
            this.label8.TabIndex = 25;
            this.label8.Tag = "";
            this.label8.Text = "Ücret : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Reem Kufi", 15F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(330, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 36);
            this.label9.TabIndex = 27;
            this.label9.Tag = "";
            this.label9.Text = "Üyelik Türü : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Reem Kufi", 15F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(329, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 36);
            this.label10.TabIndex = 29;
            this.label10.Tag = "";
            this.label10.Text = "Kayıt Tarihi : ";
            // 
            // kayitTarihiDtp
            // 
            this.kayitTarihiDtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.kayitTarihiDtp.Location = new System.Drawing.Point(468, 176);
            this.kayitTarihiDtp.Name = "kayitTarihiDtp";
            this.kayitTarihiDtp.Size = new System.Drawing.Size(150, 26);
            this.kayitTarihiDtp.TabIndex = 10;
            // 
            // uyelikTuruCmb
            // 
            this.uyelikTuruCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uyelikTuruCmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uyelikTuruCmb.FormattingEnabled = true;
            this.uyelikTuruCmb.Items.AddRange(new object[] {
            "1 Aylık",
            "3 Aylık",
            "6 Aylık",
            "12 Aylık"});
            this.uyelikTuruCmb.Location = new System.Drawing.Point(468, 103);
            this.uyelikTuruCmb.Name = "uyelikTuruCmb";
            this.uyelikTuruCmb.Size = new System.Drawing.Size(150, 28);
            this.uyelikTuruCmb.TabIndex = 8;
            // 
            // logoPb
            // 
            this.logoPb.BackColor = System.Drawing.Color.Transparent;
            this.logoPb.Image = ((System.Drawing.Image)(resources.GetObject("logoPb.Image")));
            this.logoPb.Location = new System.Drawing.Point(93, 6);
            this.logoPb.Name = "logoPb";
            this.logoPb.Size = new System.Drawing.Size(158, 142);
            this.logoPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPb.TabIndex = 21;
            this.logoPb.TabStop = false;
            // 
            // soyadTxt
            // 
            this.soyadTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.soyadTxt.Location = new System.Drawing.Point(164, 103);
            this.soyadTxt.Name = "soyadTxt";
            this.soyadTxt.Size = new System.Drawing.Size(150, 26);
            this.soyadTxt.TabIndex = 2;
            // 
            // ucretTxt
            // 
            this.ucretTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ucretTxt.Location = new System.Drawing.Point(468, 139);
            this.ucretTxt.Name = "ucretTxt";
            this.ucretTxt.Size = new System.Drawing.Size(150, 26);
            this.ucretTxt.TabIndex = 9;
            // 
            // yasTxt
            // 
            this.yasTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.yasTxt.Location = new System.Drawing.Point(164, 211);
            this.yasTxt.Name = "yasTxt";
            this.yasTxt.Size = new System.Drawing.Size(150, 26);
            this.yasTxt.TabIndex = 5;
            // 
            // arkaPlanPb
            // 
            this.arkaPlanPb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arkaPlanPb.Image = ((System.Drawing.Image)(resources.GetObject("arkaPlanPb.Image")));
            this.arkaPlanPb.Location = new System.Drawing.Point(0, 0);
            this.arkaPlanPb.Name = "arkaPlanPb";
            this.arkaPlanPb.Size = new System.Drawing.Size(920, 580);
            this.arkaPlanPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.arkaPlanPb.TabIndex = 22;
            this.arkaPlanPb.TabStop = false;
            // 
            // tcMtb
            // 
            this.tcMtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tcMtb.Location = new System.Drawing.Point(164, 139);
            this.tcMtb.Mask = "00000000000";
            this.tcMtb.Name = "tcMtb";
            this.tcMtb.PromptChar = ' ';
            this.tcMtb.Size = new System.Drawing.Size(150, 26);
            this.tcMtb.TabIndex = 3;
            // 
            // YeniKayit
            // 
            this.AcceptButton = this.kaydetBtn;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.geriDonBtn;
            this.ClientSize = new System.Drawing.Size(920, 580);
            this.Controls.Add(this.logoPb);
            this.Controls.Add(this.baslikLbl);
            this.Controls.Add(this.kayitGroupBox);
            this.Controls.Add(this.geriDonBtn);
            this.Controls.Add(this.temizleBtn);
            this.Controls.Add(this.kaydetBtn);
            this.Controls.Add(this.arkaPlanPb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "YeniKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YeniKayit";
            this.Load += new System.EventHandler(this.YeniKayit_Load);
            this.kayitGroupBox.ResumeLayout(false);
            this.kayitGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arkaPlanPb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox adTxt;
        private System.Windows.Forms.MaskedTextBox telefonMtb;
        private System.Windows.Forms.ComboBox cinsiyetCmb;
        private System.Windows.Forms.Button kaydetBtn;
        private System.Windows.Forms.Button temizleBtn;
        private System.Windows.Forms.Button geriDonBtn;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox kayitGroupBox;
        private System.Windows.Forms.Label baslikLbl;
        private System.Windows.Forms.ComboBox kanGrubuCmb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox adresTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox uyelikTuruCmb;
        private System.Windows.Forms.DateTimePicker kayitTarihiDtp;
        private System.Windows.Forms.PictureBox logoPb;
        private System.Windows.Forms.TextBox yasTxt;
        private System.Windows.Forms.TextBox ucretTxt;
        private System.Windows.Forms.TextBox soyadTxt;
        private System.Windows.Forms.PictureBox arkaPlanPb;
        private System.Windows.Forms.MaskedTextBox tcMtb;
    }
}