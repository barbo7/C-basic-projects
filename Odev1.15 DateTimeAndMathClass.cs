using System;

namespace DateTimeAndMathClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);        //Günün tarihini getirir.
            Console.WriteLine(DateTime.Now.Date);   //Gün Ay Yıl karşılığını verir.
            Console.WriteLine(DateTime.Now.Second); // Şuanki zamanın saniyesini verir.
            Console.WriteLine(DateTime.Now.Minute); //Şuanki zamanın dakikasını verir.
            Console.WriteLine(DateTime.Now.Hour);   //Şuanki zamanın saatini verir.
            Console.WriteLine(DateTime.Now.Day);    // Şuanki zamanın sadece gün'ü getirir.
            Console.WriteLine(DateTime.Now.Month);  //Şuanki zamanın sadece ay'ı getirir.
            Console.WriteLine(DateTime.Now.Year);   //Şuanki zamanınSadece yıl'ı getirir.

            Console.WriteLine(DateTime.Now.DayOfWeek); //Haftanın gününü string olarak verir.
            Console.WriteLine(DateTime.Now.DayOfYear); //Bu yılın kaçıncı gününde olduğumuzu verir.

            Console.WriteLine(DateTime.Now.ToLongDateString());  //Gün Ay Yıl Gün ismi şeklinde verir.
            Console.WriteLine(DateTime.Now.ToShortDateString()); // String şekilde datetime.Now
            Console.WriteLine(DateTime.Now.ToLongTimeString());  //Saat dakika saniye şeklinde format.
            Console.WriteLine(DateTime.Now.ToShortTimeString()); //Saat dakika şeklinde format.

            Console.WriteLine(DateTime.Now.AddDays(2));     //Şuanki zaman dilimine 2 gün ekler.
            Console.WriteLine(DateTime.Now.AddHours(5));    //Şuanki zaman dilimine 5 saat ekler.
            Console.WriteLine(DateTime.Now.AddSeconds(30)); //Şuanki zaman dilimine 30 saniye ekler.
            Console.WriteLine(DateTime.Now.AddMonths(4));   //Şuanki zaman dilimine 4 ay ekler.
            Console.WriteLine(DateTime.Now.AddYears(1));    //Şuanki zaman dilimine 1 yıl ekler.

            Console.WriteLine(DateTime.Now.ToString("dd"));    //Günün tarihini verir **17
            Console.WriteLine(DateTime.Now.ToString("ddd"));   //Günün kısaltılmış adını verir **pzt
            Console.WriteLine(DateTime.Now.ToString("dddd"));  //Günün tam adını verir. **pazartesi

            Console.WriteLine(DateTime.Now.ToString("MM"));     //Kaçıncı ay'da olduğumuzu verir. **10
            Console.WriteLine(DateTime.Now.ToString("MMM"));    //Ayın kısaltılmış adını verir. **eki
            Console.WriteLine(DateTime.Now.ToString("MMMM"));   //Ayın tam adını verir. **ekim.

            Console.WriteLine("*****");
            //Math Framework
            Console.WriteLine(Math.Abs(-25)); //-25
            Console.WriteLine(Math.Sin(10));
            Console.WriteLine(Math.Cos(80));
            Console.WriteLine(Math.Tan(30));

            Console.WriteLine(Math.Ceiling(22.3));  //22
            Console.WriteLine(Math.Round(22.4));    //22
            Console.WriteLine(Math.Round(22.6));    //23
            Console.WriteLine(Math.Floor(22.9));    //22

            Console.WriteLine(Math.Min(2, 6));
            Console.WriteLine(Math.Max(31, 06));

            Console.WriteLine(Math.Pow(3, 4));  //3^4
            Console.WriteLine(Math.Sqrt(81));   //9
            Console.WriteLine(Math.Log(9));     //9'un e tabanında  logaritmik karşılığını gösterir.
            Console.WriteLine(Math.Exp(3));     //e üzeri 3 ü verir.
            Console.WriteLine(Math.Log10(100)); //100 sayısının log 10 tabanında karşılığı

            Console.ReadKey();
        }
    }
}
