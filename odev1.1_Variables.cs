using System;

namespace variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //string kelime  = null;
            string kelime = "Bora";
            Console.WriteLine(kelime);

            //         --- Veri Tipleri ----
            byte b = 5; //0-255 arası 1byte
            sbyte sb = 5; //-128 - +127 arası 1byte
            short s = 5; //-32.000 - +32.000 arası ve 2 byte
            ushort us = 5; //0-65365 2byte

            Int16 i16 = 3; //2byte
            int i = 3; //4byte
            Int32 i32 = 3; //4byte
            Int64 i63 = 3; //8byte
            uint ui = 3; //4byte
            long l = 3; //8byte
            ulong ul = 3; //8byte
            
            float f = 3; //4byte
            double d = 5.4; //8byte

            char c = 'a'; //2byte
            string str = "Bora";

            bool bl = false;

            DateTime dt = DateTime.Now; //Anlık saat ve tarih verir.
            Console.WriteLine(dt);

            // Object yani nesne bütün herşeyi tutabilir. -char -string -int -decimal

            object o1 = "x"; //string
            object o2 = 'y'; //char
            object o3 = 4.5; //decimal
            object o4 = 6;   //integer

            string str1 = string.Empty;
            string str2 = null;
            string str3;

            string strName = "Bora Sapancılar";
            string name = "Bora";
            string surname = "Sapancılar";
            string fullname = name + " " + surname;

            Console.WriteLine(strName);
            Console.WriteLine(fullname);

            //Bool ==> True yada False değer alır. Genelde kıyaslama işlemlerinde kullanılır.

            bool b1 = 10 > 2;//True değer döndürür.

            /*
             *-- Değişken Dönüşümleri -- 
            str => int
            --------------------------------
             1 - int.Parse("16") 
             2 - Convert.ToInt32(StrYeDönüştürülecekNesne);
             */

            string str20 = "20";
            int int20 = 20;
            string str4 = str20 + int20.ToString();  // String cinsinde toplama yapılır. String'te toplama yanyana yazmak anlamına gelir.

            Console.WriteLine(str4);  //2020 Olacak çıktı.


            /*
             int => str 
             -------------------------------
             1 - .ToString() 
             2 - Convert.ToString(StrYeDönüştürülecekNesne);
             */

            int int3 = int20 + Convert.ToInt32(str20);  //Burada int20 zaten integer ve diğer str20 değeride int çevrildiğinden dolayı iki integer değerin toplamı anlamına gelir. 

            Console.WriteLine(int3);  //Çıktı: 40 

            int int4 = int20 + int.Parse(str20);  //Çıktı: 40

            Console.WriteLine(int4);

            string datetime1 = DateTime.Now.ToString("dd.MM.yyyy");  //Şu anki zaman string veritipinde gün.ay.yıl olarak gelir. (11.10.2022)
            Console.WriteLine(datetime1);

            string hour = DateTime.Now.ToString("HH.mm");  //Şu anki saati bize verir. (ör. 15.32)
            Console.WriteLine(hour);

            Console.ReadLine();  // External Terminali Açık Tutmak İçin Kullanılır.
        }
    }
}
