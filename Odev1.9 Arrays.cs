using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aynı tipteki verileri arka arkaya sıralamak istediğimizde dizileri kullanırız.
            string[] renker = new string[5];

            string[] hayvanlar = { "Kedi", "Köpek", "Fok balığı", "cart curt" };

            int[] dizi;
            dizi = new int[5];

            //Dizilere değer atama ve erişim.
            renker[0] = "Mavi";

            dizi[3] = 10;
            Console.WriteLine(hayvanlar[2]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renker[0]);

            //Döngülerle dizi kullanımı
            //Klavyeden grilen n tane sayının ortalamasını bulup yazdıran program.
            Console.WriteLine("Dizinin eleman sayısını girin: ");
            int dizi_uzunlugu= int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[dizi_uzunlugu];
           
            for(int i=0;i<dizi_uzunlugu;i++)
            {
                Console.Write("Lütfen {0}. sayıyı giriniz.", i + 1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }
            int toplam = 0;
            foreach(var item in sayiDizisi)
            {
                toplam += item;
            }
            Console.WriteLine("Ortalama: ", toplam / dizi_uzunlugu);
        }
    }
}
