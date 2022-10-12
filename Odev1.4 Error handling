using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hata_yönetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            try //Hataya neden olabilecek kod
            {
            Console.WriteLine("Bir sayı giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Girmiş olduğunuz sayı: " + sayi1);
            }
            catch(Exception ex) //hata gelirse açıklamasını yazdıracağız.
            {
            Console.WriteLine("Hata: " + ex.Message.ToString());
            }
            /*
             finally //Hata alsın, almasın çalışmasını istediğimiz kod bloğu
            {
            Console.WriteLine("İşlem tamamlandı.");
            }
            */

            try
            {
                //int a = int.Parse(null);
                int b = int.Parse("-20000000000");
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine("Boş değer girdiniz");
                Console.WriteLine(ex);
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun değil.");
                Console.WriteLine(ex);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Çok küçük veya çok büyük bir değer girdiniz.");
                Console.WriteLine(ex);
            }

            Console.ReadKey();
        }
    }
}
