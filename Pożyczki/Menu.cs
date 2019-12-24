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
               //Zaimplementować wyjątek który będzie wyświetlał Blad() po kliknieciu litery na klawiaturze.

                switch (caseSwitch)
                {
                    case 1:
                        Console.Clear();
                        MBazaKlientow();
                        break;
                    case 2:
                        Console.Clear();
                        //Puste miejsca na przyszłe metody
                        break;
                    case 3:
                        Console.Clear();
                        double[] lista = new double[3];
                        lista = Kalkulator.ObliczRaty();
                        Console.WriteLine("| Pieniądze do spłaty | Rata | Ilość rat |");
                        Console.WriteLine("| " + lista[0] + " | " + lista[1] + " | " + lista[2] + " |");
                        Console.ReadKey();
                        Console.Clear();
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

        private static void MBazaKlientow()
        {
            int i = 0;
            
            while ( i == 0 )
            {
                int caseSwitch;
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
                Console.WriteLine("\nTwój wybór: ");
                caseSwitch = int.Parse(Console.ReadKey().KeyChar.ToString()); //Dokładnie to samo co wyżej

                switch (caseSwitch)
                {
                    case 1:
                        i--;
                        Console.Clear();
                        //
                        break;
                    case 2:
                        i--;
                        Console.Clear();
                        //
                        break;
                    case 3:
                        i--;
                        Console.Clear();
                        MWyświetlP();
                        break;
                    case 4:
                        i--;
                        Console.Clear();
                        MWyświetlD();
                        break;
                    case 5:
                        i--;
                        Console.Clear();
                        //
                        break;
                    case 6:
                        i--;
                        Console.Clear();
                        //
                        break;
                    case 7:
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

        private static void MWyświetlP()
        {
            int i = 0;

            while (i == 0)
            {
                int caseSwitch;
                Console.WriteLine(" ________________________________________");
                Console.WriteLine("|                                        |");
                Console.WriteLine("|  1. Obecnych                           |");
                Console.WriteLine("|  2. Byłych                             |");
                Console.WriteLine("|                                        |");
                Console.WriteLine("|  3. Wróć                               |");
                Console.WriteLine("|________________________________________|");
                Console.WriteLine("\nTwój wybór: ");
                caseSwitch = int.Parse(Console.ReadKey().KeyChar.ToString()); //Dokładnie to samo co wyżej

                switch (caseSwitch)
                {
                    case 1:
                        i--;
                        Console.Clear();
                        //
                        break;
                    case 2:
                        i--;
                        Console.Clear();
                        //
                        break;
                    case 3:
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

        private static void MWyświetlD()
        {
            int i = 0;

            while (i == 0)
            {
                int caseSwitch;
                Console.WriteLine(" ________________________________________");
                Console.WriteLine("|                                        |");
                Console.WriteLine("|  1. Obecnych                           |");
                Console.WriteLine("|  2. Byłych                             |");
                Console.WriteLine("|                                        |");
                Console.WriteLine("|  3. Wróć                               |");
                Console.WriteLine("|________________________________________|");
                Console.WriteLine("\nTwój wybór: ");
                caseSwitch = int.Parse(Console.ReadKey().KeyChar.ToString()); //Dokładnie to samo co wyżej

                switch (caseSwitch)
                {
                    case 1:
                        i--;
                        Console.Clear();
                        //
                        break;
                    case 2:
                        i--;
                        Console.Clear();
                        //
                        break;
                    case 3:
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

    }
}
