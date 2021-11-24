namespace PomodoroZamanlayiciUI
{
    partial class FrmAyarlar
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
            this.gboxTercihler = new System.Windows.Forms.GroupBox();
            this.clBoxTercihler = new System.Windows.Forms.CheckedListBox();
            this.gboxSure = new System.Windows.Forms.GroupBox();
            this.lblUzunAra = new System.Windows.Forms.Label();
            this.nudUzunAra = new System.Windows.Forms.NumericUpDown();
            this.lblKisaAra = new System.Windows.Forms.Label();
            this.nudKisaAra = new System.Windows.Forms.NumericUpDown();
            this.lblPomodoro = new System.Windows.Forms.Label();
            this.nudPomodoro = new System.Windows.Forms.NumericUpDown();
            this.btnSifirla = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.gboxTercihler.SuspendLayout();
            this.gboxSure.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUzunAra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKisaAra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPomodoro)).BeginInit();
            this.SuspendLayout();
            // 
            // gboxTercihler
            // 
            this.gboxTercihler.Controls.Add(this.clBoxTercihler);
            this.gboxTercihler.Location = new System.Drawing.Point(12, 7);
            this.gboxTercihler.Name = "gboxTercihler";
            this.gboxTercihler.Size = new System.Drawing.Size(256, 83);
            this.gboxTercihler.TabIndex = 0;
            this.gboxTercihler.TabStop = false;
            this.gboxTercihler.Text = "Tercihler";
            // 
            // clBoxTercihler
            // 
            this.clBoxTercihler.CheckOnClick = true;
            this.clBoxTercihler.FormattingEnabled = true;
            this.clBoxTercihler.Items.AddRange(new object[] {
            "Kalan süreyi başlıkta göster",
            "Süre dolunca alarm çal",
            "Süre dolunca arayı otomatik başlat"});
            this.clBoxTercihler.Location = new System.Drawing.Point(6, 19);
            this.clBoxTercihler.Name = "clBoxTercihler";
            this.clBoxTercihler.Size = new System.Drawing.Size(243, 58);
            this.clBoxTercihler.TabIndex = 0;
            // 
            // gboxSure
            // 
            this.gboxSure.Controls.Add(this.lblUzunAra);
            this.gboxSure.Controls.Add(this.nudUzunAra);
            this.gboxSure.Controls.Add(this.lblKisaAra);
            this.gboxSure.Controls.Add(this.nudKisaAra);
            this.gboxSure.Controls.Add(this.lblPomodoro);
            this.gboxSure.Controls.Add(this.nudPomodoro);
            this.gboxSure.Location = new System.Drawing.Point(13, 94);
            this.gboxSure.Name = "gboxSure";
            this.gboxSure.Size = new System.Drawing.Size(255, 126);
            this.gboxSure.TabIndex = 1;
            this.gboxSure.TabStop = false;
            this.gboxSure.Text = "Özel Süre (Dakika)";
            // 
            // lblUzunAra
            // 
            this.lblUzunAra.AutoSize = true;
            this.lblUzunAra.Location = new System.Drawing.Point(6, 99);
            this.lblUzunAra.Name = "lblUzunAra";
            this.lblUzunAra.Size = new System.Drawing.Size(71, 17);
            this.lblUzunAra.TabIndex = 3;
            this.lblUzunAra.Text = "Uzun Ara:";
            // 
            // nudUzunAra
            // 
            this.nudUzunAra.Location = new System.Drawing.Point(89, 97);
            this.nudUzunAra.Name = "nudUzunAra";
            this.nudUzunAra.Size = new System.Drawing.Size(67, 23);
            this.nudUzunAra.TabIndex = 0;
            // 
            // lblKisaAra
            // 
            this.lblKisaAra.AutoSize = true;
            this.lblKisaAra.Location = new System.Drawing.Point(6, 65);
            this.lblKisaAra.Name = "lblKisaAra";
            this.lblKisaAra.Size = new System.Drawing.Size(65, 17);
            this.lblKisaAra.TabIndex = 3;
            this.lblKisaAra.Text = "Kısa Ara:";
            // 
            // nudKisaAra
            // 
            this.nudKisaAra.Location = new System.Drawing.Point(89, 63);
            this.nudKisaAra.Name = "nudKisaAra";
            this.nudKisaAra.Size = new System.Drawing.Size(67, 23);
            this.nudKisaAra.TabIndex = 0;
            // 
            // lblPomodoro
            // 
            this.lblPomodoro.AutoSize = true;
            this.lblPomodoro.Location = new System.Drawing.Point(6, 31);
            this.lblPomodoro.Name = "lblPomodoro";
            this.lblPomodoro.Size = new System.Drawing.Size(77, 17);
            this.lblPomodoro.TabIndex = 3;
            this.lblPomodoro.Text = "Pomodoro:";
            // 
            // nudPomodoro
            // 
            this.nudPomodoro.Location = new System.Drawing.Point(89, 29);
            this.nudPomodoro.Name = "nudPomodoro";
            this.nudPomodoro.Size = new System.Drawing.Size(67, 23);
            this.nudPomodoro.TabIndex = 0;
            // 
            // btnSifirla
            // 
            this.btnSifirla.Location = new System.Drawing.Point(143, 223);
            this.btnSifirla.Name = "btnSifirla";
            this.btnSifirla.Size = new System.Drawing.Size(75, 37);
            this.btnSifirla.TabIndex = 5;
            this.btnSifirla.Text = "Sıfırla";
            this.btnSifirla.UseVisualStyleBackColor = true;
            this.btnSifirla.Click += new System.EventHandler(this.BtnSifirla_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(62, 223);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 37);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // FrmAyarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 267);
            this.Controls.Add(this.btnSifirla);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.gboxSure);
            this.Controls.Add(this.gboxTercihler);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAyarlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ayarlar";
            this.Load += new System.EventHandler(this.FrmAyarlar_Load);
            this.gboxTercihler.ResumeLayout(false);
            this.gboxSure.ResumeLayout(false);
            this.gboxSure.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUzunAra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKisaAra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPomodoro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxTercihler;
        private System.Windows.Forms.GroupBox gboxSure;
        private System.Windows.Forms.CheckedListBox clBoxTercihler;
        private System.Windows.Forms.Label lblUzunAra;
        private System.Windows.Forms.NumericUpDown nudUzunAra;
        private System.Windows.Forms.Label lblKisaAra;
        private System.Windows.Forms.NumericUpDown nudKisaAra;
        private System.Windows.Forms.Label lblPomodoro;
        private System.Windows.Forms.NumericUpDown nudPomodoro;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSifirla;
    }
}