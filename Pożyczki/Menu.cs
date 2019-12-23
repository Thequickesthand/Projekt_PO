using System;
using System.Collections.Generic;
using System.Text;

namespace Pożyczki
{
    internal static class Menu
    {
        private static void Blad()
        {
            Console.Clear();
            Console.WriteLine(" ______________________");
            Console.WriteLine("|                      |");
            Console.WriteLine("|        BŁĄD          |");
            Console.WriteLine("|______________________|");
            Console.ReadKey();
            Console.Clear();
        }
        public static void MenuGlowne()
        {
            while (0 == 0)
            {
                int caseSwitch;

                Console.WriteLine(" ______________________");
                Console.WriteLine("|                      |");
                Console.WriteLine("|  1. Baza klientów    |");
                Console.WriteLine("|  2. Dodaj klienta    |");
                Console.WriteLine("|  3. Kalkulator rat   |");
                Console.WriteLine("|                      |");
                Console.WriteLine("|  4. Wyjście          |");
                Console.WriteLine("|______________________|");
                Console.WriteLine("\nTwój wybór: ");
                caseSwitch = int.Parse(Console.ReadKey().KeyChar.ToString()); //Poprawić tak żeby czytało klawisz za dwukropkiem. Dodać ewentualny wyjątek (wyświetlaj błąd po wprowadzeniu litery)

                switch (caseSwitch)
                {
                    case 1:
                        Console.Clear();
                        BazaKlientow();
                        break;
                    case 2:
                        Console.Clear();
                        DodajKlienta();
                        break;
                    case 3:
                        Console.Clear();
                        KalkulatorRat();
                        break;
                    case 4:
                        System.Diagnostics.Process.GetCurrentProcess().Kill();
                        break;
                    default:
                        Blad();
                        break;
                }
            }
        }

        public static void BazaKlientow()
        {
            int i = 0;
            
            while ( i == 0 )
            {
                int caseSwitch;
                Console.WriteLine(" ________________________________________");
                Console.WriteLine("|                                        |");
                Console.WriteLine("|  1. Wyświetl wszystkich klientów       |");
                Console.WriteLine("|  2. Wyświetl obecnych pożyczkobiorców  |");
                Console.WriteLine("|  3. Wyświetl obecnych dłużników        |");
                Console.WriteLine("|  4. Spłać rate                         |");
                Console.WriteLine("|  5. Spłać dług                         |");
                Console.WriteLine("|                                        |");
                Console.WriteLine("|  6. Wróć                               |");
                Console.WriteLine("|________________________________________|");
                Console.WriteLine("\nTwój wybór: ");
                caseSwitch = int.Parse(Console.ReadKey().KeyChar.ToString()); //Dokładnie to samo co wyżej

                switch (caseSwitch)
                {
                    case 1:
                        i--;
                        Console.Clear();
                        //Puste miejsca na przyszłe metody
                        break;
                    case 2:
                        i--;
                        Console.Clear();
                        //
                        break;
                    case 3:
                        i--;
                        Console.Clear();
                        //
                        break;
                    case 4:
                        i--;
                        Console.Clear();
                        //
                        break;
                    case 5:
                        i--;
                        Console.Clear();
                        //
                        break;
                    case 6:
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

        public static void DodajKlienta()
        {
            //
        }

        public static void KalkulatorRat()
        {
            //
        }
    }
}
