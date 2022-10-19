using System;
using System.Collections;
using System.Collections.Generic;

namespace ArrayLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Collections namespaces
            ArrayList list = new ArrayList();
           list.Add("Bora");
            list.Add(2);
            list.Add(true);
            list.Add('A');

            //İçersindeki verilere erişme
            Console.WriteLine(list[0]);
            foreach (var i in list)
                Console.WriteLine(i);

            //AddRange birden fazla elemanı toplu halde eklemek için kullanılır.
            Console.WriteLine("***Add Range***");
            string[] renkler = { "sarı", "mavi", "kırmızı", "mor", "lila" };

            //clear liste içindeki verileri temizler.
            list.Clear();

            List<int> sayılar = new List<int>() { 1, 3, 8, 17, 60, 71, 80 };
            //list.AddRange(renkler);
            list.AddRange(sayılar);
            foreach (var i in list)
                Console.WriteLine(i);

            //Sort
            //list.Sort(); yaparsak yazma ekranında sorun olmaz ama çalıştırırken türler değişken olduğu için hata verir.

            //Binary Search
            Console.WriteLine("***Binary Search***");
            Console.WriteLine(list.BinarySearch(80));

            //Reverse tam olarak ortasından aynalıyor.
            Console.WriteLine("**Reverse**");
            list.Reverse();
            foreach (var i in list)
                Console.WriteLine(i);

            Console.ReadKey();
        }
    }
}
