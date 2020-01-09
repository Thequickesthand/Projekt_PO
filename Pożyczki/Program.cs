using System;
using System.Collections.Generic;

namespace Pożyczki
{
    class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<ulong, Klient> BazaKlientow = new Dictionary<ulong, Klient>();

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
                            Menu.KomunikatRaty();
                            Menu.WyswietlRaty(lista[0], lista[1], (int)lista[2]);
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
                            break;
                        case "3":
                            i--;
                            Console.Clear();
                            Menu.WyswietlOB();
                            break;
                        case "4":
                            i--;
                            Console.Clear();
                            Menu.WyswietlOB();
                            break;
                        case "5":
                            i--;
                            Console.Clear();
                            //
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
                BazaKlientow.Add(pesel, new Klient(Kalkulator.ObliczRaty(), imie, nazwisko));
            }

            void ZnajdzKlienta()
            {
                Console.WriteLine("Pesel: ");
                ulong pesel = ulong.Parse(Console.ReadLine());

                if (BazaKlientow.ContainsKey(pesel))
                {

                }
                else
                    Menu.Blad();
            }


            MenuGlowne();
            Console.ReadKey();
        }
    }
}
