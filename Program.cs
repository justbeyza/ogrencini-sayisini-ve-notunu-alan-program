using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sınıftaki öğrenci sayısını giriniz");
            int ogrncs = Convert.ToInt32(Console.ReadLine());  
            string[] isimler = new string[ogrncs];
            byte[] notlar = new byte[ogrncs];

            for (int i = 0; i < isimler.Length; i++)
            {
                Console.WriteLine((i+1) + ". Öğrencinin adını giriniz.");
                isimler[i] = Console.ReadLine();
                Console.WriteLine((i+1) + ". Öğrencinin notunu giriniz.");
                notlar[i] = Convert.ToByte(Console.ReadLine());
            }

            for(int i = 0; i < isimler.Length; i++)
            {
                if (notlar[i] >= 50)
                {
                    Console.WriteLine(isimler[i] + $" isimli öğrencinin NTP dersinden {notlar[i]} puan ile geçti");
                }
                else if (notlar[i] <= 50)
                {
                    Console.WriteLine(isimler[i] + $" isimli öğrencinin NTP dersinden {notlar[i]} puan ile kaldı");
                }


            }
            
            Console.ReadKey();


        }
    }
}
