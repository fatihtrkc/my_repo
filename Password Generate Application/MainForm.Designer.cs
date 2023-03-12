namespace Password_Generating_Game
{
    partial class MainForm
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
            grpbxSelection = new GroupBox();
            grpbxGetValue = new GroupBox();
            nmrPsswrdCount = new NumericUpDown();
            btnConfirm = new Button();
            chckSpecial = new CheckBox();
            chckNumber = new CheckBox();
            chckLower = new CheckBox();
            chckUpper = new CheckBox();
            btnPsswrdGnrt = new Button();
            grpbxSelection.SuspendLayout();
            grpbxGetValue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrPsswrdCount).BeginInit();
            SuspendLayout();
            // 
            // grpbxSelection
            // 
            grpbxSelection.Controls.Add(grpbxGetValue);
            grpbxSelection.Controls.Add(chckSpecial);
            grpbxSelection.Controls.Add(chckNumber);
            grpbxSelection.Controls.Add(chckLower);
            grpbxSelection.Controls.Add(chckUpper);
            grpbxSelection.Location = new Point(14, 12);
            grpbxSelection.Name = "grpbxSelection";
            grpbxSelection.Size = new Size(650, 440);
            grpbxSelection.TabIndex = 2;
            grpbxSelection.TabStop = false;
            grpbxSelection.Text = "Please tick your requested parameters";
            // 
            // grpbxGetValue
            // 
            grpbxGetValue.Controls.Add(nmrPsswrdCount);
            grpbxGetValue.Controls.Add(btnConfirm);
            grpbxGetValue.Location = new Point(40, 280);
            grpbxGetValue.Name = "grpbxGetValue";
            grpbxGetValue.Size = new Size(583, 141);
            grpbxGetValue.TabIndex = 2;
            grpbxGetValue.TabStop = false;
            grpbxGetValue.Text = "Total Character Count of Password";
            // 
            // nmrPsswrdCount
            // 
            nmrPsswrdCount.Location = new Point(50, 60);
            nmrPsswrdCount.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nmrPsswrdCount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nmrPsswrdCount.Name = "nmrPsswrdCount";
            nmrPsswrdCount.Size = new Size(100, 57);
            nmrPsswrdCount.TabIndex = 0;
            nmrPsswrdCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(250, 60);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(250, 57);
            btnConfirm.TabIndex = 1;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // chckSpecial
            // 
            chckSpecial.AutoSize = true;
            chckSpecial.Font = new Font("Segoe Print", 11F, FontStyle.Regular, GraphicsUnit.Point);
            chckSpecial.Location = new Point(300, 180);
            chckSpecial.Name = "chckSpecial";
            chckSpecial.Size = new Size(294, 42);
            chckSpecial.TabIndex = 3;
            chckSpecial.Text = "Special Character(?!*..)";
            chckSpecial.UseVisualStyleBackColor = true;
            chckSpecial.CheckedChanged += chckSpecial_CheckedChanged;
            // 
            // chckNumber
            // 
            chckNumber.AutoSize = true;
            chckNumber.Font = new Font("Segoe Print", 11F, FontStyle.Regular, GraphicsUnit.Point);
            chckNumber.Location = new Point(300, 80);
            chckNumber.Name = "chckNumber";
            chckNumber.Size = new Size(327, 42);
            chckNumber.TabIndex = 1;
            chckNumber.Text = "Number Character(012..)";
            chckNumber.UseVisualStyleBackColor = true;
            chckNumber.CheckedChanged += chckNumber_CheckedChanged;
            // 
            // chckLower
            // 
            chckLower.AutoSize = true;
            chckLower.Font = new Font("Segoe Print", 11F, FontStyle.Regular, GraphicsUnit.Point);
            chckLower.Location = new Point(40, 180);
            chckLower.Name = "chckLower";
            chckLower.Size = new Size(233, 42);
            chckLower.TabIndex = 2;
            chckLower.Text = "Lower Case(abc..)";
            chckLower.UseVisualStyleBackColor = true;
            chckLower.CheckedChanged += chckLower_CheckedChanged;
            // 
            // chckUpper
            // 
            chckUpper.AutoSize = true;
            chckUpper.Font = new Font("Segoe Print", 11F, FontStyle.Regular, GraphicsUnit.Point);
            chckUpper.Location = new Point(40, 80);
            chckUpper.Name = "chckUpper";
            chckUpper.Size = new Size(244, 42);
            chckUpper.TabIndex = 0;
            chckUpper.Text = "Upper Case(ABC..)";
            chckUpper.UseVisualStyleBackColor = true;
            chckUpper.CheckedChanged += chckUpper_CheckedChanged;
            // 
            // btnPsswrdGnrt
            // 
            btnPsswrdGnrt.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnPsswrdGnrt.BackColor = Color.SkyBlue;
            btnPsswrdGnrt.Enabled = false;
            btnPsswrdGnrt.Location = new Point(14, 464);
            btnPsswrdGnrt.Name = "btnPsswrdGnrt";
            btnPsswrdGnrt.Size = new Size(650, 68);
            btnPsswrdGnrt.TabIndex = 0;
            btnPsswrdGnrt.Text = "Password Generate";
            btnPsswrdGnrt.UseVisualStyleBackColor = false;
            btnPsswrdGnrt.Click += btnPsswrdGnrt_Click;
            // 
            // MainForm
            // 
            AcceptButton = btnConfirm;
            AutoScaleDimensions = new SizeF(18F, 49F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(678, 544);
            Controls.Add(grpbxSelection);
            Controls.Add(btnPsswrdGnrt);
            Font = new Font("Segoe Print", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Password Generate Application";
            grpbxSelection.ResumeLayout(false);
            grpbxSelection.PerformLayout();
            grpbxGetValue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nmrPsswrdCount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpbxSelection;
        private GroupBox grpbxGetValue;
        private NumericUpDown nmrPsswrdCount;
        private Button btnConfirm;
        private CheckBox chckSpecial;
        private CheckBox chckNumber;
        private CheckBox chckLower;
        private CheckBox chckUpper;
        private Button btnPsswrdGnrt;
    }
}