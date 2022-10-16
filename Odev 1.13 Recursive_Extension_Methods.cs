using System;

namespace Recursive_Extension_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rekürsif - öz yinelemeli
            //3^4
            int result = 1;
            for (int i = 1; i < 5; i++)
                result = result * 3;
            Console.WriteLine(result);
            Islemler instance = new Islemler();
            Console.WriteLine(instance.Expo(3, 4));

            //Extension Methods
            string ifade = "Bora Sapancılar";
            bool sonuc = ifade.CheckSpaces();
            Console.WriteLine(sonuc);
            if (sonuc)
                Console.WriteLine(ifade.Bosluk_silme());

            int[] sayilar = { 1, 32, 15, 12, 6, 7, 1, 2, 5, 4 };
            sayilar.Ekrana_Yazdir();

            int sayi = 41;
            Console.WriteLine(sayi.IsEvenNumber());

            ifade.ilk_Harf().Ekrana_Yazdir();

            Console.ReadKey();

        }
    }
    public class Islemler
    {
        public int Expo(int sayi,int us)
        {
            if (us < 2)
                return sayi;
            return Expo(sayi, us - 1) * sayi;
            /*
             *Expo(3,4);
             *Expo(3,3) *3;
             *Expo(3,2) *3 *3;
             *Expo(3,1) *3 *3 *3;
             * 3*3*3*3 = 3^4;
             */
        }
    }
    public static class Extension //Extension class ve methodlar statik olmalı eğer olmazsa bunları değiştiremeyiz.
    {
        public static bool CheckSpaces(this string param)//eklediğimiz this ifasdesi extension yapıyor.
        {
            return param.Contains(" ");
        }
        public static string Bosluk_silme(this string param)
        {
            string[] dizi = param.Split(' ');
            return string.Join("", dizi);
        }
        public static int[] Siralama(this int[] param)
        {
           Array.Sort(param);
            return param;
        }
        public static void Ekrana_Yazdir(this int[] param)
        {
            foreach (int i in param)
                Console.WriteLine(i);
        }
        public static void Ekrana_Yazdir(this string param)
        {
            Console.WriteLine(param);
        }
        public static bool IsEvenNumber(this int param)
        {
            return param % 2 == 0;
        }
        public static string ilk_Harf(this string param)
        {
            return param.Substring(0,1);
        }
    }
}
