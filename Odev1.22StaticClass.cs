using System;


namespace ConsoleApp51
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Çalışan sayısı : {0}", Calisan.CalisanSayisi);

            Calisan calisan1 = new Calisan("Bora","Sapancılar","Yazılım");

            Console.WriteLine("Çalışan sayısı : {0}", Calisan.CalisanSayisi);

            Console.WriteLine("Toplama işlemi sonucu = {0}", Islemler.Toplam(144, 256));
            Console.WriteLine("Çıkarma işlemi sonucu = {0}", Islemler.Çıkar(144, 256));



        }
    }
    class Calisan
    {
        private static int calisanSayisi;
        // static olmayan elemanlar o sınıf içerisinde nesneye özgüyken
        // Bir sınıf içerisinde static olan üyeler sınıfa yönelik atanır.
        public static int CalisanSayisi { get => calisanSayisi;}

        private string isim;
        private string soyisim;
        private string departman;

        
        static Calisan() //static kurucuların erişim belirteci olmaz.
        {
            calisanSayisi = 0;

        }
    

        public Calisan(string isim, string soyisim, string departman)
        {
            this.isim = isim;
            this.soyisim = soyisim;
            this.departman = departman;
            calisanSayisi++;
        }
    }
    static class Islemler
    {
       public static long Toplam(int s1,int s2)
           {
            return s1 + s2;
           }
        public static long Çıkar(int s1, int s2)
        {
            return s1 - s2;
        }
    }
}
