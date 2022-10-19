using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //system.Collections.generic
            Dictionary<int, string> kullanıcılar = new Dictionary<int, string>(); //key integer olsun valuesi de string olsun dedik.

            kullanıcılar.Add(10, "Bora");
            kullanıcılar.Add(11, "Selin");
            kullanıcılar.Add(1, "Halil");
            kullanıcılar.Add(2, "Aytaç");

            //Dizinin elemanlarına erişim==>
            Console.WriteLine("****Elemanlara Erişim****");
            Console.WriteLine(kullanıcılar[10]);

            foreach (var i in kullanıcılar)
                Console.WriteLine(i);

            //Count:>>
            Console.WriteLine(kullanıcılar.Count());

            //Contains
            Console.WriteLine(kullanıcılar.ContainsKey(10));
            Console.WriteLine(kullanıcılar.ContainsValue("Selin"));

            //remove
            kullanıcılar.Remove(2);
            foreach (var i in kullanıcılar)
                Console.WriteLine(i.Value); //veya Console.WriteLine(i.Key);
            //Keys
            Console.WriteLine("**Keys**");
            foreach (var item in kullanıcılar.Keys)
                Console.WriteLine(item);


            //Values
            Console.WriteLine("**Values**");
            foreach (var item in kullanıcılar.Values)
                Console.WriteLine(item);

        }
    }
}
