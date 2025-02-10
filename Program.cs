using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            angol Angol = new angol();
            olasz Olasz = new olasz();
            francia Francia = new francia();
            spanyol Spanyol = new spanyol();
            nemet Nemet = new nemet();
            string username = "Márk";
            string nyelv;

            Console.WriteLine("         Üdvözlünk " + username + " a Lingarixben            ");
            Console.WriteLine("*-----------------Használati utasítás------------------*");
            Console.WriteLine("Írja be a nyelvet amiben szeretne tanulni majd azt a számot amilyen témában tanulni szeretne!");
            do
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("  Választható nyelvek:");
                Console.WriteLine(" * Angol");
                Console.WriteLine(" * Német");
                Console.WriteLine(" * Spanyol");
                Console.WriteLine(" * Olasz");
                Console.WriteLine(" * Francia");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine(" -- Kilépéshez írjon be egy 'x' karaktert");
                Console.Write(" -- Nyelv: ");
                nyelv = Console.ReadLine();

                switch (nyelv)
                {
                    case "angol":
                        Angol.Beolvas(username);
                        Console.WriteLine("-----------------------------------------");
                        Console.WriteLine("  Választható feladatok:");
                        Console.WriteLine(" 1. ABC választási lehetőség");
                        Console.WriteLine(" 2. Akasztófa");
                        Console.WriteLine(" 3. Szópárosítás");
                        Console.WriteLine(" 4. Szó kereső");
                        Console.WriteLine("-----------------------------------------");
                        Console.Write(" Adja meg a választott feladat sorszámát: ");
                        int szamANGOL = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("-----------------------------------------");
                        if (szamANGOL == 1)
                        {
                            Angol.ABC();
                        }
                        if (szamANGOL == 2)
                        {
                            Angol.Akasztofa();
                        }
                        if (szamANGOL == 3)
                        {
                            Angol.SzoParositas();
                        }
                        if (szamANGOL == 4)
                        {
                            Angol.SzoKereso();
                        }
                        Angol.Pontok();
                        break;

                    case "német":
                        Nemet.Beolvas();
                        Console.WriteLine("-----------------------------------------");
                        Console.WriteLine("  Választható feladatok:");
                        Console.WriteLine(" 1. ABC választási lehetőség");
                        Console.WriteLine(" 2. Akasztófa");
                        Console.WriteLine(" 3. Szópárosítás");
                        Console.WriteLine("-----------------------------------------");
                        Console.Write(" Adja meg a választott feladat sorszámát: ");
                        int szamNEMET = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("-----------------------------------------");
                        if (szamNEMET == 1)
                        {
                            Nemet.ABC();
                        }
                        if (szamNEMET == 2)
                        {
                            Nemet.Akasztofa();
                        }
                        if (szamNEMET == 3)
                        {
                            Nemet.SzoParositas();
                        }
                        if (szamNEMET == 4)
                        {
                            Nemet.SzoKereso();
                        }
                        Nemet.Pontok();
                        break;

                    case "spanyol":
                        Spanyol.Beolvas();
                        Console.WriteLine("-----------------------------------------");
                        Console.WriteLine("  Választható feladatok:");
                        Console.WriteLine(" 1. ABC választási lehetőség");
                        Console.WriteLine(" 2. Akasztófa");
                        Console.WriteLine(" 3. Szópárosítás");
                        Console.WriteLine("-----------------------------------------");
                        Console.Write(" Adja meg a választott feladat sorszámát: ");
                        int szamSPANYOL = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("-----------------------------------------");
                        if (szamSPANYOL == 1)
                        {
                            Spanyol.ABC();
                        }
                        if (szamSPANYOL == 2)
                        {
                            Spanyol.Akasztofa();
                        }
                        if (szamSPANYOL == 3)
                        {
                            Spanyol.SzoParositas();
                        }
                        if (szamSPANYOL == 4)
                        {
                            Spanyol.SzoKereso();
                        }
                        Spanyol.Pontok();
                        break;

                    case "olasz":
                        Olasz.Beolvas();
                        Console.WriteLine("-----------------------------------------");
                        Console.WriteLine("  Választható feladatok:");
                        Console.WriteLine(" 1. ABC választási lehetőség");
                        Console.WriteLine(" 2. Akasztófa");
                        Console.WriteLine(" 3. Szópárosítás");
                        Console.WriteLine("-----------------------------------------");
                        Console.Write(" Adja meg a választott feladat sorszámát: ");
                        int szamOLASZ = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("-----------------------------------------");
                        if (szamOLASZ == 1)
                        {
                            Olasz.ABC();
                        }
                        if (szamOLASZ == 2)
                        {
                            Olasz.Akasztofa();
                        }
                        if (szamOLASZ == 3)
                        {
                            Olasz.SzoParositas();
                        }
                        if (szamOLASZ == 4)
                        {
                            Olasz.SzoKereso();
                        }
                        Olasz.Pontok();
                        break;

                    case "francia":
                        Francia.Beolvas();
                        Console.WriteLine("-----------------------------------------");
                        Console.WriteLine("  Választható feladatok:");
                        Console.WriteLine(" 1. ABC választási lehetőség");
                        Console.WriteLine(" 2. Akasztófa");
                        Console.WriteLine(" 3. Szópárosítás");
                        Console.WriteLine("-----------------------------------------");
                        Console.Write(" Adja meg a választott feladat sorszámát: ");
                        int szamFRANCIA = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("-----------------------------------------");
                        if (szamFRANCIA == 1)
                        {
                            Francia.ABC();
                        }
                        if (szamFRANCIA == 2)
                        {
                            Francia.Akasztofa();
                        }
                        if (szamFRANCIA == 3)
                        {
                            Francia.SzoParositas();
                        }
                        if (szamFRANCIA == 4)
                        {
                            Francia.SzoKereso();
                        }
                        Francia.Pontok();
                        break;
                }
            }
            while (nyelv != "x");
            {
                Console.WriteLine("Köszönjük" + username + ", hogy a Lingarixet választotta!");
                Console.WriteLine("Készítők: Gunics Bettina Virág, Páll Márk Hunor");
            }
            Console.ReadKey();
        }
    }
}