namespace Password_Generating_Game
{
    partial class PasswordGeneratingForm
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
            btnShow = new Button();
            grpbxGetValue = new GroupBox();
            btnConfirm = new Button();
            nmrPsswrdCount = new NumericUpDown();
            grpbxGetValue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrPsswrdCount).BeginInit();
            SuspendLayout();
            // 
            // btnShow
            // 
            btnShow.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnShow.BackColor = Color.SkyBlue;
            btnShow.Location = new Point(12, 12);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(830, 68);
            btnShow.TabIndex = 2;
            btnShow.Text = "Show Home Screen";
            btnShow.UseVisualStyleBackColor = false;
            btnShow.Click += btnShow_Click;
            // 
            // grpbxGetValue
            // 
            grpbxGetValue.Controls.Add(btnConfirm);
            grpbxGetValue.Location = new Point(12, 86);
            grpbxGetValue.Name = "grpbxGetValue";
            grpbxGetValue.Size = new Size(830, 200);
            grpbxGetValue.TabIndex = 3;
            grpbxGetValue.TabStop = false;
            grpbxGetValue.Text = "How many numbers of password you want generated ?";
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(270, 88);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(500, 57);
            btnConfirm.TabIndex = 0;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // nmrPsswrdCount
            // 
            nmrPsswrdCount.Location = new Point(100, 174);
            nmrPsswrdCount.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nmrPsswrdCount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nmrPsswrdCount.Name = "nmrPsswrdCount";
            nmrPsswrdCount.Size = new Size(75, 57);
            nmrPsswrdCount.TabIndex = 0;
            nmrPsswrdCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // PasswordGeneratingForm
            // 
            AcceptButton = btnConfirm;
            AutoScaleDimensions = new SizeF(18F, 49F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(854, 294);
            Controls.Add(nmrPsswrdCount);
            Controls.Add(grpbxGetValue);
            Controls.Add(btnShow);
            Font = new Font("Segoe Print", 14F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(5, 6, 5, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PasswordGeneratingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Password Generating Form";
            grpbxGetValue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nmrPsswrdCount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnShow;
        private GroupBox grpbxGetValue;
        private Button btnConfirm;
        private NumericUpDown nmrPsswrdCount;
    }
}