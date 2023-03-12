using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Password_Generating_Game
{
    public partial class PasswordGeneratingForm : Form
    {
        public PasswordGeneratingForm()
        {
            InitializeComponent();
        }

        void SelectProperties()
        {
            MainForm frm = new MainForm();
            frm.Show();
            this.Hide();
        }
        //Back to Form1
        private void btnShow_Click(object sender, EventArgs e)
        {
            SelectProperties();
        }

        //Get Info from Form1
        public void GetInfo(bool upperCase, bool lowerCase, bool numberCharacter, bool specialCharacter, int characterCount)
        {
            boolupper = upperCase; boollower = lowerCase; boolnumber = numberCharacter; boolspecial = specialCharacter;
            intCharacter = characterCount;
        }


        bool boolupper, boollower, boolnumber, boolspecial;
        int intCharacter;

        char UpperCase()
        {
            int chrctrvalue = rnd.Next((int)'A', ((int)'Z' + 1));

            return (char)chrctrvalue;
        }
        char LowerCase()
        {
            int chrctr_value = rnd.Next((int)'a', ((int)'z' + 1));

            return (char)chrctr_value;
        }
        int NumberCharacter()
        {
            int chrctr_value = rnd.Next(0, 10);

            return chrctr_value;
        }
        char SpecialCharacter()
        {
            //With List<> Using
            //List<int> special = new List<int>();
            //for (int i = (int)'!'; i <= (int)'/'; i++) special.Add(i);

            //for (int i = (int)':'; i <= (int)'@'; i++) special.Add(i);

            //for (int i = (int)'['; i <= (int)((char)96); i++) special.Add(i);

            //for (int i = (int)'{'; i <= (int)((char)127); i++) special.Add(i);

            //int chrctr_value = special[rnd.Next(0, special.Count + 1)];

            //With ArrayList Using
            ArrayList special = new ArrayList();
            for (int i = (int)'!'; i <= (int)'/'; i++) special.Add(i);

            for (int i = (int)':'; i <= (int)'@'; i++) special.Add(i);

            for (int i = (int)'['; i <= (int)((char)96); i++) special.Add(i);

            for (int i = (int)'{'; i <= (int)((char)127); i++) special.Add(i);

            int chrctr_value = (int)(special[rnd.Next(0, special.Count)]);

            return (char)chrctr_value;
        }

        Random rnd = new Random();

        //Random Password Creation
        string Password()
        {
            string stringPsswrd = "";
            int count = intCharacter;

            do
            {
                if (count == 0) break;
                if (boolupper && count > 0)
                {
                    stringPsswrd += UpperCase();
                    count--;
                }
                if (boollower && count > 0)
                {
                    stringPsswrd += LowerCase();
                    count--;
                }
                if (boolnumber && count > 0)
                {
                    stringPsswrd += NumberCharacter();
                    count--;
                }
                if (boolspecial && count > 0)
                {
                    stringPsswrd += SpecialCharacter();
                    count--;
                }
            } while (true);

            return stringPsswrd;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int value = int.Parse(nmrPsswrdCount.Value.ToString());

            for (int i = 0; i < value; i++)
            {
                string crt_psswrd = Password();
                PasswordSave(crt_psswrd);
            }
            //Passwords Sender to PasswordsForm
            PasswordsForm frm = new PasswordsForm();
            frm.arry = arry_rndpsswrd;
            frm.ShowDialog();
        }

        ArrayList arry_rndpsswrd = new ArrayList();
        int count = 1;
        void PasswordSave(string str_psswrd)
        {
            if (count / 10 == 0)
                arry_rndpsswrd.Add($"0{count}-)          {str_psswrd}");
            else
                arry_rndpsswrd.Add($"{count}-)          {str_psswrd}");

            count++;
        }
    }
}
