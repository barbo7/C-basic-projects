using System;

namespace ClassVsStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            //class'lar referance tipinde değişkenler ve value tipinde değer tipleri olur genellikle.
            //referance'lar belleğin heap? bölgesinde tutulurken value tipindeki değişkenler stack'de tutulurlar.
            //structlar da değer tipindedir yani value.

            dikdortgen sınıf = new dikdortgen();
            //bir class'ın nesnesini oluşturduğumuz zaman nesnelerin valueleri olmasa bile ben AlanHesapla() özelliğini
            //Çağırabilir ve kullanabilirim. Bu durumda default değer atar ve int ise =0;string ise =null;bool = false; şeklinde atama yapar.

            sınıf.KisaKenar = 3; 
            sınıf.UzunKenar = 4;
            Console.WriteLine("Class alan hesabı = " + sınıf.AlanHesapla());
            Console.WriteLine("-----");

            dikdortgenStruct structt; //New ile yaratmaya gerek yok. Bu şekilde kullandığımızda default değer atayamıyor.
            structt.KisaKenar = 6;
            structt.UzunKenar = 8;

            Console.WriteLine("Struct alan hesabı = " + structt.AlanHesapla());
            Console.WriteLine("-----");
            // 16byte'a kadar olan verilerde struct, 16byte üzerinde olucak verilerde class kullanmamız uygun olan.
            
            dikdortgenStruct deneme = new dikdortgenStruct(6, 8);
            Console.WriteLine("Struct alan hesabı = "+deneme.AlanHesapla());

            Console.ReadKey();
        }


        class dikdortgen
        {
            public int KisaKenar;
            public int UzunKenar;

            public dikdortgen()         
            {
                KisaKenar = 3;
                UzunKenar = 4;      //Şeklinde değer atayabilioruz class'a 
            }

            public long AlanHesapla()
            {
                return this.KisaKenar * this.UzunKenar;
            }
        }
        struct dikdortgenStruct
        {
            public int KisaKenar;
            public int UzunKenar;

            public dikdortgenStruct(int kisaKenar,int uzunKenar)
            {
                UzunKenar = uzunKenar;
                KisaKenar = kisaKenar; //Şeklinde parametreleri tanımlamamız gerekiyor.

            }

            public long AlanHesapla()
            {
                return this.KisaKenar * this.UzunKenar;
            }

        }
    }
}
