namespace Ebys2022
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnBaslat = new System.Windows.Forms.Button();
            this.btnTempSil = new System.Windows.Forms.Button();
            this.btnDurdur = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ebysAçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tempSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tempAçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fareninKonumunuBulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fareninKonumunuAyarlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tekrarSayısıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.sonsuzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hızToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.milisaniyeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.milisaniyeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.milisaniyeToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.saniyeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBaslat
            // 
            this.btnBaslat.Location = new System.Drawing.Point(6, 26);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(75, 38);
            this.btnBaslat.TabIndex = 0;
            this.btnBaslat.Text = "BAŞLAT";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // btnTempSil
            // 
            this.btnTempSil.Location = new System.Drawing.Point(91, 26);
            this.btnTempSil.Name = "btnTempSil";
            this.btnTempSil.Size = new System.Drawing.Size(75, 38);
            this.btnTempSil.TabIndex = 1;
            this.btnTempSil.Text = "TEMP SİL";
            this.btnTempSil.UseVisualStyleBackColor = true;
            this.btnTempSil.Click += new System.EventHandler(this.btnTempSil_Click);
            // 
            // btnDurdur
            // 
            this.btnDurdur.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDurdur.Location = new System.Drawing.Point(176, 26);
            this.btnDurdur.Name = "btnDurdur";
            this.btnDurdur.Size = new System.Drawing.Size(75, 38);
            this.btnDurdur.TabIndex = 2;
            this.btnDurdur.Text = "DURDUR";
            this.btnDurdur.UseVisualStyleBackColor = true;
            this.btnDurdur.Click += new System.EventHandler(this.btnDurdur_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menüToolStripMenuItem,
            this.ayarlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(256, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menüToolStripMenuItem
            // 
            this.menüToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ebysAçToolStripMenuItem,
            this.toolStripMenuItem1,
            this.tempSilToolStripMenuItem,
            this.tempAçToolStripMenuItem});
            this.menüToolStripMenuItem.Name = "menüToolStripMenuItem";
            this.menüToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menüToolStripMenuItem.Text = "Menü";
            // 
            // ebysAçToolStripMenuItem
            // 
            this.ebysAçToolStripMenuItem.Name = "ebysAçToolStripMenuItem";
            this.ebysAçToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.ebysAçToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ebysAçToolStripMenuItem.Text = "Ebys Aç";
            this.ebysAçToolStripMenuItem.Click += new System.EventHandler(this.ebysAçToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // tempSilToolStripMenuItem
            // 
            this.tempSilToolStripMenuItem.Name = "tempSilToolStripMenuItem";
            this.tempSilToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tempSilToolStripMenuItem.Text = "Temp Sil";
            this.tempSilToolStripMenuItem.Click += new System.EventHandler(this.tempSilToolStripMenuItem_Click);
            // 
            // tempAçToolStripMenuItem
            // 
            this.tempAçToolStripMenuItem.Name = "tempAçToolStripMenuItem";
            this.tempAçToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tempAçToolStripMenuItem.Text = "Temp Aç";
            this.tempAçToolStripMenuItem.Click += new System.EventHandler(this.tempAçToolStripMenuItem_Click);
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fareninKonumunuBulToolStripMenuItem,
            this.fareninKonumunuAyarlaToolStripMenuItem,
            this.tekrarSayısıToolStripMenuItem,
            this.hızToolStripMenuItem});
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            // 
            // fareninKonumunuBulToolStripMenuItem
            // 
            this.fareninKonumunuBulToolStripMenuItem.Name = "fareninKonumunuBulToolStripMenuItem";
            this.fareninKonumunuBulToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.fareninKonumunuBulToolStripMenuItem.Text = "Farenin Konumunu Bul";
            this.fareninKonumunuBulToolStripMenuItem.Click += new System.EventHandler(this.fareninKonumunuBulToolStripMenuItem_Click);
            // 
            // fareninKonumunuAyarlaToolStripMenuItem
            // 
            this.fareninKonumunuAyarlaToolStripMenuItem.Name = "fareninKonumunuAyarlaToolStripMenuItem";
            this.fareninKonumunuAyarlaToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.fareninKonumunuAyarlaToolStripMenuItem.Text = "Farenin Konumunu Ayarla";
            // 
            // tekrarSayısıToolStripMenuItem
            // 
            this.tekrarSayısıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.sonsuzToolStripMenuItem});
            this.tekrarSayısıToolStripMenuItem.Name = "tekrarSayısıToolStripMenuItem";
            this.tekrarSayısıToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.tekrarSayısıToolStripMenuItem.Text = "Tekrar Sayısı";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem3.Text = "100";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem4.Text = "1000";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // sonsuzToolStripMenuItem
            // 
            this.sonsuzToolStripMenuItem.Name = "sonsuzToolStripMenuItem";
            this.sonsuzToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sonsuzToolStripMenuItem.Text = "10000";
            this.sonsuzToolStripMenuItem.Click += new System.EventHandler(this.sonsuzToolStripMenuItem_Click);
            // 
            // hızToolStripMenuItem
            // 
            this.hızToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.milisaniyeToolStripMenuItem,
            this.milisaniyeToolStripMenuItem1,
            this.milisaniyeToolStripMenuItem2,
            this.saniyeToolStripMenuItem});
            this.hızToolStripMenuItem.Name = "hızToolStripMenuItem";
            this.hızToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.hızToolStripMenuItem.Text = "Hız";
            // 
            // milisaniyeToolStripMenuItem
            // 
            this.milisaniyeToolStripMenuItem.Name = "milisaniyeToolStripMenuItem";
            this.milisaniyeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.milisaniyeToolStripMenuItem.Text = "20 milisaniye";
            this.milisaniyeToolStripMenuItem.Click += new System.EventHandler(this.milisaniyeToolStripMenuItem_Click);
            // 
            // milisaniyeToolStripMenuItem1
            // 
            this.milisaniyeToolStripMenuItem1.Name = "milisaniyeToolStripMenuItem1";
            this.milisaniyeToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.milisaniyeToolStripMenuItem1.Text = "50 milisaniye";
            this.milisaniyeToolStripMenuItem1.Click += new System.EventHandler(this.milisaniyeToolStripMenuItem1_Click);
            // 
            // milisaniyeToolStripMenuItem2
            // 
            this.milisaniyeToolStripMenuItem2.Name = "milisaniyeToolStripMenuItem2";
            this.milisaniyeToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.milisaniyeToolStripMenuItem2.Text = "100 milisaniye";
            this.milisaniyeToolStripMenuItem2.Click += new System.EventHandler(this.milisaniyeToolStripMenuItem2_Click);
            // 
            // saniyeToolStripMenuItem
            // 
            this.saniyeToolStripMenuItem.Name = "saniyeToolStripMenuItem";
            this.saniyeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saniyeToolStripMenuItem.Text = "1 saniye";
            this.saniyeToolStripMenuItem.Click += new System.EventHandler(this.saniyeToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnBaslat;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.CancelButton = this.btnDurdur;
            this.ClientSize = new System.Drawing.Size(256, 67);
            this.Controls.Add(this.btnDurdur);
            this.Controls.Add(this.btnTempSil);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 375);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Ebys Silme Proğramı";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Button btnTempSil;
        public System.Windows.Forms.Button btnDurdur;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ebysAçToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tempSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tempAçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fareninKonumunuBulToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fareninKonumunuAyarlaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tekrarSayısıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem sonsuzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hızToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem milisaniyeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem milisaniyeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem milisaniyeToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem saniyeToolStripMenuItem;
    }
}

