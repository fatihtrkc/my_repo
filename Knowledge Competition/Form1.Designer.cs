
namespace Knowledge_Competition
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnA = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCorrectAnswer = new System.Windows.Forms.Label();
            this.lblGivenAnswer = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtQuestionNumber = new System.Windows.Forms.TextBox();
            this.txtCorrectAnswer = new System.Windows.Forms.TextBox();
            this.txtWrongAnswer = new System.Windows.Forms.TextBox();
            this.pctrCorrectAnswer = new System.Windows.Forms.PictureBox();
            this.pctrWrongAnswer = new System.Windows.Forms.PictureBox();
            this.btnFinish = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctrCorrectAnswer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrWrongAnswer)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.richTextBox1.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 13);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(500, 129);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "                           Welcome!!!\n   This is UpsUniversity Knowledge Contest " +
    "in Istanbul\n           The competition contains 5 questions.\n                   " +
    "   Good Luck Everybody";
            // 
            // btnA
            // 
            this.btnA.BackColor = System.Drawing.Color.SkyBlue;
            this.btnA.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnA.Location = new System.Drawing.Point(13, 157);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(244, 61);
            this.btnA.TabIndex = 1;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = false;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnB
            // 
            this.btnB.BackColor = System.Drawing.Color.SkyBlue;
            this.btnB.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnB.Location = new System.Drawing.Point(268, 157);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(244, 61);
            this.btnB.TabIndex = 2;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = false;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnD
            // 
            this.btnD.BackColor = System.Drawing.Color.SkyBlue;
            this.btnD.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnD.Location = new System.Drawing.Point(267, 224);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(244, 61);
            this.btnD.TabIndex = 4;
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = false;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.SkyBlue;
            this.btnC.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnC.Location = new System.Drawing.Point(12, 224);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(244, 61);
            this.btnC.TabIndex = 3;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(534, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Question Number     :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(534, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Correct Answer       :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(534, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "Wrong Answer        :";
            // 
            // lblCorrectAnswer
            // 
            this.lblCorrectAnswer.AutoSize = true;
            this.lblCorrectAnswer.Location = new System.Drawing.Point(323, 396);
            this.lblCorrectAnswer.Name = "lblCorrectAnswer";
            this.lblCorrectAnswer.Size = new System.Drawing.Size(115, 23);
            this.lblCorrectAnswer.TabIndex = 8;
            this.lblCorrectAnswer.Text = "Correct Answer";
            this.lblCorrectAnswer.Visible = false;
            // 
            // lblGivenAnswer
            // 
            this.lblGivenAnswer.AutoSize = true;
            this.lblGivenAnswer.Location = new System.Drawing.Point(450, 396);
            this.lblGivenAnswer.Name = "lblGivenAnswer";
            this.lblGivenAnswer.Size = new System.Drawing.Size(102, 23);
            this.lblGivenAnswer.TabIndex = 9;
            this.lblGivenAnswer.Text = "Given Answer";
            this.lblGivenAnswer.Visible = false;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.SkyBlue;
            this.btnStart.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStart.Location = new System.Drawing.Point(539, 156);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(289, 128);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "First Question";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtQuestionNumber
            // 
            this.txtQuestionNumber.BackColor = System.Drawing.Color.SkyBlue;
            this.txtQuestionNumber.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtQuestionNumber.Location = new System.Drawing.Point(768, 16);
            this.txtQuestionNumber.Name = "txtQuestionNumber";
            this.txtQuestionNumber.Size = new System.Drawing.Size(60, 38);
            this.txtQuestionNumber.TabIndex = 11;
            this.txtQuestionNumber.Text = "   0";
            // 
            // txtCorrectAnswer
            // 
            this.txtCorrectAnswer.BackColor = System.Drawing.Color.SkyBlue;
            this.txtCorrectAnswer.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCorrectAnswer.Location = new System.Drawing.Point(768, 64);
            this.txtCorrectAnswer.Name = "txtCorrectAnswer";
            this.txtCorrectAnswer.Size = new System.Drawing.Size(60, 38);
            this.txtCorrectAnswer.TabIndex = 12;
            this.txtCorrectAnswer.Text = "   0";
            // 
            // txtWrongAnswer
            // 
            this.txtWrongAnswer.BackColor = System.Drawing.Color.SkyBlue;
            this.txtWrongAnswer.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtWrongAnswer.Location = new System.Drawing.Point(768, 110);
            this.txtWrongAnswer.Name = "txtWrongAnswer";
            this.txtWrongAnswer.Size = new System.Drawing.Size(60, 38);
            this.txtWrongAnswer.TabIndex = 13;
            this.txtWrongAnswer.Text = "   0";
            // 
            // pctrCorrectAnswer
            // 
            this.pctrCorrectAnswer.Image = ((System.Drawing.Image)(resources.GetObject("pctrCorrectAnswer.Image")));
            this.pctrCorrectAnswer.Location = new System.Drawing.Point(851, 102);
            this.pctrCorrectAnswer.Name = "pctrCorrectAnswer";
            this.pctrCorrectAnswer.Size = new System.Drawing.Size(113, 116);
            this.pctrCorrectAnswer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrCorrectAnswer.TabIndex = 14;
            this.pctrCorrectAnswer.TabStop = false;
            this.pctrCorrectAnswer.Visible = false;
            // 
            // pctrWrongAnswer
            // 
            this.pctrWrongAnswer.Image = ((System.Drawing.Image)(resources.GetObject("pctrWrongAnswer.Image")));
            this.pctrWrongAnswer.Location = new System.Drawing.Point(851, 102);
            this.pctrWrongAnswer.Name = "pctrWrongAnswer";
            this.pctrWrongAnswer.Size = new System.Drawing.Size(113, 116);
            this.pctrWrongAnswer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrWrongAnswer.TabIndex = 15;
            this.pctrWrongAnswer.TabStop = false;
            this.pctrWrongAnswer.Visible = false;
            // 
            // btnFinish
            // 
            this.btnFinish.BackColor = System.Drawing.Color.SkyBlue;
            this.btnFinish.Font = new System.Drawing.Font("Segoe Print", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFinish.Location = new System.Drawing.Point(-1, -1);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(990, 332);
            this.btnFinish.TabIndex = 16;
            this.btnFinish.Text = "Finished Contest";
            this.btnFinish.UseVisualStyleBackColor = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(987, 332);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.pctrWrongAnswer);
            this.Controls.Add(this.pctrCorrectAnswer);
            this.Controls.Add(this.txtWrongAnswer);
            this.Controls.Add(this.txtCorrectAnswer);
            this.Controls.Add(this.txtQuestionNumber);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblGivenAnswer);
            this.Controls.Add(this.lblCorrectAnswer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.richTextBox1);
            this.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Welcome to Knowledge Contest";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctrCorrectAnswer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrWrongAnswer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCorrectAnswer;
        private System.Windows.Forms.Label lblGivenAnswer;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtQuestionNumber;
        private System.Windows.Forms.TextBox txtCorrectAnswer;
        private System.Windows.Forms.TextBox txtWrongAnswer;
        private System.Windows.Forms.PictureBox pctrCorrectAnswer;
        private System.Windows.Forms.PictureBox pctrWrongAnswer;
        private System.Windows.Forms.Button btnFinish;
    }
}

