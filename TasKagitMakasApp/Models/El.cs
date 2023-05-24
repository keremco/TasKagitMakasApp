namespace TasKagitMakasApp.Models
{
    class El
    {
        Random _rastgele = new Random();

        string[] _hareketler;
        public string[] Hareketler { get; } = new string[3]
        {
            "Taş", "Kağıt", "Makas"
        };

        public string HareketOlustur()
        {
            int rastgeleIndex= _rastgele.Next(0, 3);
            return Hareketler[rastgeleIndex];
        }

        
    }
}
