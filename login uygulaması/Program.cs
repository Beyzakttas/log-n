using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login_uygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kullanici giris uyg 
            //adi ve sifresi dogru ise tebrikler 
            //yanlis ise hata ver 3 hak ver 
            int haksayisi = 3;
            while (true)
                
            {
                Console.WriteLine("kullanici adinizi girin");
                string kullaniciadi = Console.ReadLine();
                Console.WriteLine("sifrenizi girin");
                string sifre = Console.ReadLine();
                if (kullaniciadi=="beyza" && sifre == "123")
                {
                    Console.WriteLine("tebrikler giris yaptiniz");
                    break;
                }
                else
                {
                    Console.WriteLine("kullanici adi veya sifre yanlis");
                }
                if (haksayisi > 0)
                {
                    haksayisi -= 1;
                    Console.WriteLine("kalan hak sayısı:" + haksayisi);
                }
                if (haksayisi ==0)
                {
                    Console.WriteLine("hakkiniz kalmadi");
                    break;
                }
                
            }
            Console.ReadLine();
        }
       
    }
}
