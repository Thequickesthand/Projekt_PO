using System;
using System.Collections.Generic;
using System.Text;

namespace Pożyczki
{
    internal static class Menu
    {
        public static void Blad()
        {
            Console.Clear();
            Console.WriteLine(" ______________________");
            Console.WriteLine("|                      |");
            Console.WriteLine("|        BŁĄD          |");
            Console.WriteLine("|______________________|");
            Console.ReadKey();
            Console.Clear();
        }

        public static void WyswietlOB()
        {
            int i = 0;

            while (i == 0)
            {
                string caseSwitch;
                Console.WriteLine(" ________________________________________");
                Console.WriteLine("|                                        |");
                Console.WriteLine("|  1. Obecnych                           |");
                Console.WriteLine("|  2. Byłych                             |");
                Console.WriteLine("|                                        |");
                Console.WriteLine("|  3. Wróć                               |");
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
                        //
                        break;
                    case "3":
                        Console.Clear();
                        break;
                    default:
                        i--;
                        Blad();
                        break;
                }
                i++;
            }
        }

        public static void KomunikatRaty()
        {
            Console.WriteLine("| Pieniądze do spłaty | Rata | Ilość rat |");
        }
        public static void WyswietlRaty(double pieniadze_do_spaty, double raty, int ilosc_rat)
        {
            Console.WriteLine("| " + pieniadze_do_spaty + " | " + raty + " | " + ilosc_rat + " |");
        }


        public static void KomunikatDane()
        {
            Console.WriteLine("| Imie | Nazwisko | Pesel |");
        }
        public static void WyswietlDane(Dictionary<ulong, Klient> BazaKlientow, ulong pesel)
        {
            BazaKlientow.Values.
        }
    }
}
