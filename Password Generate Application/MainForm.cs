namespace Password_Generating_Game
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        bool boolUpper = false, boolLower = false, boolNumber = false, boolSpecial = false;

        private void btnPsswrdGnrt_Click(object sender, EventArgs e)
        {
            chrctrCount = int.Parse(nmrPsswrdCount.Value.ToString());

            if ((boolUpper || boolLower || boolNumber || boolSpecial))
            {
                PasswordGeneratingForm frm = new PasswordGeneratingForm();
                frm.GetInfo(boolUpper, boolLower, boolNumber, boolSpecial, chrctrCount);
                frm.ShowDialog();
            }
            else
            {
                btnPsswrdGnrt.Enabled = false;
                MessageBox.Show("   You must select min one option !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        int chrctrCount = 0;
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (boolUpper || boolLower || boolNumber || boolSpecial)
                btnPsswrdGnrt.Enabled = true;
            else MessageBox.Show("   You must select min one option !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            chrctrCount = int.Parse(nmrPsswrdCount.Value.ToString());
        }

        private void chckUpper_CheckedChanged(object sender, EventArgs e)
        {
            if (chckUpper.Checked) boolUpper = true;
            else boolUpper = false;
        }

        private void chckLower_CheckedChanged(object sender, EventArgs e)
        {
            if (chckLower.Checked) boolLower = true;
            else boolLower = false;
        }

        private void chckNumber_CheckedChanged(object sender, EventArgs e)
        {
            if (chckNumber.Checked) boolNumber = true;
            else boolNumber = false;
        }

        private void chckSpecial_CheckedChanged(object sender, EventArgs e)
        {
            if (chckSpecial.Checked) boolSpecial = true;
            else boolSpecial = false;
        }
    }
}