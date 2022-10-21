using System;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sıralı olan verilerde, ardışık indexlerde çalışırken kurtarıcıdır.
            //Birden fazla sabit'e aynı anda ihtiyacımız varsa, kodun okunabilirliğini arttırmak için kullanıyoruz.

            Console.WriteLine(Gunler.Pazar);

            Console.WriteLine((int)Gunler.Cumartesi); //yazarsak Cumartesi günün'ün int değerini görürüz.
            
            int sicaklik = 28;
            if (sicaklik <= (int)HavaD.Normal)
                Console.WriteLine("Dışarıya çıkmak için Havanın biraz daha ısınmasını bekleyelim.");
            else if (sicaklik >= (int)HavaD.Coksicak)
                Console.WriteLine("Dışarıya çıkmak için sıcak bir gün");
            else if (sicaklik <= (int)HavaD.Sicak && sicaklik >= (int)HavaD.Normal) 
                Console.WriteLine("De haydin dışarı!!");

            Console.ReadKey();
        }
        enum Gunler
        {
            Pazartesi=1,
            Salı,
            Çarşamba,
            Perşembe,
            Cuma,  //=24 dersek cumartesi değeri 25 olur.
            Cumartesi,
            Pazar
        }
        enum HavaD
        {
            Soguk = -5,
            Normal = 20,
            Sicak = 30,
            Coksicak = 40
        }
    }
}
