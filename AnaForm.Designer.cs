namespace sporSalonu
{
    partial class AnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.arkaPlanPb = new System.Windows.Forms.PictureBox();
            this.baslikLbl = new System.Windows.Forms.Label();
            this.logoPb = new System.Windows.Forms.PictureBox();
            this.yeniKayitBtn = new System.Windows.Forms.Button();
            this.kayitGuncelleBtn = new System.Windows.Forms.Button();
            this.cikisBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.arkaPlanPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPb)).BeginInit();
            this.SuspendLayout();
            // 
            // arkaPlanPb
            // 
            this.arkaPlanPb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arkaPlanPb.Image = ((System.Drawing.Image)(resources.GetObject("arkaPlanPb.Image")));
            this.arkaPlanPb.Location = new System.Drawing.Point(0, 0);
            this.arkaPlanPb.Name = "arkaPlanPb";
            this.arkaPlanPb.Size = new System.Drawing.Size(920, 580);
            this.arkaPlanPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.arkaPlanPb.TabIndex = 0;
            this.arkaPlanPb.TabStop = false;
            // 
            // baslikLbl
            // 
            this.baslikLbl.AutoSize = true;
            this.baslikLbl.BackColor = System.Drawing.Color.Transparent;
            this.baslikLbl.Font = new System.Drawing.Font("Reem Kufi", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslikLbl.Location = new System.Drawing.Point(315, 62);
            this.baslikLbl.Name = "baslikLbl";
            this.baslikLbl.Size = new System.Drawing.Size(464, 86);
            this.baslikLbl.TabIndex = 1;
            this.baslikLbl.Text = "YÖNETİM  PANELİ";
            // 
            // logoPb
            // 
            this.logoPb.BackColor = System.Drawing.Color.Transparent;
            this.logoPb.Image = ((System.Drawing.Image)(resources.GetObject("logoPb.Image")));
            this.logoPb.Location = new System.Drawing.Point(90, 12);
            this.logoPb.Name = "logoPb";
            this.logoPb.Size = new System.Drawing.Size(219, 195);
            this.logoPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPb.TabIndex = 2;
            this.logoPb.TabStop = false;
            // 
            // yeniKayitBtn
            // 
            this.yeniKayitBtn.BackColor = System.Drawing.Color.White;
            this.yeniKayitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yeniKayitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.yeniKayitBtn.Font = new System.Drawing.Font("Reem Kufi", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yeniKayitBtn.ForeColor = System.Drawing.Color.Black;
            this.yeniKayitBtn.Location = new System.Drawing.Point(171, 230);
            this.yeniKayitBtn.Name = "yeniKayitBtn";
            this.yeniKayitBtn.Size = new System.Drawing.Size(258, 153);
            this.yeniKayitBtn.TabIndex = 6;
            this.yeniKayitBtn.Text = "Yeni Kayıt";
            this.yeniKayitBtn.UseVisualStyleBackColor = false;
            this.yeniKayitBtn.Click += new System.EventHandler(this.girisYapBtn_Click);
            // 
            // kayitGuncelleBtn
            // 
            this.kayitGuncelleBtn.BackColor = System.Drawing.Color.White;
            this.kayitGuncelleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kayitGuncelleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.kayitGuncelleBtn.Font = new System.Drawing.Font("Reem Kufi", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayitGuncelleBtn.ForeColor = System.Drawing.Color.Black;
            this.kayitGuncelleBtn.Location = new System.Drawing.Point(506, 230);
            this.kayitGuncelleBtn.Name = "kayitGuncelleBtn";
            this.kayitGuncelleBtn.Size = new System.Drawing.Size(257, 153);
            this.kayitGuncelleBtn.TabIndex = 7;
            this.kayitGuncelleBtn.Text = "Kayıt Güncelle/Sil";
            this.kayitGuncelleBtn.UseVisualStyleBackColor = false;
            this.kayitGuncelleBtn.Click += new System.EventHandler(this.kayitGuncelleBtn_Click);
            // 
            // cikisBtn
            // 
            this.cikisBtn.BackColor = System.Drawing.Color.White;
            this.cikisBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cikisBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cikisBtn.Font = new System.Drawing.Font("Reem Kufi", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikisBtn.ForeColor = System.Drawing.Color.Black;
            this.cikisBtn.Location = new System.Drawing.Point(340, 405);
            this.cikisBtn.Name = "cikisBtn";
            this.cikisBtn.Size = new System.Drawing.Size(257, 153);
            this.cikisBtn.TabIndex = 8;
            this.cikisBtn.Text = "ÇIKIŞ";
            this.cikisBtn.UseVisualStyleBackColor = false;
            this.cikisBtn.Click += new System.EventHandler(this.cikisBtn_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cikisBtn;
            this.ClientSize = new System.Drawing.Size(920, 580);
            this.Controls.Add(this.cikisBtn);
            this.Controls.Add(this.kayitGuncelleBtn);
            this.Controls.Add(this.yeniKayitBtn);
            this.Controls.Add(this.logoPb);
            this.Controls.Add(this.baslikLbl);
            this.Controls.Add(this.arkaPlanPb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaForm";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.arkaPlanPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox arkaPlanPb;
        private System.Windows.Forms.Label baslikLbl;
        private System.Windows.Forms.PictureBox logoPb;
        private System.Windows.Forms.Button yeniKayitBtn;
        private System.Windows.Forms.Button kayitGuncelleBtn;
        private System.Windows.Forms.Button cikisBtn;
    }
}