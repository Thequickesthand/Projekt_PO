using System;
using System.Collections.Generic;

namespace Pożyczki
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<ulong, Pozyczkobiorca> BazaPozyczkobiorcow = new Dictionary<ulong, Pozyczkobiorca>();
            Dictionary<Pozyczkobiorca, Dluznik> BazaDluznikow = new Dictionary<Pozyczkobiorca, Dluznik>();

            static void MenuGlowne()
            {
                while (0 == 0)
                {
                    string caseSwitch;
                    Console.WriteLine(" ______________________");
                    Console.WriteLine("|                      |");
                    Console.WriteLine("|  1. Baza klientów    |");
                    Console.WriteLine("|  2. Dodaj klienta    |");
                    Console.WriteLine("|  3. Kalkulator rat   |");
                    Console.WriteLine("|                      |");
                    Console.WriteLine("|  4. Wyjście          |");
                    Console.WriteLine("|______________________|");
                    Console.Write("\nTwój wybór: ");
                    caseSwitch = Console.ReadKey().KeyChar.ToString();

                    switch (caseSwitch)
                    {
                        case "1":
                            Console.Clear();
                            MBazaKlientow();
                            break;
                        case "2":
                            Console.Clear();
                            Dodaj();
                            break;
                        case "3":
                            Console.Clear();
                            double[] lista = new double[3];
                            lista = Kalkulator.ObliczRaty();
                            Console.WriteLine(Menu.KomunikatRaty());
                            Console.WriteLine(Menu.WyswietlRaty(lista[0], lista[1], (int)lista[2]));
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case "4":
                            System.Diagnostics.Process.GetCurrentProcess().Kill();
                            break;
                        default:
                            Menu.Blad();
                            break;
                    }
                }
            }

            static void MBazaKlientow()
            {
                int i = 0;

                while (i == 0)
                {
                    string caseSwitch;
                    Console.WriteLine(" ________________________________________");
                    Console.WriteLine("|                                        |");
                    Console.WriteLine("|  1. Wyświetl wszystkich klientów       |");
                    Console.WriteLine("|  2. Znajdz klienta                     |"); //Po PESEL, opcji nie było na kartce bo dopiero teraz wpadła mi do głowy. Będzie wyglądać profesjonalniej małym kosztem.
                    Console.WriteLine("|  3. Wyświetl pożyczkobiorców           |");
                    Console.WriteLine("|  4. Wyświetl dłużników                 |");
                    Console.WriteLine("|  5. Spłać rate                         |");
                    Console.WriteLine("|  6. Spłać dług                         |");
                    Console.WriteLine("|                                        |");
                    Console.WriteLine("|  7. Wróć                               |");
                    Console.WriteLine("|________________________________________|");
                    Console.Write("\nTwój wybór: ");
                    caseSwitch = Console.ReadKey().KeyChar.ToString();

                    switch (caseSwitch)
                    {
                        case "1":
                            i--;
                            Console.Clear();
                            //
                            break;
                        case "2":
                            i--;
                            Console.Clear();
                            ZnajdzKlienta();
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case "3":
                            i--;
                            Console.Clear();
                            int x = Menu.WyswietlOB();
                            if (x == 0)
                                break;
                            else
                                WyswietlKlientow(x);
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case "4":
                            i--;
                            Console.Clear();
                            //Menu.WyswietlOB();
                            break;
                        case "5":
                            i--;
                            Console.Clear();
                            SplacP();
                            break;
                        case "6":
                            i--;
                            Console.Clear();
                            //
                            break;
                        case "7":
                            Console.Clear();
                            break;
                        default:
                            i--;
                            Menu.Blad();
                            break;
                    }
                    i++;
                }
            }

            void Dodaj()
            {
                Console.WriteLine("Pesel: ");
                ulong pesel = ulong.Parse(Console.ReadLine());
                Console.WriteLine("Imie: ");
                string imie = Console.ReadLine();
                Console.WriteLine("Nazwisko: ");
                string nazwisko = Console.ReadLine();
                BazaPozyczkobiorcow.Add(pesel, new Pozyczkobiorca(Kalkulator.ObliczRaty(), imie, nazwisko));
            }

            void ZnajdzKlienta()
            {
                Console.WriteLine("Pesel: ");
                ulong pesel = ulong.Parse(Console.ReadLine());
                Console.Clear();

                if (BazaPozyczkobiorcow.TryGetValue(pesel, out Pozyczkobiorca value))
                {
                    Console.WriteLine(Menu.KomunikatDane() + Menu.KomunikatRaty());
                    Console.WriteLine(Menu.WyswietlDane(value, pesel) + Menu.WyswietlRaty(value.pieniadze_do_splaty, value.rata, (int)value.ilosc_rat));
                }
                else
                    Menu.Blad();
            }

            void SplacP()
            {
                Console.WriteLine("Pesel: ");
                ulong pesel = ulong.Parse(Console.ReadLine());
                Console.WriteLine("Splata:");
                double splata = double.Parse(Console.ReadLine());
                if (BazaPozyczkobiorcow.TryGetValue(pesel, out Pozyczkobiorca value))
                {
                    value.Splac(splata);
                }
                else
                    Menu.Blad();
            }

            void WyswietlKlientow(int i)
            {
                Console.WriteLine(Menu.KomunikatDane() + Menu.KomunikatRaty());
                if (i == 1)
                {
                    foreach (var pair in BazaPozyczkobiorcow)
                    {
                        if (pair.Value.CzyObecny() == true)
                            Console.WriteLine(Menu.WyswietlDane(pair.Value, pair.Key) + Menu.WyswietlRaty(pair.Value.pieniadze_do_splaty, pair.Value.rata, pair.Value.ilosc_rat));
                    }
                }
                else
                {
                    foreach (var pair in BazaPozyczkobiorcow)
                    {
                        if (pair.Value.CzyObecny() == false)
                            Console.WriteLine(Menu.WyswietlDane(pair.Value, pair.Key) + Menu.WyswietlRaty(pair.Value.pieniadze_do_splaty, pair.Value.rata, pair.Value.ilosc_rat));
                    }
                }   
            }


            MenuGlowne();
            Console.ReadKey();
        }
    }
}
