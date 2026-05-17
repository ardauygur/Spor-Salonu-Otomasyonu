namespace sporSalonu
{
    partial class Login
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.kullaniciAdiLbl = new System.Windows.Forms.Label();
            this.sifreLbl = new System.Windows.Forms.Label();
            this.girisYapBtn = new System.Windows.Forms.Button();
            this.kullaniciAdTxt = new System.Windows.Forms.TextBox();
            this.sifreTxt = new System.Windows.Forms.TextBox();
            this.arkaPlanPb = new System.Windows.Forms.PictureBox();
            this.logoPb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.arkaPlanPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPb)).BeginInit();
            this.SuspendLayout();
            // 
            // kullaniciAdiLbl
            // 
            this.kullaniciAdiLbl.AutoSize = true;
            this.kullaniciAdiLbl.BackColor = System.Drawing.Color.Transparent;
            this.kullaniciAdiLbl.Font = new System.Drawing.Font("Reem Kufi", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciAdiLbl.ForeColor = System.Drawing.Color.Black;
            this.kullaniciAdiLbl.Location = new System.Drawing.Point(150, 285);
            this.kullaniciAdiLbl.Name = "kullaniciAdiLbl";
            this.kullaniciAdiLbl.Size = new System.Drawing.Size(192, 49);
            this.kullaniciAdiLbl.TabIndex = 10;
            this.kullaniciAdiLbl.Tag = "";
            this.kullaniciAdiLbl.Text = "Kullanıcı Adı :";
            // 
            // sifreLbl
            // 
            this.sifreLbl.AutoSize = true;
            this.sifreLbl.BackColor = System.Drawing.Color.Transparent;
            this.sifreLbl.Font = new System.Drawing.Font("Reem Kufi", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreLbl.ForeColor = System.Drawing.Color.Black;
            this.sifreLbl.Location = new System.Drawing.Point(250, 359);
            this.sifreLbl.Name = "sifreLbl";
            this.sifreLbl.Size = new System.Drawing.Size(92, 49);
            this.sifreLbl.TabIndex = 11;
            this.sifreLbl.Tag = "";
            this.sifreLbl.Text = "Şifre :";            
            // 
            // girisYapBtn
            // 
            this.girisYapBtn.BackColor = System.Drawing.Color.White;
            this.girisYapBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.girisYapBtn.Font = new System.Drawing.Font("Reem Kufi", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisYapBtn.ForeColor = System.Drawing.Color.Black;
            this.girisYapBtn.Location = new System.Drawing.Point(348, 432);
            this.girisYapBtn.Name = "girisYapBtn";
            this.girisYapBtn.Size = new System.Drawing.Size(238, 117);
            this.girisYapBtn.TabIndex = 5;
            this.girisYapBtn.Text = "Giriş Yap";
            this.girisYapBtn.UseVisualStyleBackColor = false;
            this.girisYapBtn.Click += new System.EventHandler(this.girisYapBtn_Click);
            // 
            // kullaniciAdTxt
            // 
            this.kullaniciAdTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.25F);
            this.kullaniciAdTxt.Location = new System.Drawing.Point(348, 295);
            this.kullaniciAdTxt.Name = "kullaniciAdTxt";
            this.kullaniciAdTxt.Size = new System.Drawing.Size(238, 37);
            this.kullaniciAdTxt.TabIndex = 3;
            // 
            // sifreTxt
            // 
            this.sifreTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.25F);
            this.sifreTxt.Location = new System.Drawing.Point(348, 370);
            this.sifreTxt.Name = "sifreTxt";
            this.sifreTxt.Size = new System.Drawing.Size(238, 37);
            this.sifreTxt.TabIndex = 4;
            this.sifreTxt.UseSystemPasswordChar = true;
            // 
            // arkaPlanPb
            // 
            this.arkaPlanPb.BackColor = System.Drawing.Color.Transparent;
            this.arkaPlanPb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arkaPlanPb.Image = ((System.Drawing.Image)(resources.GetObject("arkaPlanPb.Image")));
            this.arkaPlanPb.Location = new System.Drawing.Point(0, 0);
            this.arkaPlanPb.Name = "arkaPlanPb";
            this.arkaPlanPb.Size = new System.Drawing.Size(920, 580);
            this.arkaPlanPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.arkaPlanPb.TabIndex = 6;
            this.arkaPlanPb.TabStop = false;
            // 
            // logoPb
            // 
            this.logoPb.BackColor = System.Drawing.Color.Transparent;
            this.logoPb.Image = ((System.Drawing.Image)(resources.GetObject("logoPb.Image")));
            this.logoPb.Location = new System.Drawing.Point(338, 0);
            this.logoPb.Name = "logoPb";
            this.logoPb.Size = new System.Drawing.Size(238, 289);
            this.logoPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPb.TabIndex = 12;
            this.logoPb.TabStop = false;
            // 
            // Login
            // 
            this.AcceptButton = this.girisYapBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(920, 580);
            this.Controls.Add(this.logoPb);
            this.Controls.Add(this.girisYapBtn);
            this.Controls.Add(this.sifreTxt);
            this.Controls.Add(this.kullaniciAdTxt);
            this.Controls.Add(this.sifreLbl);
            this.Controls.Add(this.kullaniciAdiLbl);
            this.Controls.Add(this.arkaPlanPb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.arkaPlanPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label kullaniciAdiLbl;
        private System.Windows.Forms.Label sifreLbl;
        private System.Windows.Forms.Button girisYapBtn;
        private System.Windows.Forms.TextBox kullaniciAdTxt;
        private System.Windows.Forms.TextBox sifreTxt;
        private System.Windows.Forms.PictureBox arkaPlanPb;
        private System.Windows.Forms.PictureBox logoPb;
    }
}

