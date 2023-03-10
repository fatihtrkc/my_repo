namespace FormsApp_SayiTahminEt
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblPercent = new Label();
            prgbarDurum = new ProgressBar();
            nmrSayi = new NumericUpDown();
            lblSayiSonuc = new Label();
            lblSayiDurum = new Label();
            label1 = new Label();
            btnTahminEt = new Button();
            btnOyunBaslat = new Button();
            timer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)nmrSayi).BeginInit();
            SuspendLayout();
            // 
            // lblPercent
            // 
            lblPercent.AutoSize = true;
            lblPercent.BackColor = Color.LimeGreen;
            lblPercent.Location = new Point(241, 366);
            lblPercent.Name = "lblPercent";
            lblPercent.Size = new Size(0, 42);
            lblPercent.TabIndex = 12;
            // 
            // prgbarDurum
            // 
            prgbarDurum.Enabled = false;
            prgbarDurum.Location = new Point(40, 360);
            prgbarDurum.Maximum = 30;
            prgbarDurum.Name = "prgbarDurum";
            prgbarDurum.Size = new Size(650, 50);
            prgbarDurum.Step = 0;
            prgbarDurum.TabIndex = 11;
            // 
            // nmrSayi
            // 
            nmrSayi.BackColor = Color.GhostWhite;
            nmrSayi.Enabled = false;
            nmrSayi.Location = new Point(290, 118);
            nmrSayi.Margin = new Padding(6, 8, 6, 8);
            nmrSayi.Name = "nmrSayi";
            nmrSayi.Size = new Size(400, 50);
            nmrSayi.TabIndex = 6;
            // 
            // lblSayiSonuc
            // 
            lblSayiSonuc.BackColor = Color.GhostWhite;
            lblSayiSonuc.Enabled = false;
            lblSayiSonuc.Location = new Point(40, 420);
            lblSayiSonuc.Name = "lblSayiSonuc";
            lblSayiSonuc.Size = new Size(650, 50);
            lblSayiSonuc.TabIndex = 7;
            // 
            // lblSayiDurum
            // 
            lblSayiDurum.BackColor = Color.GhostWhite;
            lblSayiDurum.Enabled = false;
            lblSayiDurum.Location = new Point(40, 300);
            lblSayiDurum.Name = "lblSayiDurum";
            lblSayiDurum.Size = new Size(650, 50);
            lblSayiDurum.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 120);
            label1.Name = "label1";
            label1.Size = new Size(222, 42);
            label1.TabIndex = 9;
            label1.Text = "Bir sayı giriniz  :";
            // 
            // btnTahminEt
            // 
            btnTahminEt.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnTahminEt.BackColor = Color.GhostWhite;
            btnTahminEt.Enabled = false;
            btnTahminEt.Location = new Point(40, 200);
            btnTahminEt.Name = "btnTahminEt";
            btnTahminEt.Size = new Size(650, 50);
            btnTahminEt.TabIndex = 10;
            btnTahminEt.Text = "Tahmin Et";
            btnTahminEt.UseVisualStyleBackColor = false;
            btnTahminEt.Click += btnTahminEt_Click;
            // 
            // btnOyunBaslat
            // 
            btnOyunBaslat.BackColor = Color.GhostWhite;
            btnOyunBaslat.Location = new Point(40, 40);
            btnOyunBaslat.Name = "btnOyunBaslat";
            btnOyunBaslat.Size = new Size(650, 50);
            btnOyunBaslat.TabIndex = 5;
            btnOyunBaslat.Text = "Oyunu Başlat";
            btnOyunBaslat.UseVisualStyleBackColor = false;
            btnOyunBaslat.Click += btnOyunBaslat_Click;
            // 
            // timer
            // 
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 42F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(728, 544);
            Controls.Add(lblPercent);
            Controls.Add(prgbarDurum);
            Controls.Add(nmrSayi);
            Controls.Add(lblSayiSonuc);
            Controls.Add(lblSayiDurum);
            Controls.Add(label1);
            Controls.Add(btnTahminEt);
            Controls.Add(btnOyunBaslat);
            Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sayı Tahmin Et";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nmrSayi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPercent;
        private ProgressBar prgbarDurum;
        private NumericUpDown nmrSayi;
        private Label lblSayiSonuc;
        private Label lblSayiDurum;
        private Label label1;
        private Button btnTahminEt;
        private Button btnOyunBaslat;
        private System.Windows.Forms.Timer timer;
    }
}