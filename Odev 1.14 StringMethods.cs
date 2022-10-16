using System;

namespace StringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz CSharp Hoşgeldiniz!";
            string degisken2 = "Dersimiz CSharp";


            //Length metin'in uzunluğunu verir
            Console.WriteLine(degisken.Length);

            //ToUpper , ToLower METİNDEKİ TÜM HARFLERİ BÜYÜTÜR veya küçültebiliriss.
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            //Concat metin vs. birleştirme işleminde kullanılıyor.
            Console.WriteLine(String.Concat(degisken," Meraba"));

            //Compare , CompareTo veri karşılatşırmak istersek kullanıyoruz
            Console.WriteLine(degisken.CompareTo(degisken2)); //1. değişken 2.değişkene eşit olursa 0 döndürür. 1.degisken>2.degisken ise 1 değilse -1 döndürür.
            Console.WriteLine(String.Compare(degisken,degisken2,true));//true dersek büyük küçük harf duyarsız olur, false dersek tam tersi.

            //Contains degisken1 in içinde degisken 2 var mı
            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.StartsWith("Dersimiz"));
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz!"));

            //IndexOf
            Console.WriteLine(degisken.IndexOf("CSharp")); //ilk indis'in index'ini verecek. bir şey bulamazsa -1 döner.
            Console.WriteLine(degisken.LastIndexOf("i")); //indisleri sondan arıyarak bulur


            //Insert 
            Console.WriteLine(degisken.Insert(0, "mERHABA")); //0. indexten başlıyarak veri eklememize olanak sağlar.

            Console.WriteLine("***");
            //PadLeft , PadRight cart curt sikko  boşluk ekleme ya da degisken ekleme 
           
            Console.WriteLine(degisken + degisken2.PadLeft(30));
            Console.WriteLine(degisken + degisken2.PadLeft(30, '*'));
            Console.WriteLine(degisken.PadRight(50) + degisken2);
            Console.WriteLine(degisken.PadRight(50, '*') + degisken2);
            
            //Remove
            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(5,3));

            //Replace
            Console.WriteLine(degisken.Replace("CSharp", "C#"));
            Console.WriteLine(degisken.Replace(" ", "*"));

            //Split
            Console.WriteLine(degisken.Split(' ')); //degisken adlı string veriyi boşluğa göre parçaladı ve Listeye aktardı.
            Console.WriteLine(degisken.Split(' ')[1]);//degisken adlı string veriyi boşluğa göre parçaladı ve 1. indexi getirdi.

            //Substring
            Console.WriteLine(degisken.Substring(4, 6));//4.indexten başlayıp 6 karakter getirir.
            Console.ReadKey();

        }
    }
}
