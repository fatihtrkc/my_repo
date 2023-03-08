using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Knowledge_Competition
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;

            btnFinish.Enabled = false;
            btnFinish.Visible = false;
        }
        
        private void btnB_Click(object sender, EventArgs e)
        {
            lblGivenAnswer.Text = btnB.Text;

            if (lblCorrectAnswer.Text == lblGivenAnswer.Text)
            {
                correct_answer++;
                txtCorrectAnswer.Text = "   "+correct_answer.ToString();
                pctrCorrectAnswer.Visible = true;
                pctrWrongAnswer.Visible = false;
            }
            else
            {
                wrong_answer++;
                txtWrongAnswer.Text = "   "+wrong_answer.ToString();
                pctrWrongAnswer.Visible = true;
                pctrCorrectAnswer.Visible = false;
            }

            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;

            btnStart.Enabled = true;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            lblGivenAnswer.Text = btnC.Text;

            if (lblCorrectAnswer.Text == lblGivenAnswer.Text)
            {
                correct_answer++;
                txtCorrectAnswer.Text ="   "+ correct_answer.ToString();
                pctrCorrectAnswer.Visible = true;
                pctrWrongAnswer.Visible = false;
            }
            else
            {
                wrong_answer++;
                txtWrongAnswer.Text = "   "+wrong_answer.ToString();
                pctrWrongAnswer.Visible = true;
                pctrCorrectAnswer.Visible = false;
            }

            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;

            btnStart.Enabled = true;
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            lblGivenAnswer.Text = btnD.Text;

            if (lblCorrectAnswer.Text == lblGivenAnswer.Text)
            {
                correct_answer++;
                txtCorrectAnswer.Text = "   "+correct_answer.ToString();
                pctrCorrectAnswer.Visible = true;
                pctrWrongAnswer.Visible = false;
            }
            else
            {
                wrong_answer++;
                txtWrongAnswer.Text = "   "+wrong_answer.ToString();
                pctrWrongAnswer.Visible = true;
                pctrCorrectAnswer.Visible = false;
            }

            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;

            btnStart.Enabled = true;
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            btnFinish.Enabled = false;
            btnFinish.Visible = false;

            pctrCorrectAnswer.Visible = false;
            pctrWrongAnswer.Visible = false;

            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;

            btnStart.Enabled = true;
            btnStart.Text = "First Questions";

            question_number = 0;

            txtQuestionNumber.Text = "   "+question_number.ToString();
            txtCorrectAnswer.Text = "   0";
            txtWrongAnswer.Text = "   0";

            richTextBox1.Text = "                                    Welcome!!!\n         This is UpsUniversity Knowledge Contest in Istanbul\n                 The competition contains 5 questions\n                             Good Luck Everybody";
            btnA.Text = "A";
            btnB.Text = "B";
            btnC.Text = "C";
            btnD.Text = "D";

        }

        private void btnA_Click(object sender, EventArgs e)
        {
            lblGivenAnswer.Text = btnA.Text;

            if (lblCorrectAnswer.Text == lblGivenAnswer.Text)
            {
                correct_answer++;
                txtCorrectAnswer.Text = "   "+correct_answer.ToString();
                pctrCorrectAnswer.Visible = true;
                pctrWrongAnswer.Visible = false;
            }
            else
            {
                wrong_answer++;
                txtWrongAnswer.Text = "   "+wrong_answer.ToString();
                pctrWrongAnswer.Visible = true;
                pctrCorrectAnswer.Visible = false;
            }

            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;

            btnStart.Enabled = true;
        }

        int question_number = 0, correct_answer = 0, wrong_answer = 0;
        private void btnStart_Click(object sender, EventArgs e)
        {
            question_number++;

            txtQuestionNumber.Text = "   "+question_number.ToString();

            pctrCorrectAnswer.Visible = false;
            pctrWrongAnswer.Visible = false;
            
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;

            btnStart.Enabled = false;

            if (question_number == 1)
            {
                richTextBox1.Text = "  \n\n                Which team won the UEFA Cup in 2000?";
                btnA.Text = "Real Madrid";
                btnB.Text = "Galatasaray";
                btnC.Text = "Arsenal";
                btnD.Text = "Borussia Dortmund";
                lblCorrectAnswer.Text = "Galatasaray";

                btnStart.Text = "Next Question";
            }

            if (question_number == 2)
            {
                richTextBox1.Text = "  \n\n               Which is the first Millennium Cup winner team?";
                btnA.Text = "Bayern Munich";
                btnB.Text = "Liverpool";
                btnC.Text = "Barcelona";
                btnD.Text = "Galatasaray";
                lblCorrectAnswer.Text = "Galatasaray";
            }

            if (question_number == 3)
            {
                richTextBox1.Text = "  \n\n         Which is the first team won UEFA Cup undefeatedly?";
                btnA.Text = "Galatasaray";
                btnB.Text = "Feyenoord";
                btnC.Text = "Sevilla";
                btnD.Text = "Atlético de Madrid";
                lblCorrectAnswer.Text = "Galatasaray";
            }

            if (question_number == 4)
            {
                richTextBox1.Text = "  \n\n          Who is the first coach won UEFA Cup undefeatedly?";
                btnA.Text = "Unai Emery";
                btnB.Text = "Fatih Terim";
                btnC.Text = "Diego Simeone";
                btnD.Text = "Arsene Wenger";
                lblCorrectAnswer.Text = "Fatih Terim";

                btnStart.Text = "Last Questions";
            }

            if (question_number == 5)
            {
                richTextBox1.Text = "  \n    What is the most successful football team in the world in August 2000 according to International Football History and Statistics Federation's(IFFHS) assessment?";
                btnA.Text = "Galatasaray";
                btnB.Text = "Barcelona";
                btnC.Text = "Real Madrid";
                btnD.Text = "Bayern Munich";
                lblCorrectAnswer.Text = "Galatasaray";

                btnStart.Text = "Finish Contest";
            }

            if (question_number == 6)
            {
                btnFinish.Enabled = true;
                btnFinish.Visible = true;

                btnFinish.Text = "Finished Competition\nThanks a lot to Attended";
            }
        }
    }
}
