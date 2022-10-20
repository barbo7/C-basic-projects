using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci1 = new Ogrenci("Bora", "Sapancılar", 31, 2);
            ogrenci1.OgrenciBilgiler();

            Ogrenci ogrenci2 = new Ogrenci("İbrahim","Aydın",02,2);
            ogrenci2.SinifDusur(); 
            ogrenci2.OgrenciBilgiler();

            Ogrenci ogrenci3 = new Ogrenci();
            ogrenci3.Isim = "Deneme";
            ogrenci3.Soyisim = "Kişisi";
            ogrenci3.Ogrenci_no = 13589643;
            ogrenci3.Sinif = 1;

            ogrenci3.OgrenciBilgiler();
            ogrenci3.SinifDusur();
            ogrenci3.OgrenciBilgiler();

            Console.ReadKey();
        }
    }
    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int ogrenci_no;
        private int sinif;

        public string Isim { get => isim; set => isim = value; } //bir tane property açtık ve get'de ismi return ediyor. set'de isim'e value atıyor.
        //public string Isim 
        //{ get { return isim;  }
        //  set { isim = value; }
        //}                        // şeklinde de kullanılabilir.
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Ogrenci_no { get => ogrenci_no; set => ogrenci_no = value; }//Eğer burda bir set olmasaydı biz bu property'e değer atayamazdık.
        public int Sinif {
            get => sinif;
            set {
                if(value<1)
                { Console.WriteLine("Sınıf en az 1 olabilir."); sinif = 1; }
                else sinif = value;
            }
        }

        public Ogrenci() { }

        public Ogrenci(string ad,string soyad,int ogrenci_no,int sinif)
        {
            this.Isim = ad;
            this.Soyisim = soyad;
            this.Ogrenci_no = ogrenci_no;
            this.Sinif = sinif;
        }

        public void OgrenciBilgiler()
        {
            Console.WriteLine("****** Öğrenci Bilgileri ******");
            Console.WriteLine("Öğrenci adı          :{0}", this.Isim);
            Console.WriteLine("Öğrenci Soyadı       :{0}", this.Soyisim);
            Console.WriteLine("Öğrenci numarası     :{0}", this.Ogrenci_no);
            Console.WriteLine("Öğrenci sınıfı       :{0}", this.Sinif);
        }
        public void SinifAtlat()
        {
            this.Sinif = Sinif + 1;
        }
        public void SinifDusur()
        {
            this.Sinif = Sinif - 1;
        }
    }

    
}
