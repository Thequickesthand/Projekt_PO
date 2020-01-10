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

        public static int WyswietlOB()
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
                        Console.Clear();
                        return 1;
                    case "2":
                        Console.Clear();
                        return 2;
                    case "3":
                        Console.Clear();
                        return 0;
                    default:
                        i--;
                        Blad();
                        break;
                }
                i++;
            }
            return 0;
        }

        public static string KomunikatRaty()
        {
            return "| Pieniądze do spłaty | Rata | Ilość rat |";
        }
        public static string WyswietlRaty(double pieniadze_do_spaty, double raty, int ilosc_rat)
        {
            return "| " + pieniadze_do_spaty + " | " + raty + " | " + ilosc_rat + " |";
        }

        public static string KomunikatDane()
        {
            return "| Imie | Nazwisko | Pesel |";
        }
        public static string WyswietlDane(Pozyczkobiorca klient, ulong pesel)
        {
            return "| " + klient.imie + " | " + klient.nazwisko + " | " + (int)pesel + " |";
        }
    }
}
