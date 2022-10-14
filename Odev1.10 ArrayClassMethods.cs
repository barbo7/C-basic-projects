using System;

namespace ArrayClassMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] SayiDizisi = { 23, 15, 66, 47, 12, 9, 88 };
            foreach (var sayi in SayiDizisi)
                Console.WriteLine(sayi);

            //Sort (Sıralama)

            Console.WriteLine("***Array Sort***");

            Array.Sort(SayiDizisi);

            foreach (var sayi in SayiDizisi)
                Console.WriteLine(sayi);
            //Clear (Dizideki istediğimiz elemandan istediğimiz elemana kadar silmek için kullanılır.

            Array.Clear(SayiDizisi, 2, 2); //2.indiks'ten itibaren 2 eleman sıfırlar.
            Console.WriteLine("***Array Clear***");

            foreach (var sayi in SayiDizisi)
                Console.WriteLine(sayi);

            //Reverse

            Console.WriteLine("***Array Reverse***");
            Array.Reverse(SayiDizisi);

            foreach (var sayi in SayiDizisi)
                Console.WriteLine(sayi);

            //IndexOf (Dizi veya listede aradığımız veri'nin hangi indekste olduğunu bize gösterir.)

            Console.WriteLine("***Array IndexOf***");
            Console.WriteLine(Array.IndexOf(SayiDizisi, 23));

            //Resize (Dizimizin boyutunu yani eleman sayısını değşitirmemize yarıyor.)

            Console.WriteLine("***Array Resize***");
            Array.Resize<int>(ref SayiDizisi, 9);
            SayiDizisi[9] = 11;
        }
    }
}
