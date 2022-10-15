using System;

namespace Metot_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            // out parameters
            string sayi = "999";
            int OutSayi;
           bool sonuc= int.TryParse(sayi, out  OutSayi);
            if(sonuc)
            {
                Console.WriteLine("Başarılı!");
                Console.WriteLine(OutSayi);
            }
            else
            {
                Console.WriteLine("Başarısız.");
            }

            Methods instance = new Methods();
            instance.Topla(4, 5, out int ToplamSonuc);
            Console.WriteLine(ToplamSonuc);

            //Method aşırı yükleme

            int ifade = 999;
            instance.EkranaYazdir(ifade.ToString());
            instance.EkranaYazdir(ifade);
            instance.EkranaYazdir("Bora", " Sapancılar");


            //Method imzası 
            //Method adı * parametresayısı * parametre
            //aşağıdaki voidlerde duruma göre işlem yapacak 
        }

    }
    class Methods
    {
        public void Topla(int a, int b, out int toplam)
        { toplam = a + b; }
        
        public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdir(string veri,string veri2)
        {
            Console.WriteLine(veri  + veri2);
        }

        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }



    }
}
