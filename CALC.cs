using Microsoft.Diagnostics.Tracing.Parsers.Symbol;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practic
{
    class Direksiya
    {
        public string FIO { get; set; }
        public string Lavozim { get; set; }
        public string Bolim { get; set; }
        public int Xona { get; set; }

        public void Malumot()
        {
            Console.WriteLine($"Ism: {FIO}, Lavozim: {Lavozim}, Bolim: {Bolim}, Xona: {Xona}");
        }
    }

    class Program
    {
        static List<Direksiya> xodimlar = new List<Direksiya>();

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\n=====Xodimlar haqida Malumot=====");
                Console.WriteLine("1. Xodim kiritish");
                Console.WriteLine("2. Barcha xodimni ko'rish");
                Console.WriteLine("3. Bo'lim bo'yicha qidirish");
                Console.WriteLine("4. Chiqish");

                Console.Write("\nTanlovingiz: ");
                int tanlov = int.Parse(Console.ReadLine()); 

                switch(tanlov)
                {
                    case 1:
                        XodimQidirish();
                        break;
                    case 2:
                        BarchaXodimlarniKorsatish();
                        break;
                    case 3:
                        BolimBoyichaQidirish();
                        break;
                    case 4:
                        Console.WriteLine("Dastur yakunlandi");
                        break;
                    default:
                        Console.WriteLine("Xatolikka yo'l qo'yildi!");
                        break;
                }
            }
        }

        static void XodimQidirish()
        {
            Console.Write("F.I.O: ");
            string fio = Console.ReadLine();

            Console.Write("Lavozimi: ");
            string lavozim = Console.ReadLine();

            Console.Write("Qaysi bo'limda: ");
            string bolim = Console.ReadLine();
            Console.Write("Xona: ");
            int xona = int.Parse(Console.ReadLine());

            Direksiya direksiyaXodimlari = new Direksiya
            {
                FIO = fio,
                Lavozim = lavozim,
                Bolim = bolim,
                Xona = xona
            };

            xodimlar.Add(direksiyaXodimlari);
            Console.WriteLine("\nQoshildi");
        
        }

        static void BarchaXodimlarniKorsatish()
        {
            if(xodimlar.Count == 0)
            {
                Console.WriteLine("Hech qaysi topilmadi");
                return;
            }

            Console.WriteLine("Barcha xodimlar");
            foreach(var x in xodimlar)
            {
                x.Malumot();
            }
        }

        static void BolimBoyichaQidirish()
        {
            Console.WriteLine("Qaysi bo'lim qidirilyapti?");
            string bolimTanlash = Console.ReadLine();

            bool xatolik = false;
            foreach(var x in xodimlar)
            {
                if(x.Bolim.ToLower() == bolimTanlash)
                {
                    xatolik = true;
                    x.Malumot();
                }
            }

            if(!xatolik)
            {
                Console.WriteLine("Hech narsa topilmadi");
            }
        }
    }
  

}
