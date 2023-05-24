using TasKagitMakasApp.Models;

namespace TasKagitMakasApp
{
    public partial class Form1 : Form
    {

        El _el = new El();

        const string BILGISAYAR = "Bilgisayar";
        const string KULLANICI = "Kullanıcı";
        const string BERABERE = "Berabere";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListeleriDoldur();
        }

        void ListeleriDoldur()
        {
            /*Alt.1
            foreach (string hareket in _el.Hareketler)
            {
                ddlHareket.Items.Add(hareket);
            }
            */
            //Alt.2 - ddlHareket.Items.AddRange(_el.Hareketler);  
            ddlHareket.DataSource = _el.Hareketler;
            rbKagit.Text = _el.Hareketler[0];
            rbKagit.Checked = true;
            rbTas.Text = _el.Hareketler[1];
            rbMakas.Text = _el.Hareketler[2];

        }

        private void bBasla_Click(object sender, EventArgs e)
        {
            Basla();
        }
        
        void Basla()
        {
            string bilgisayarHareket = _el.HareketOlustur();
            //string kullaniciHareket = ddlHareket.SelectedValue.ToString();
            string kullaniciHareket = _el.Hareketler[0];
            if (rbTas.Checked) 
                kullaniciHareket = _el.Hareketler[1];
            else if (rbMakas.Checked) 
                kullaniciHareket = _el.Hareketler[2];
            
            lKazanan.Text = "Kullanıcı: " + kullaniciHareket + "\r\n"
                + "Bilgisayar: " + bilgisayarHareket + "\r\n\r\n"
                + "Kazanan: " +KazananiBul(bilgisayarHareket, kullaniciHareket);
            lKazanan.Visible = true;
        }

        private string KazananiBul(string bilgisayarHareket, string kullaniciHareket)
        {
            string kazanan;

            if (bilgisayarHareket == "Kağıt" && kullaniciHareket != "Kağıt")
            {
                if (kullaniciHareket == "Taş") kazanan = BILGISAYAR;
                else kazanan = KULLANICI;
            }
            else if (bilgisayarHareket == "Makas" && kullaniciHareket != "Makas")
            {
                if (kullaniciHareket == "Kağıt") kazanan = BILGISAYAR;
                else kazanan = KULLANICI;
            }
            else if (bilgisayarHareket == "Taş" && kullaniciHareket != "Taş")
            {
                if (kullaniciHareket == "Makas") kazanan = BILGISAYAR;
                else kazanan = KULLANICI;
            }
            else kazanan = BERABERE;

            return kazanan;

        }


        private void lKazanan_Click(object sender, EventArgs e)
        {

        }
    }
}