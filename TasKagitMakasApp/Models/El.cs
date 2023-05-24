namespace TasKagitMakasApp.Models
{
    class El
    {
        Random _rastgele = new Random();

        public string[] Hareketler { get; } = new string[3]
        {
            "Kağıt", "Taş", "Makas"
        };

        public string HareketOlustur()
        {
            int rastgeleIndex= _rastgele.Next(0, 3);
            return Hareketler[rastgeleIndex];
        }

        
    }
}
