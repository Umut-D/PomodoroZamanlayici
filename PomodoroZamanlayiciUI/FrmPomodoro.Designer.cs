namespace PomodoroZamanlayiciUI
{
    partial class FrmPomodoro
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPomodoro));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tsmiAyarlar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBilgi = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmKisayollar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmGuncelle = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHakkinda = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage = new System.Windows.Forms.TabControl();
            this.tabPomodoro = new System.Windows.Forms.TabPage();
            this.tabKisaAra = new System.Windows.Forms.TabPage();
            this.tabUzunAra = new System.Windows.Forms.TabPage();
            this.lblPomodoro = new System.Windows.Forms.Label();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.btnDur = new System.Windows.Forms.Button();
            this.btnSifirla = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip.SuspendLayout();
            this.tabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAyarlar,
            this.tsmiBilgi});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(302, 31);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // tsmiAyarlar
            // 
            this.tsmiAyarlar.Name = "tsmiAyarlar";
            this.tsmiAyarlar.Size = new System.Drawing.Size(79, 27);
            this.tsmiAyarlar.Text = "Ayarlar";
            this.tsmiAyarlar.Click += new System.EventHandler(this.TsmiAyarlar_Click);
            // 
            // tsmiBilgi
            // 
            this.tsmiBilgi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmKisayollar,
            this.tsmGuncelle,
            this.tsmHakkinda});
            this.tsmiBilgi.Name = "tsmiBilgi";
            this.tsmiBilgi.Size = new System.Drawing.Size(58, 27);
            this.tsmiBilgi.Text = "Bilgi";
            // 
            // tsmKisayollar
            // 
            this.tsmKisayollar.Name = "tsmKisayollar";
            this.tsmKisayollar.Size = new System.Drawing.Size(232, 30);
            this.tsmKisayollar.Text = "Klavye Kısayolları";
            this.tsmKisayollar.Click += new System.EventHandler(this.TsmKisayollar_Click);
            // 
            // tsmGuncelle
            // 
            this.tsmGuncelle.Name = "tsmGuncelle";
            this.tsmGuncelle.Size = new System.Drawing.Size(232, 30);
            this.tsmGuncelle.Text = "Güncelle";
            this.tsmGuncelle.Click += new System.EventHandler(this.TsmGuncelle_Click);
            // 
            // tsmHakkinda
            // 
            this.tsmHakkinda.Name = "tsmHakkinda";
            this.tsmHakkinda.Size = new System.Drawing.Size(232, 30);
            this.tsmHakkinda.Text = "Hakkında";
            this.tsmHakkinda.Click += new System.EventHandler(this.TsmHakkinda_Click);
            // 
            // tabPage
            // 
            this.tabPage.Controls.Add(this.tabPomodoro);
            this.tabPage.Controls.Add(this.tabKisaAra);
            this.tabPage.Controls.Add(this.tabUzunAra);
            this.tabPage.Font = new System.Drawing.Font("Segoe UI", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage.Location = new System.Drawing.Point(12, 27);
            this.tabPage.Name = "tabPage";
            this.tabPage.SelectedIndex = 0;
            this.tabPage.Size = new System.Drawing.Size(278, 22);
            this.tabPage.TabIndex = 1;
            this.tabPage.SelectedIndexChanged += new System.EventHandler(this.TabPage_SelectedIndexChanged);
            // 
            // tabPomodoro
            // 
            this.tabPomodoro.Location = new System.Drawing.Point(4, 32);
            this.tabPomodoro.Name = "tabPomodoro";
            this.tabPomodoro.Padding = new System.Windows.Forms.Padding(3);
            this.tabPomodoro.Size = new System.Drawing.Size(270, 0);
            this.tabPomodoro.TabIndex = 0;
            this.tabPomodoro.Text = "Pomodoro";
            this.tabPomodoro.UseVisualStyleBackColor = true;
            // 
            // tabKisaAra
            // 
            this.tabKisaAra.Location = new System.Drawing.Point(4, 32);
            this.tabKisaAra.Name = "tabKisaAra";
            this.tabKisaAra.Padding = new System.Windows.Forms.Padding(3);
            this.tabKisaAra.Size = new System.Drawing.Size(270, 0);
            this.tabKisaAra.TabIndex = 1;
            this.tabKisaAra.Text = "Kısa Ara";
            this.tabKisaAra.UseVisualStyleBackColor = true;
            // 
            // tabUzunAra
            // 
            this.tabUzunAra.Location = new System.Drawing.Point(4, 32);
            this.tabUzunAra.Name = "tabUzunAra";
            this.tabUzunAra.Padding = new System.Windows.Forms.Padding(3);
            this.tabUzunAra.Size = new System.Drawing.Size(270, 0);
            this.tabUzunAra.TabIndex = 2;
            this.tabUzunAra.Text = "Uzun Ara";
            this.tabUzunAra.UseVisualStyleBackColor = true;
            // 
            // lblPomodoro
            // 
            this.lblPomodoro.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPomodoro.Font = new System.Drawing.Font("Segoe UI", 46F);
            this.lblPomodoro.Location = new System.Drawing.Point(13, 36);
            this.lblPomodoro.Name = "lblPomodoro";
            this.lblPomodoro.Size = new System.Drawing.Size(277, 77);
            this.lblPomodoro.TabIndex = 0;
            this.lblPomodoro.Tag = "25:00";
            this.lblPomodoro.Text = "25:00";
            this.lblPomodoro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBaslat
            // 
            this.btnBaslat.BackColor = System.Drawing.Color.LimeGreen;
            this.btnBaslat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBaslat.Location = new System.Drawing.Point(22, 115);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(75, 36);
            this.btnBaslat.TabIndex = 1;
            this.btnBaslat.Text = "Başla";
            this.btnBaslat.UseVisualStyleBackColor = false;
            this.btnBaslat.Click += new System.EventHandler(this.BtnBaslat_Click);
            // 
            // btnDur
            // 
            this.btnDur.BackColor = System.Drawing.Color.Red;
            this.btnDur.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDur.Location = new System.Drawing.Point(114, 115);
            this.btnDur.Name = "btnDur";
            this.btnDur.Size = new System.Drawing.Size(75, 36);
            this.btnDur.TabIndex = 2;
            this.btnDur.Text = "Dur";
            this.btnDur.UseVisualStyleBackColor = false;
            this.btnDur.Click += new System.EventHandler(this.BtnDur_Click);
            // 
            // btnSifirla
            // 
            this.btnSifirla.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSifirla.Location = new System.Drawing.Point(204, 115);
            this.btnSifirla.Name = "btnSifirla";
            this.btnSifirla.Size = new System.Drawing.Size(75, 36);
            this.btnSifirla.TabIndex = 3;
            this.btnSifirla.Text = "Sıfırla";
            this.btnSifirla.UseVisualStyleBackColor = true;
            this.btnSifirla.Click += new System.EventHandler(this.BtnSifirla_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // FrmPomodoro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 161);
            this.Controls.Add(this.btnSifirla);
            this.Controls.Add(this.btnDur);
            this.Controls.Add(this.tabPage);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.lblPomodoro);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmPomodoro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pomodoro Zamanlayıcı";
            this.Activated += new System.EventHandler(this.FrmPomodoro_Activated);
            this.Load += new System.EventHandler(this.FrmPomodoro_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmPomodoro_KeyDown);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmiAyarlar;
        private System.Windows.Forms.ToolStripMenuItem tsmiBilgi;
        private System.Windows.Forms.ToolStripMenuItem tsmKisayollar;
        private System.Windows.Forms.ToolStripMenuItem tsmHakkinda;
        private System.Windows.Forms.TabControl tabPage;
        private System.Windows.Forms.TabPage tabPomodoro;
        private System.Windows.Forms.TabPage tabKisaAra;
        private System.Windows.Forms.TabPage tabUzunAra;
        private System.Windows.Forms.Label lblPomodoro;
        private System.Windows.Forms.Button btnSifirla;
        private System.Windows.Forms.Button btnDur;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripMenuItem tsmGuncelle;
    }
}

