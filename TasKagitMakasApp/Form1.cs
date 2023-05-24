using TasKagitMakasApp.Models;

namespace TasKagitMakasApp
{
    public partial class Form1 : Form
    {

        El _el = new El();
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
            foreach (string hareket in _el.Hareketler)
            {
                ddlHareket.Items.Add(hareket);
            }
            //Alt.1 - dllHareket.Items.AddRange(_el.Hareketler);  
            //Alt.2 - dllHareket.DataSource = _el.Hareketler;
        }

        private void bBasla_Click(object sender, EventArgs e)
        {
            Basla();
        }

        void Basla()
        {
            string hareket = _el.HareketOlustur();
            MessageBox.Show(hareket);
        }
    }
}