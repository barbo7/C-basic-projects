using System;

namespace ConsoleApp48
{
    class Program
    {
        static void Main(string[] args)
        {

            Calisan calisan1 = new Calisan("Bora", "Sapancılar", 23425634, "Satın alma");
    
            calisan1.CalisanBilgileri();

            Console.WriteLine("***********");

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Selin";
            calisan2.Soyad = "Mengi";
            calisan2.No = 10000000;
            calisan2.Departman = "İnsan kaynakları";

            calisan2.CalisanBilgileri();

            Console.WriteLine("***********");
            Calisan calisan3 = new Calisan("deneme", "kişisi");

            calisan3.CalisanBilgileri();

            Console.ReadKey();
        }
    }
    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;
        //Constructor  (kurucu metotlar)
        //kurucu metotların adı class ismi ile aynı olmak zorunda ve erişim belirliyicleri public olmakzorudna.
        //Overload edilebilir.
        public Calisan(string ad,string soyad, int no, string departman)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;
        }

        public Calisan(){ }

        public Calisan(string ad, string soyad)
        {
            this.Ad = ad;
            this.Soyad = soyad;
        }
        public void CalisanBilgileri()       //Void kullandık çünkü geriye bir şey döndürmesine ihtiyacımız yok
        {
            Console.WriteLine("Çalışan Adı: {0}", Ad);
            Console.WriteLine("Çalışan Soyadı: {0}", Soyad);
            Console.WriteLine("Çalışan Numarası: {0}", No);
            Console.WriteLine("Çalışan Departmanı: {0}", Departman);
        }
    }
}
