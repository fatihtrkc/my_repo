namespace Password_Generating_Game
{
    partial class PasswordsForm
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
            components = new System.ComponentModel.Container();
            lstPasswords = new ListBox();
            timer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lstPasswords
            // 
            lstPasswords.BackColor = SystemColors.Window;
            lstPasswords.Dock = DockStyle.Fill;
            lstPasswords.FormattingEnabled = true;
            lstPasswords.ItemHeight = 42;
            lstPasswords.Location = new Point(0, 0);
            lstPasswords.Name = "lstPasswords";
            lstPasswords.Size = new Size(478, 344);
            lstPasswords.TabIndex = 1;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 2000;
            timer.Tick += timer_Tick;
            // 
            // PasswordsForm
            // 
            AutoScaleDimensions = new SizeF(15F, 42F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(478, 344);
            Controls.Add(lstPasswords);
            Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PasswordsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Passwords";
            Load += PasswordsForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstPasswords;
        private System.Windows.Forms.Timer timer;
    }
}