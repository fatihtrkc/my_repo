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
            MessageBox.Show(@$"     Sayý Tahmin Oyununa Hoþgeldiniz !
     Oyun {prgbarDurum.Maximum} saniye içerisinde sona erecektir.
     Her sayý girdikten ve Tahmin Et butonuna basdýktan sonra sizi bilgilendireceðiz.", "Oyunda Baþarýlar !", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                metin = "Girilen sayýdan büyük !";
            else if (sayi > rnd_sayi)
                metin = "Girilen sayýdan küçük !";
            else metin = "Tebrikler Kazandýnýz !";

            return metin;
        }

        private void btnTahminEt_Click(object sender, EventArgs e)
        {
            metin = SayiDurum();
            lblSayiDurum.Text = metin;

            if (metin == "Tebrikler Kazandýnýz !")
            {
                lblSayiSonuc.Text = "Tebrikler Kazandýnýz !";
                BaslangicAyar(false);
                MessageBox.Show($"{prgbarDurum.Maximum - prgbarDurum.Value} saniyede sistem tarafýndan rastgele seçilen sayýyý ({rnd_sayi}) doðru tahmin ettiniz !", "Tebrikler !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nmrSayi.Value = 0;
            }
        }

        string[] ifadeler = { "Beceriksiz !!!", "Senden hiçbir þey olmaz !!!", "Yapamayacaksýýýnn !!!", "Býraksana yaa...", "Çok ama çook kötüsün !!!" };
        int counter = 0; int value;

        private void timer_Tick(object sender, EventArgs e)
        {
            counter++;
            value = prgbarDurum.Maximum - counter;
            btnTahminEt.Text = $"Tahmin Et ({value}s)";
            prgbarDurum.Value = value;
            lblPercent.Text = $"Kalan Süre :  {prgbarDurum.Value}s";

            lblSayiSonuc.Text = ifadeler[rnd.Next(0, ifadeler.Length)];

            if (value <= 10 && value % 2 == 0)
                lblPercent.BackColor = Color.Red;
            else lblPercent.BackColor = Color.LimeGreen;

            if (value == 0)
            {
                BaslangicAyar(false);
                lblSayiDurum.Text = "Kaybettiniz...";
                lblSayiSonuc.Text = "Kaybettiniz...";
                MessageBox.Show($"Malesef sistem tarafýndan rastgele seçilen sayýyý ({rnd_sayi}) doðru tahmin edemediniz !", "Lütfen Tekrar Deneyiniz !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nmrSayi.Value = 0;
                counter = 0;
            }
        }
    }
}