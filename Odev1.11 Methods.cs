using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //erişim belirtici geri_donuştipi method(parametreListesi/arguman)
            //{
            //komutlar
            //}

            int a = 2, b = 3;
            Console.WriteLine(b + a);

            int sonuc = Topla(a, b);
            Console.WriteLine(sonuc);

            Methods ornek = new Methods(); //method class'ına erişim sağlamak için kullanıyoruz.

            int sonuc2 = ornek.ArttirVeTopla(ref a,ref b); //global değişiklik için ref kullanıyoruz.
            ornek.EkranaYazdir(sonuc.ToString()); //method'daki void'in işlemini yapmak için kullanacağız.
            ornek.EkranaYazdir(sonuc2.ToString());


        }
        static int Topla(int deger1,int deger2)
        {
            return (deger1 + deger2);
        }
    }
    class Methods
    {
        public void EkranaYazdir(string veri) //default olarak private erişilebilir olması için public yazmamız lazm
        { Console.WriteLine(veri); }

        public int ArttirVeTopla(ref int deger1,ref int deger2)
        {
            deger1 += 1;
            deger2 += 2;
            return deger2+deger1;
        }
    }
}
