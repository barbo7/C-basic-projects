using System;
using System.Collections.Generic;

namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<T> class
            //System.Collections.Generic
            //T=> Object türündedir.
            List<int> sayiList = new List<int>();

            sayiList.Add(31);
            sayiList.Add(1);
            sayiList.Add(3);
            sayiList.Add(6);
            sayiList.Add(81);
            sayiList.Add(3310);

            List<string> renkler = new List<string>();

            renkler.Add("mavi");
            renkler.Add("yeşil");
            renkler.Add("kırmızı");
            renkler.Add("pembe");
            renkler.Add("mor");
            renkler.Add("turuncu");

            //Count ==> listedeki eleman sayısını verir.
            //foreach kullanarak listedeki verileri ekrana yazdırabiliriz. 2 kullanım var. foreach, ListForeach
            foreach (var sayi in sayiList)
                Console.WriteLine(sayi);
            foreach (var renk in renkler)
                Console.WriteLine(renk);

            sayiList.ForEach(sayi => Console.WriteLine(sayi));
            renkler.ForEach(renk => Console.WriteLine(renk));

            //Listeden eleman çıkartma.
            sayiList.Remove(1);   //Listeden eleman çıkartma
            sayiList.RemoveAt(1); //Listeden indekse göre eleman çıkartma.

            //Listede arama
            if (sayiList.Contains(31)) Console.WriteLine("Sayı listesi içerisinde var.");

            //Eleman ile indekse erişim
            Console.WriteLine(renkler.BinarySearch("kırmızı"));

            //Diziyi listeye çevirme
            string[] hayvanlar = { "kedi", "köpek", "kuş", "kaplan", "boğa" };
            List<String> hayvaanlar = new List<string>(hayvanlar);

            //Listeyi temizleme 
            hayvaanlar.Clear();

            //Liste içerisinde eleman tutma
            List<Kullanicilar>KullaniciListesi = new List<Kullanicilar>();

            Kullanicilar kullanıcı1 = new Kullanicilar();
            kullanıcı1.Isim = "Bora";
            kullanıcı1.Soyisim = "Sapancılar";
            kullanıcı1.Yas = 21;

            Kullanicilar kullanıcı2 = new Kullanicilar();
            kullanıcı2.Isim = "asdf";
            kullanıcı2.Soyisim = "fdsa";
            kullanıcı2.Yas = 31;

            KullaniciListesi.Add(kullanıcı1);
            KullaniciListesi.Add(kullanıcı2);

            List<Kullanicilar> yeniListe = new List<Kullanicilar>();

            yeniListe.Add(new Kullanicilar()
            {
                Isim = "Selin",
                Soyisim = "Benimm",
                Yas = 21
            });
            foreach (var i in KullaniciListesi)
            {
                Console.WriteLine("Kullanıcı adı: " + i.Isim);
                Console.WriteLine("Kullanıcı soyadı: " + i.Soyisim);
                Console.WriteLine("Kullanıcı yaşı: " + i.Yas);

            }
                




            Console.ReadKey();
        }
    }
    public class Kullanicilar
    {
        private string isim;
        private string soyisim;
        private int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }


    }
