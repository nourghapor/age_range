using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace uygulama12
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad; 
            string soyad;
            Console.WriteLine("adınız giriniz:");
           ad= Console.ReadLine();
            Console.WriteLine("soyadınızı giriniz:");
            soyad=Console.ReadLine();
            Console.Write("Merhaba "+ ad +" "+ soyad);
            Console.ReadLine();
            int yas;
            Console.WriteLine("yaşınızı giriniz:");
            yas =Convert.ToInt16(Console.ReadLine());
            if (yas < 18)
            Console.Write("18 yaşları ve altı girmiyor");
            Console.WriteLine("kapanıyor");
            Console.ReadKey();
            Environment.Exit(0);

         
        }
    }
}
