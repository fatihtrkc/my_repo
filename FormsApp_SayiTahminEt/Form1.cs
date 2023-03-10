namespace FormsApp_SayiTahminEt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show(@$"     Say� Tahmin Oyununa Ho�geldiniz !
     Oyun {prgbarDurum.Maximum} saniye i�erisinde sona erecektir.
     Her say� girdikten ve Tahmin Et butonuna basd�ktan sonra sizi bilgilendirece�iz.", "Oyunda Ba�ar�lar !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void BaslangicAyar(bool durum)
        {
            if (durum)
                timer.Start();
            else
                timer.Stop();

            btnOyunBaslat.Enabled = !durum;
            nmrSayi.Enabled = durum;
            btnTahminEt.Enabled = durum;
            timer.Enabled = durum;
        }

        Random rnd = new Random();
        int rnd_sayi;
        private void btnOyunBaslat_Click(object sender, EventArgs e)
        {
            rnd_sayi = rnd.Next(0, 100);
            BaslangicAyar(true);
        }

        int sayi;
        string metin;
        string SayiDurum()
        {
            sayi = int.Parse(nmrSayi.Value.ToString());

            if (sayi < rnd_sayi)
                metin = "Girilen say�dan b�y�k !";
            else if (sayi > rnd_sayi)
                metin = "Girilen say�dan k���k !";
            else metin = "Tebrikler Kazand�n�z !";

            return metin;
        }

        private void btnTahminEt_Click(object sender, EventArgs e)
        {
            metin = SayiDurum();
            lblSayiDurum.Text = metin;

            if (metin == "Tebrikler Kazand�n�z !")
            {
                lblSayiSonuc.Text = "Tebrikler Kazand�n�z !";
                BaslangicAyar(false);
                MessageBox.Show($"{prgbarDurum.Maximum - prgbarDurum.Value} saniyede sistem taraf�ndan rastgele se�ilen say�y� ({rnd_sayi}) do�ru tahmin ettiniz !", "Tebrikler !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nmrSayi.Value = 0;
            }
        }

        string[] ifadeler = { "Beceriksiz !!!", "Senden hi�bir �ey olmaz !!!", "Yapamayacaks���nn !!!", "B�raksana yaa...", "�ok ama �ook k�t�s�n !!!" };
        int counter = 0; int value;

        private void timer_Tick(object sender, EventArgs e)
        {
            counter++;
            value = prgbarDurum.Maximum - counter;
            btnTahminEt.Text = $"Tahmin Et ({value}s)";
            prgbarDurum.Value = value;
            lblPercent.Text = $"Kalan S�re :  {prgbarDurum.Value}s";

            lblSayiSonuc.Text = ifadeler[rnd.Next(0, ifadeler.Length)];

            if (value <= 10 && value % 2 == 0)
                lblPercent.BackColor = Color.Red;
            else lblPercent.BackColor = Color.LimeGreen;

            if (value == 0)
            {
                BaslangicAyar(false);
                lblSayiDurum.Text = "Kaybettiniz...";
                lblSayiSonuc.Text = "Kaybettiniz...";
                MessageBox.Show($"Malesef sistem taraf�ndan rastgele se�ilen say�y� ({rnd_sayi}) do�ru tahmin edemediniz !", "L�tfen Tekrar Deneyiniz !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nmrSayi.Value = 0;
                counter = 0;
            }
        }
    }
}