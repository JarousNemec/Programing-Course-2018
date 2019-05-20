using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static int volba;
        static int volba1;
        static int volba2;


        static int volba3;
        static double Auta;
        static double Motorky;
        static double NahladniVozy;

        static int cena;
        static double hmotnost;
        static double rychlost;
        static string barva;
        static double sleva;
        static string nazev;

        public static double auta(out double Auta)
        {
            Auta = ((cena / 100) * 10) + 500+ hmotnost;
            return Auta;
        }
        public static void motorky()
        {
            Motorky = ((cena / 100) * 15) + 800+ hmotnost;
        }
        public static void nahladnivozy()
        {
            NahladniVozy = ((cena / 100) * 12) + 1500+ hmotnost;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("1. Automobily - mercedes, renault,skoda");
            Console.WriteLine("2. Motorky - harley, honda, kawasaki");
            Console.WriteLine("3. Nakladni vozy - tatra, man, scanie");
            do
            {
                volba = Convert.ToInt32(Console.ReadLine());
            } while (volba > 3);

            Console.Clear();

            if (volba == 1)
            {
                Console.WriteLine("1. mercedes");
                Console.WriteLine("2. renault");
                Console.WriteLine("3. skoda");
                do
                {
                    volba1 = Convert.ToInt32(Console.ReadLine());
                } while (volba1 > 3);
                Console.Clear();
                if (volba1 == 1)
                {
                    nazev = "mercedes";
                    hmotnost = 1200;
                    cena = 1500000;
                    rychlost = 150;
                    barva = "čevená";
                    sleva = auta(out double Auta);
                    Console.WriteLine("Nazev :" + nazev);
                    Console.WriteLine("Cena :" + cena + " kč");
                    Console.WriteLine("Hmotnost :" + hmotnost + " kg");
                    Console.WriteLine("Rychlost :" + rychlost + " km/h");
                    Console.WriteLine("Barva :" + barva);
                    Console.WriteLine("Sleva :" + sleva + " kč");
                }
                if (volba1 == 2)
                {
                    nazev = "renault";
                    hmotnost = 1560;
                    cena = 159685;
                    rychlost = 120;
                    barva = "žlutá";

                    sleva = auta(out double Auta);

                    Console.WriteLine("Nazev :" + nazev);
                    Console.WriteLine("Cena :" + cena + " kč");
                    Console.WriteLine("Hmotnost :" + hmotnost + " kg");
                    Console.WriteLine("Rychlost :" + rychlost + " km/h");
                    Console.WriteLine("Barva :" + barva);
                    Console.WriteLine("Sleva :" + sleva + " kč");
                }
                if (volba1 == 3)
                {
                    nazev = "skoda";
                    hmotnost = 1295;
                    cena = 125600;
                    rychlost = 60;
                    barva = "modrá";

                    sleva = auta(out double Auta);

                    Console.WriteLine("Nazev :" + nazev);
                    Console.WriteLine("Cena :" + cena + " kč");
                    Console.WriteLine("Hmotnost :" + hmotnost + " kg");
                    Console.WriteLine("Rychlost :" + rychlost + " km/h");
                    Console.WriteLine("Barva :" + barva);
                    Console.WriteLine("Sleva :" + sleva + " kč");
                }
            }
            
            if (volba == 2)
            {
                Console.WriteLine("1. harley");
                Console.WriteLine("2. honda");
                Console.WriteLine("3. kawasaki");
                do
                {
                    volba2 = Convert.ToInt32(Console.ReadLine());
                } while (volba2 > 3);

                Console.Clear();

                if (volba2 == 1)
                {
                    nazev = "harley";
                    hmotnost = 120;
                    cena = 150001;
                    rychlost = 159;
                    barva = "čevená";
                    sleva = auta(out double Auta);
                    Console.WriteLine("Nazev :" + nazev);
                    Console.WriteLine("Cena :" + cena + " kč");
                    Console.WriteLine("Hmotnost :" + hmotnost + " kg");
                    Console.WriteLine("Rychlost :" + rychlost + " km/h");
                    Console.WriteLine("Barva :" + barva);
                    Console.WriteLine("Sleva :" + sleva + " kč");
                }
                if (volba2 == 2)
                {
                    nazev = "honda";
                    hmotnost = 156;
                    cena = 15968;
                    rychlost = 120;
                    barva = "žlutá";

                    sleva = auta(out double Auta);

                    Console.WriteLine("Nazev :" + nazev);
                    Console.WriteLine("Cena :" + cena + " kč");
                    Console.WriteLine("Hmotnost :" + hmotnost + " kg");
                    Console.WriteLine("Rychlost :" + rychlost + " km/h");
                    Console.WriteLine("Barva :" + barva);
                    Console.WriteLine("Sleva :" + sleva + " kč");
                }
                if (volba2 == 3)
                {
                    nazev = "kawasaki";
                    hmotnost = 129;
                    cena = 12560;
                    rychlost = 200;
                    barva = "modrá";

                    sleva = auta(out double Auta);

                    Console.WriteLine("Nazev :" + nazev);
                    Console.WriteLine("Cena :" + cena + " kč");
                    Console.WriteLine("Hmotnost :" + hmotnost + " kg");
                    Console.WriteLine("Rychlost :" + rychlost + " km/h");
                    Console.WriteLine("Barva :" + barva);
                    Console.WriteLine("Sleva :" + sleva + " kč");
                }
            }
            
            if (volba == 3)
            {
                Console.WriteLine("1. scanie");
                Console.WriteLine("2. man");
                Console.WriteLine("3. tatra ");
                do
                {
                    volba3 = Convert.ToInt32(Console.ReadLine());
                } while (volba3 > 3);

                Console.Clear();

                if (volba3 == 1)
                {
                    nazev = "scanie";
                    hmotnost = 6352;
                    cena = 564000;
                    rychlost = 159;
                    barva = "čevená";
                    sleva = auta(out double Auta);
                    Console.WriteLine("Nazev :"+nazev);
                    Console.WriteLine("Cena :"+cena + " kč");
                    Console.WriteLine("Hmotnost :"+hmotnost+" kg");
                    Console.WriteLine("Rychlost :"+rychlost+" km/h");
                    Console.WriteLine("Barva :"+barva);
                    Console.WriteLine("Sleva :"+sleva+" kč");
                }
                if (volba3 == 2)
                {
                    nazev = "man";
                    hmotnost = 3680;
                    cena = 900000;
                    rychlost = 80;
                    barva = "žlutá";

                    sleva = auta(out double Auta);

                    Console.WriteLine("Nazev :" + nazev);
                    Console.WriteLine("Cena :" + cena + " kč");
                    Console.WriteLine("Hmotnost :" + hmotnost + " kg");
                    Console.WriteLine("Rychlost :" + rychlost + " km/h");
                    Console.WriteLine("Barva :" + barva);
                    Console.WriteLine("Sleva :" + sleva + " kč");
                }
                if (volba3 == 3)
                {
                    nazev = "tatra";
                    hmotnost = 5000;
                    cena = 625699;
                    rychlost = 50;
                    barva = "modrá";

                    sleva = auta(out double Auta);

                    Console.WriteLine("Nazev :" + nazev);
                    Console.WriteLine("Cena :" + cena + " kč");
                    Console.WriteLine("Hmotnost :" + hmotnost + " kg");
                    Console.WriteLine("Rychlost :" + rychlost + " km/h");
                    Console.WriteLine("Barva :" + barva);
                    Console.WriteLine("Sleva :" + sleva + " kč");
                }
            }
            
            Console.ReadKey();
        }
    }
}
