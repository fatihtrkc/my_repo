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

namespace Password_Generating_Game
{
    public partial class PasswordsForm : Form
    {
        public PasswordsForm()
        {
            InitializeComponent();
        }

        public ArrayList arry = new ArrayList();

        private void PasswordsForm_Load(object sender, EventArgs e)
        {
            lstPasswords.DataSource = arry;
        }

        int count = 0;
        private void timer_Tick(object sender, EventArgs e)
        {
            if (count % 6 == 0)
                lstPasswords.BackColor = Color.LightCoral;
            else if (count % 6 == 1)
                lstPasswords.BackColor = Color.LightSalmon;
            else if (count % 6 == 2)
                lstPasswords.BackColor = Color.LemonChiffon;
            else if (count % 6 == 3)
                lstPasswords.BackColor = Color.LimeGreen;
            else if (count % 6 == 4)
                lstPasswords.BackColor = Color.SkyBlue;
            else
                lstPasswords.BackColor = Color.Plum;

            count++;
        }
    }
}
