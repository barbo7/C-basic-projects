using System;

namespace Erşim_belirleyiciler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Söz dizimi
            //class SinifAdi
            //{
            //      [Erişim Belirleyici] [Veri Tipi] OzellikAdi;
            //      [Erişim Belirleyici] [Geri Dönüş Tipi] MetotAdi([Parametre Listesi]);
            //      {
            //       Metot Komutları
            //      }
            //}

            /*Erişim belirleyiciler 
             * Public       (Herhangi bir yerden erişilebilen kodlar için kullanılır.)
             * Private      (Sadece tanımlandığı class'ta erişim olmasını istediğimiz kodlar için kullanılır.)
             * Internal     (Sadece kendi bulunuğu proje içerisinde erişim olmasını istediğimizde kullanılır.)  
             * Protected    (Sadece tanımlandığı sınıfta veya O sınıftan kalıtım alan diğer sınıflarda kullanılabilir.)
             */
            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Bora";
            calisan1.Soyad = "Sapancılar";
            calisan1.No = 23425634;
            calisan1.Departman = "Satın alma";

            calisan1.CalisanBilgileri();

            Console.WriteLine("***********");

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Selin";
            calisan2.Soyad = "Mengi";
            calisan2.No = 10000000;
            calisan2.Departman = "İnsan kaynakları";

            calisan2.CalisanBilgileri();
            Console.ReadKey();
        }
    }
    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;
        public void CalisanBilgileri()       //Void kullandık çünkü geriye bir şey döndürmesine ihtiyacımız yok
        {
            Console.WriteLine("Çalışan Adı: {0}", Ad);
            Console.WriteLine("Çalışan Soyadı: {0}", Soyad);
            Console.WriteLine("Çalışan Numarası: {0}", No);
            Console.WriteLine("Çalışan Departmanı: {0}", Departman);
        }
    }
}
