using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;

namespace IKT
{
    internal class francia
    {
        List<string> csalad_francia = new List<string>();
        List<string> csalad_magyar = new List<string>();
        List<string> info_francia = new List<string>();
        List<string> info_magyar = new List<string>();
        List<string> utazas_francia = new List<string>();
        List<string> utazas_magyar = new List<string>();
        List<string> idojaras_francia = new List<string>();
        List<string> idojaras_magyar = new List<string>();
        List<string> lakohely_francia = new List<string>();
        List<string> lakohely_magyar = new List<string>();
        int pontszamABC;
        int pontszamPAROSITAS;
        int pontszamAKASZTOFA;
        int pontszamSZOKERESO;
        int sorszam;
        string szo;
        string abc_rendezett_betuk;
        string szokereso;
        string magyarszo;
        int index = 0;
        Random szam = new Random();
        public void Beolvas()
        {
            string[] adatok = File.ReadAllLines("francia.txt");
            for (int i = 0; i < adatok.Length; i++)
            {
                string[] sor = adatok[i].Split(';');
                if (sor[2] == "család")
                {
                    csalad_francia.Add(sor[0]);
                    csalad_magyar.Add(sor[1]);
                }
                if (sor[2] == "informatika")
                {
                    info_francia.Add(sor[0]);
                    info_magyar.Add(sor[1]);
                }
                if (sor[2] == "utazás")
                {
                    utazas_francia.Add(sor[0]);
                    utazas_magyar.Add(sor[1]);
                }
                if (sor[2] == "időjárás")
                {
                    idojaras_francia.Add(sor[0]);
                    idojaras_magyar.Add(sor[1]);
                }
                if (sor[2] == "lakóhely")
                {
                    lakohely_francia.Add(sor[0]);
                    lakohely_magyar.Add(sor[1]);
                }
            }

            Console.WriteLine("--------------------");
        }
        public void ABC()
        {
            int sorszam;
            string szo;
            string magyarszo;
            int index = 0;
            Random szam = new Random();
            do
            {
                Console.WriteLine("  Témák:  ");
                Console.WriteLine("**********");
                Console.WriteLine("1.  Család       (Könnyű)");
                Console.WriteLine("2.  Info         (Könnyű)");
                Console.WriteLine("3.  Utazás       (Közepes)");
                Console.WriteLine("4.  Időjárás     (Közepes)");
                Console.WriteLine("5.  Lakóhely     (Nehéz)");
                Console.WriteLine("6.  Kilépés      ");
                Console.WriteLine("--------------------");
                Console.Write(" -- Téma sorszáma: ");
                sorszam = Convert.ToInt16(Console.ReadLine());
                switch (sorszam)
                {
                    case 1:
                        Console.WriteLine("Válassza ki a megfelelő választ az 'a/b/c' lehetőségek közül a CSALÁD témához kapcsolódva!");
                        for (int i = 5; i < csalad_francia.Count; i++)
                        {
                            index = szam.Next(10);
                            szo = csalad_francia[index];

                            int helyesValaszIndex = szam.Next(3);
                            string helyesValasz = "";
                            if (helyesValaszIndex == 0)
                            {
                                helyesValasz = "a";
                            }
                            else if (helyesValaszIndex == 1)
                            {
                                helyesValasz = "b";
                            }
                            else
                            {
                                helyesValasz = "c";
                            }

                            List<string> masikMagyarok = csalad_magyar.Where((value, idx) => idx != index).ToList();
                            string masikMagyar1 = masikMagyarok[szam.Next(masikMagyarok.Count)];
                            masikMagyarok.Remove(masikMagyar1);
                            string masikMagyar2 = masikMagyarok[szam.Next(masikMagyarok.Count)];

                            Console.Write("A francia szó: " + szo);
                            Console.WriteLine();

                            if (helyesValasz == "a")
                            {
                                Console.WriteLine("a) " + csalad_magyar[index]);
                                Console.WriteLine("b) " + masikMagyar1);
                                Console.WriteLine("c) " + masikMagyar2);
                            }
                            else if (helyesValasz == "b")
                            {
                                Console.WriteLine("a) " + masikMagyar1);
                                Console.WriteLine("b) " + csalad_magyar[index]);
                                Console.WriteLine("c) " + masikMagyar2);
                            }
                            else
                            {
                                Console.WriteLine("a) " + masikMagyar1);
                                Console.WriteLine("b) " + masikMagyar2);
                                Console.WriteLine("c) " + csalad_magyar[index]);
                            }
                            magyarszo = Console.ReadLine();
                            if (magyarszo == helyesValasz)
                            {
                                pontszamABC += 1;
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine("Eddigi pontok: " + pontszamABC + " pont");
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine("Válassza ki a megfelelő választ az 'a/b/c' lehetőségek közül az INFORMATIKA témához kapcsolódva!");
                        for (int i = 5; i < info_francia.Count; i++)
                        {
                            index = szam.Next(10);
                            szo = info_francia[index];

                            int helyesValaszIndex = szam.Next(3);
                            string helyesValasz = "";
                            if (helyesValaszIndex == 0)
                            {
                                helyesValasz = "a";
                            }
                            else if (helyesValaszIndex == 1)
                            {
                                helyesValasz = "b";
                            }
                            else
                            {
                                helyesValasz = "c";
                            }

                            List<string> masikMagyarok = info_magyar.Where((value, idx) => idx != index).ToList();
                            string masikMagyar1 = masikMagyarok[szam.Next(masikMagyarok.Count)];
                            masikMagyarok.Remove(masikMagyar1);
                            string masikMagyar2 = masikMagyarok[szam.Next(masikMagyarok.Count)];

                            Console.Write("A francia szó: " + szo);
                            Console.WriteLine();

                            if (helyesValasz == "a")
                            {
                                Console.WriteLine("a) " + info_magyar[index]);
                                Console.WriteLine("b) " + masikMagyar1);
                                Console.WriteLine("c) " + masikMagyar2);
                            }
                            else if (helyesValasz == "b")
                            {
                                Console.WriteLine("a) " + masikMagyar1);
                                Console.WriteLine("b) " + info_magyar[index]);
                                Console.WriteLine("c) " + masikMagyar2);
                            }
                            else
                            {
                                Console.WriteLine("a) " + masikMagyar1);
                                Console.WriteLine("b) " + masikMagyar2);
                                Console.WriteLine("c) " + info_magyar[index]);
                            }

                            magyarszo = Console.ReadLine();
                            if (magyarszo == helyesValasz)
                            {
                                pontszamABC += 1;
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine("Eddigi pontok: " + pontszamABC + " pont");
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine("Válassza ki a megfelelő választ az 'a/b/c' lehetőségek közül az UTAZÁS témához kapcsolódva!");
                        for (int i = 5; i < utazas_francia.Count; i++)
                        {
                            index = szam.Next(10);
                            szo = utazas_francia[index];

                            int helyesValaszIndex = szam.Next(3);
                            string helyesValasz = "";
                            if (helyesValaszIndex == 0)
                            {
                                helyesValasz = "a";
                            }
                            else if (helyesValaszIndex == 1)
                            {
                                helyesValasz = "b";
                            }
                            else
                            {
                                helyesValasz = "c";
                            }

                            List<string> masikMagyarok = utazas_magyar.Where((value, idx) => idx != index).ToList();
                            string masikMagyar1 = masikMagyarok[szam.Next(masikMagyarok.Count)];
                            masikMagyarok.Remove(masikMagyar1);
                            string masikMagyar2 = masikMagyarok[szam.Next(masikMagyarok.Count)];

                            Console.Write("A francia szó: " + szo);
                            Console.WriteLine();

                            if (helyesValasz == "a")
                            {
                                Console.WriteLine("a) " + utazas_magyar[index]);
                                Console.WriteLine("b) " + masikMagyar1);
                                Console.WriteLine("c) " + masikMagyar2);
                            }
                            else if (helyesValasz == "b")
                            {
                                Console.WriteLine("a) " + masikMagyar1);
                                Console.WriteLine("b) " + utazas_magyar[index]);
                                Console.WriteLine("c) " + masikMagyar2);
                            }
                            else
                            {
                                Console.WriteLine("a) " + masikMagyar1);
                                Console.WriteLine("b) " + masikMagyar2);
                                Console.WriteLine("c) " + utazas_magyar[index]);
                            }

                            magyarszo = Console.ReadLine();
                            if (magyarszo == helyesValasz)
                            {
                                pontszamABC += 1;
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine("Eddigi pontok: " + pontszamABC + " pont");
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.WriteLine("Válassza ki a megfelelő választ az 'a/b/c' lehetőségek közül az IDŐJÁRÁS témához kapcsolódva!");
                        for (int i = 5; i < idojaras_francia.Count; i++)
                        {
                            index = szam.Next(10);
                            szo = idojaras_francia[index];

                            int helyesValaszIndex = szam.Next(3);
                            string helyesValasz = "";
                            if (helyesValaszIndex == 0)
                            {
                                helyesValasz = "a";
                            }
                            else if (helyesValaszIndex == 1)
                            {
                                helyesValasz = "b";
                            }
                            else
                            {
                                helyesValasz = "c";
                            }

                            List<string> masikMagyarok = idojaras_magyar.Where((value, idx) => idx != index).ToList();
                            string masikMagyar1 = masikMagyarok[szam.Next(masikMagyarok.Count)];
                            masikMagyarok.Remove(masikMagyar1);
                            string masikMagyar2 = masikMagyarok[szam.Next(masikMagyarok.Count)];

                            Console.Write("A francia szó: " + szo);
                            Console.WriteLine();

                            if (helyesValasz == "a")
                            {
                                Console.WriteLine("a) " + idojaras_magyar[index]);
                                Console.WriteLine("b) " + masikMagyar1);
                                Console.WriteLine("c) " + masikMagyar2);
                            }
                            else if (helyesValasz == "b")
                            {
                                Console.WriteLine("a) " + masikMagyar1);
                                Console.WriteLine("b) " + idojaras_magyar[index]);
                                Console.WriteLine("c) " + masikMagyar2);
                            }
                            else
                            {
                                Console.WriteLine("a) " + masikMagyar1);
                                Console.WriteLine("b) " + masikMagyar2);
                                Console.WriteLine("c) " + idojaras_magyar[index]);
                            }

                            magyarszo = Console.ReadLine();
                            if (magyarszo == helyesValasz)
                            {
                                pontszamABC += 1;
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine("Eddigi pontok: " + pontszamABC + " pont");
                        Console.WriteLine();
                        break;
                    case 5:
                        Console.WriteLine("Válassza ki a megfelelő választ az 'a/b/c' lehetőségek közül a LAKÓHELY témához kapcsolódva!");
                        for (int i = 5; i < lakohely_francia.Count; i++)
                        {
                            index = szam.Next(10);
                            szo = lakohely_francia[index];

                            int helyesValaszIndex = szam.Next(3);
                            string helyesValasz = "";
                            if (helyesValaszIndex == 0)
                            {
                                helyesValasz = "a";
                            }
                            else if (helyesValaszIndex == 1)
                            {
                                helyesValasz = "b";
                            }
                            else
                            {
                                helyesValasz = "c";
                            }

                            List<string> masikMagyarok = lakohely_magyar.Where((value, idx) => idx != index).ToList();
                            string masikMagyar1 = masikMagyarok[szam.Next(masikMagyarok.Count)];
                            masikMagyarok.Remove(masikMagyar1);
                            string masikMagyar2 = masikMagyarok[szam.Next(masikMagyarok.Count)];

                            Console.Write("A francia szó: " + szo);
                            Console.WriteLine();

                            if (helyesValasz == "a")
                            {
                                Console.WriteLine("a) " + lakohely_magyar[index]);
                                Console.WriteLine("b) " + masikMagyar1);
                                Console.WriteLine("c) " + masikMagyar2);
                            }
                            else if (helyesValasz == "b")
                            {
                                Console.WriteLine("a) " + masikMagyar1);
                                Console.WriteLine("b) " + lakohely_magyar[index]);
                                Console.WriteLine("c) " + masikMagyar2);
                            }
                            else
                            {
                                Console.WriteLine("a) " + masikMagyar1);
                                Console.WriteLine("b) " + masikMagyar2);
                                Console.WriteLine("c) " + lakohely_magyar[index]);
                            }

                            magyarszo = Console.ReadLine();
                            if (magyarszo == helyesValasz)
                            {
                                pontszamABC += 1;
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine("Eddigi pontok: " + pontszamABC + " pont");
                        Console.WriteLine();
                        break;
                }
            }
            while (sorszam != 6);
            {
                Console.WriteLine("Köszönjük, hogy velünk tanultál!");
            }
        }

        public void SzoParositas()
        {
            do
            {
                Console.WriteLine("  Témák:  ");
                Console.WriteLine("**********");
                Console.WriteLine("1.  Család       (Könnyű)");
                Console.WriteLine("2.  Info         (Könnyű)");
                Console.WriteLine("3.  Utazás       (Közepes)");
                Console.WriteLine("4.  Időjárás     (Közepes)");
                Console.WriteLine("5.  Lakóhely     (Nehéz)");
                Console.WriteLine("6.  Kilépés      ");
                Console.WriteLine("--------------------");
                Console.Write(" -- Téma sorszáma: ");
                sorszam = Convert.ToInt16(Console.ReadLine());
                switch (sorszam)
                {
                    case 1:
                        Console.WriteLine("Adja meg a francia szó magyar megfelelőjét a CSALÁD témához kapcsolódva!");
                        for (int i = 5; i < csalad_francia.Count; i++)
                        {
                            index = szam.Next(10);
                            szo = csalad_francia[index];
                            Console.Write(szo + " -- ");
                            magyarszo = Console.ReadLine();
                            if (magyarszo == csalad_magyar[index])
                            {
                                pontszamPAROSITAS += 1;
                            }
                        }
                        Console.WriteLine();
                        Console.WriteLine("Eddigi pontok: " + pontszamPAROSITAS + " pont");
                        Console.WriteLine();
                        break;

                    case 2:
                        Console.WriteLine("Adja meg a francia szó magyar megfelelőjét az INFORMATIKA témához kapcsolódva!");
                        for (int i = 5; i < info_francia.Count; i++)
                        {
                            index = szam.Next(10);
                            szo = info_francia[index];
                            Console.Write(szo + " -- ");
                            magyarszo = Console.ReadLine();
                            if (magyarszo == info_magyar[index])
                            {
                                pontszamPAROSITAS += 1;
                            }
                        }
                        Console.WriteLine();
                        Console.WriteLine("Eddigi pontok: " + pontszamPAROSITAS + " pont");
                        Console.WriteLine();
                        break;

                    case 3:
                        Console.WriteLine("Adja meg a francia szó magyar megfelelőjét az UTAZÁS témához kapcsolódva!");
                        for (int i = 5; i < utazas_francia.Count; i++)
                        {
                            index = szam.Next(10);
                            szo = utazas_francia[index];
                            Console.Write(szo + " -- ");
                            magyarszo = Console.ReadLine();
                            if (magyarszo == utazas_magyar[index])
                            {
                                pontszamPAROSITAS += 2;
                            }
                        }
                        Console.WriteLine();
                        Console.WriteLine("Eddigi pontok: " + pontszamPAROSITAS + " pont");
                        Console.WriteLine();
                        break;

                    case 4:
                        Console.WriteLine("Adja meg a francia szó magyar megfelelőjét az IDŐJÁRÁS témához kapcsolódva!");
                        for (int i = 5; i < idojaras_francia.Count; i++)
                        {
                            index = szam.Next(10);
                            szo = idojaras_francia[index];
                            Console.Write(szo + " -- ");
                            magyarszo = Console.ReadLine();
                            if (magyarszo == idojaras_magyar[index])
                            {
                                pontszamPAROSITAS += 2;
                            }
                        }
                        Console.WriteLine();
                        Console.WriteLine("Eddigi pontok: " + pontszamPAROSITAS + " pont");
                        Console.WriteLine();
                        break;

                    case 5:
                        Console.WriteLine("Adja meg a francia szó magyar megfelelőjét a LAKÓHELY témához kapcsolódva!");
                        for (int i = 5; i < lakohely_francia.Count; i++)
                        {
                            index = szam.Next(10);
                            szo = lakohely_francia[index];
                            Console.Write(szo + " -- ");
                            magyarszo = Console.ReadLine();
                            if (magyarszo == lakohely_magyar[index])
                            {
                                pontszamPAROSITAS += 3;
                            }
                        }
                        Console.WriteLine();
                        Console.WriteLine("Eddigi pontok: " + pontszamPAROSITAS + " pont");
                        Console.WriteLine();
                        break;
                }
            }
            while (sorszam != 6);
            {
                Console.WriteLine("Köszönjük, hogy velünk tanultál!");
            }
        }

        public void Akasztofa()
        {
            Random r = new Random();
            int random = r.Next(1, csalad_francia.Count - 1);
            string keresettszo = csalad_francia[random];
            int keresettszohossz = keresettszo.Length;
            var karakterek = new Regex("^[a-z]$");
            int elet = keresettszohossz + 5;
            var betuk = new List<string>();

            while (elet != 0)
            {
                var maradek = 0;
                foreach (var kar in keresettszo.ToString())
                {
                    string szobetu = kar.ToString();

                    if (betuk.Contains(szobetu))
                    {
                        Console.Write(szobetu);
                    }
                    else
                    {
                        Console.Write("_");
                        maradek++;
                    }
                }
                Console.WriteLine(string.Empty);
                if (maradek == 0)
                {
                    break;
                }

                Console.Write("Írj be egy betűt: ");
                var tipp = Console.ReadKey().Key.ToString().ToLower();
                Console.WriteLine(string.Empty);
                if (!karakterek.IsMatch(tipp))
                {
                    Console.WriteLine($"A megadott betű '{tipp}' nem szerepel a szóban. Próbáld újra!.");
                    continue;
                }
                if (betuk.Contains(tipp))
                {
                    Console.WriteLine("Már próbálkoztál ezzel a betűvel!");
                    continue;
                }
                betuk.Add(tipp);
                if (!keresettszo.Contains(tipp))
                {
                    elet--;
                    if (elet > 0)
                    {
                        Console.WriteLine($"A megadott betű '{tipp}' nem szerepel a szóban. {elet} {(elet == 1 ? "Még" : "életed")} maradt.");
                    }
                }
                Console.WriteLine();
            }
            if (elet > 0)
            {
                Console.WriteLine($"Nyertél! {elet} {(elet == 1 ? "" : "életed")} maradt!\n");
                Console.WriteLine();
                Console.WriteLine($"Szereztél {pontszamAKASZTOFA += keresettszohossz} pontot!");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"Vesztettél! A kiválasztott szó: {keresettszo} volt");
            }
            Console.WriteLine("***************************************");
        }
        public void SzoKereso()
        {
            do
            {
                Console.WriteLine("  Témák:  ");
                Console.WriteLine("**********");
                Console.WriteLine("1.  Család       (Könnyű)");
                Console.WriteLine("2.  Info         (Könnyű)");
                Console.WriteLine("3.  Utazás       (Közepes)");
                Console.WriteLine("4.  Időjárás     (Közepes)");
                Console.WriteLine("5.  Lakóhely     (Nehéz)");
                Console.WriteLine("7.  Kilépés      ");
                Console.WriteLine("--------------------");
                Console.Write(" -- Téma sorszáma: ");
                sorszam = Convert.ToInt16(Console.ReadLine());
                switch (sorszam)
                {
                    case 1:
                        Console.WriteLine("Állítsd sorrendbe a betűket és gépeld be helyesen Francia(család) témához kapcsolódóan!");
                        for (int i = 5; i < csalad_francia.Count; i++)
                        {
                            index = szam.Next(10);
                            szo = csalad_francia[index];
                            char[] betuk = szo.ToCharArray();
                            Array.Sort(betuk);
                            abc_rendezett_betuk = new string(betuk);
                            Console.WriteLine("--------------------");
                            Console.WriteLine(abc_rendezett_betuk);
                            Console.WriteLine("--------------------");
                            szokereso = Console.ReadLine();
                            if (szokereso == szo)
                            {
                                pontszamSZOKERESO = pontszamSZOKERESO + 1;
                            }
                            else
                            {
                                Console.WriteLine("********************");
                                Console.WriteLine("Nem jó :(");
                                Console.WriteLine("********************");
                            }
                        }
                        Console.WriteLine();
                        Console.WriteLine("Eddigi pontok: " + pontszamSZOKERESO + " pont");
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine("Állítsd sorrendbe a betűket és gépeld be helyesen Francia(informatika) témához kapcsolódóan!");
                        for (int i = 5; i < info_francia.Count; i++)
                        {
                            index = szam.Next(10);
                            szo = info_francia[index];
                            char[] betuk = szo.ToCharArray();
                            Array.Sort(betuk);
                            abc_rendezett_betuk = new string(betuk);
                            Console.WriteLine("--------------------");
                            Console.WriteLine(abc_rendezett_betuk);
                            Console.WriteLine("--------------------");
                            szokereso = Console.ReadLine();
                            if (szokereso == szo)
                            {
                                pontszamSZOKERESO = pontszamSZOKERESO + 1;
                            }
                            else
                            {
                                Console.WriteLine("********************");
                                Console.WriteLine("Nem jó :(");
                                Console.WriteLine("********************");
                            }
                        }
                        Console.WriteLine();
                        Console.WriteLine("Eddigi pontok: " + pontszamSZOKERESO + " pont");
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine("Állítsd sorrendbe a betűket és gépeld be helyesen Francia(utazás) témához kapcsolódóan!");
                        for (int i = 5; i < utazas_francia.Count; i++)
                        {
                            index = szam.Next(10);
                            szo = utazas_francia[index];
                            char[] betuk = szo.ToCharArray();
                            Array.Sort(betuk);
                            abc_rendezett_betuk = new string(betuk);
                            Console.WriteLine("--------------------");
                            Console.WriteLine(abc_rendezett_betuk);
                            Console.WriteLine("--------------------");
                            szokereso = Console.ReadLine();
                            if (szokereso == szo)
                            {
                                pontszamSZOKERESO = pontszamSZOKERESO + 1;
                            }
                            else
                            {
                                Console.WriteLine("********************");
                                Console.WriteLine("Nem jó :(");
                                Console.WriteLine("********************");
                            }
                        }
                        Console.WriteLine();
                        Console.WriteLine("Eddigi pontok: " + pontszamSZOKERESO + " pont");
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.WriteLine("Állítsd sorrendbe a betűket és gépeld be helyesen Francia(időjárás) témához kapcsolódóan!");
                        for (int i = 5; i < idojaras_francia.Count; i++)
                        {
                            index = szam.Next(10);
                            szo = idojaras_francia[index];
                            char[] betuk = szo.ToCharArray();
                            Array.Sort(betuk);
                            abc_rendezett_betuk = new string(betuk);
                            Console.WriteLine("--------------------");
                            Console.WriteLine(abc_rendezett_betuk);
                            Console.WriteLine("--------------------");
                            szokereso = Console.ReadLine();
                            if (szokereso == szo)
                            {
                                pontszamSZOKERESO = pontszamSZOKERESO + 1;
                            }
                            else
                            {
                                Console.WriteLine("********************");
                                Console.WriteLine("Nem jó :(");
                                Console.WriteLine("********************");
                            }
                        }
                        Console.WriteLine();
                        Console.WriteLine("Eddigi pontok: " + pontszamSZOKERESO + " pont");
                        Console.WriteLine();
                        break;
                    case 5:
                        Console.WriteLine("Állítsd sorrendbe a betűket és gépeld be helyesen Francia(lakóhely) témához kapcsolódóan!");
                        for (int i = 5; i < lakohely_francia.Count; i++)
                        {
                            index = szam.Next(10);
                            szo = lakohely_francia[index];
                            char[] betuk = szo.ToCharArray();
                            Array.Sort(betuk);
                            abc_rendezett_betuk = new string(betuk);
                            Console.WriteLine("--------------------");
                            Console.WriteLine(abc_rendezett_betuk);
                            Console.WriteLine("--------------------");
                            szokereso = Console.ReadLine();
                            if (szokereso == szo)
                            {
                                pontszamSZOKERESO = pontszamSZOKERESO + 1;
                            }
                            else
                            {
                                Console.WriteLine("********************");
                                Console.WriteLine("Nem jó :(");
                                Console.WriteLine("********************");
                            }
                        }
                        Console.WriteLine();
                        Console.WriteLine("Eddigi pontok: " + pontszamSZOKERESO + " pont");
                        Console.WriteLine();
                        break;
                }
            }
            while (sorszam != 7);
            {
                Console.WriteLine("Köszönjük, hogy velünk tanultál!");
            }


        }
        public void Pontok()
        {
            int pontok = pontszamABC + pontszamAKASZTOFA + pontszamPAROSITAS;
            Console.WriteLine($" A gyakorlásoddal összesen {pontok} pontot gyűjtöttél! Gratulálunk :)");
        }
    }
}