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
                            Console.WriteLine("Dluznik [TAK(1)/NIE(0)]: ");
                            bool i = Convert.ToBoolean(int.Parse(Console.ReadLine()));
                            double[] tablica = Kalkulator.ObliczRaty(i);
                            Console.WriteLine(Menu.KomunikatRaty());
                            Console.WriteLine(Menu.WyswietlRaty(tablica[0], tablica[1], (int)tablica[2]));
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
                    Console.WriteLine("|  2. Znajdz klienta                     |");
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
                            WyswietlWszystkichKlientow();
                            Console.ReadKey();
                            Console.Clear();
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
                            int y = Menu.WyswietlOB();
                            if (y == 0)
                                break;
                            else
                                WyswietlDluznikow(y);
                            break;
                        case "5":
                            i--;
                            Console.Clear();
                            SplacP();
                            break;
                        case "6":
                            i--;
                            Console.Clear();
                            SplacD();
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
                if (BazaPozyczkobiorcow.TryGetValue(pesel, out Pozyczkobiorca value))
                {
                    if(BazaDluznikow.TryGetValue(value, out Dluznik dluznik))
                    {
                        double[] tablica = Kalkulator.ObliczRaty(true);
                        value.pieniadze_do_splaty = tablica[0];
                        value.rata = tablica[1];
                        value.ilosc_rat = (int)tablica[2];
                    }
                    else
                    {
                        double[] tablica = Kalkulator.ObliczRaty(false);
                        value.pieniadze_do_splaty = tablica[0];
                        value.rata = tablica[1];
                        value.ilosc_rat = (int)tablica[2];
                    }
                }
                else
                {
                    Console.WriteLine("Imie: ");
                    string imie = Console.ReadLine();
                    Console.WriteLine("Nazwisko: ");
                    string nazwisko = Console.ReadLine();
                    BazaPozyczkobiorcow.Add(pesel, new Pozyczkobiorca(Kalkulator.ObliczRaty(false), imie, nazwisko, pesel));
                }
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

            void SplacD()
            {
                Console.WriteLine("Pesel: ");
                ulong pesel = ulong.Parse(Console.ReadLine());
                if (BazaPozyczkobiorcow.TryGetValue(pesel, out Pozyczkobiorca value) && value.CzyObecny())
                {
                    BazaDluznikow.TryGetValue(value, out Dluznik dluznik);
                    Console.WriteLine("Dlug: " + dluznik.wysokosc_dlugu);
                    Console.WriteLine("Splata:");
                    double splata = double.Parse(Console.ReadLine());
                    dluznik.wysokosc_dlugu -= splata;
                    if (dluznik.CzyObecny() == false)
                        value.czy_dluznik = false;
                }
                else
                    Menu.Blad();
            }

            void SplacP()
            {
                Console.WriteLine("Pesel: ");
                ulong pesel = ulong.Parse(Console.ReadLine());
                if (BazaPozyczkobiorcow.TryGetValue(pesel, out Pozyczkobiorca value) && value.CzyObecny())
                {
                    Console.WriteLine("Rata: " + value.rata);
                    Console.WriteLine("Splata:");
                    double splata = double.Parse(Console.ReadLine());

                    if (splata >= value.rata)
                        value.rata -= splata;
                    else
                    {
                        if (BazaDluznikow.TryGetValue(value, out Dluznik dluznik))
                        {
                            dluznik.pieniadze_do_splaty += (value.rata - splata) * Stale.op_dlugu;
                        }
                        else
                        {
                            double[] tablica = new double[3];
                            BazaDluznikow.Add(value, new Dluznik(tablica, value.imie, value.nazwisko, value.pesel, (value.rata - splata) * Stale.op_dlugu));
                            value.czy_dluznik = true;
                        }
                    }
                }
                else
                    Menu.Blad();
            }

            void WyswietlWszystkichKlientow()
            {
                Console.WriteLine(Menu.KomunikatDane() + Menu.KomunikatRaty() + Menu.KomunikatDluznik());
                foreach (var pair in BazaPozyczkobiorcow)
                {
                    if (BazaDluznikow.TryGetValue(pair.Value, out Dluznik dluznik))
                        Console.WriteLine(Menu.WyswietlDane(pair.Value, pair.Key) + Menu.WyswietlRaty(pair.Value.pieniadze_do_splaty, pair.Value.rata, pair.Value.ilosc_rat) + Menu.WyswietlDluznik(dluznik.wysokosc_dlugu, true));
                    else
                        Console.WriteLine(Menu.WyswietlDane(pair.Value, pair.Key) + Menu.WyswietlRaty(pair.Value.pieniadze_do_splaty, pair.Value.rata, pair.Value.ilosc_rat) + Menu.WyswietlDluznik(0 , false));
                }
            }

            void WyswietlKlientow(int i)
            {
                if (i == 1)
                {
                    Console.WriteLine(Menu.KomunikatDane() + Menu.KomunikatRaty() + Menu.KomunikatDluznik());
                    foreach (var pair in BazaPozyczkobiorcow)
                    {
                        if (pair.Value.CzyObecny() == true)
                        {
                            if (BazaDluznikow.TryGetValue(pair.Value, out Dluznik dluznik))
                                Console.WriteLine(Menu.WyswietlDane(pair.Value, pair.Key) + Menu.WyswietlRaty(pair.Value.pieniadze_do_splaty, pair.Value.rata, pair.Value.ilosc_rat) + Menu.WyswietlDluznik(dluznik.wysokosc_dlugu, true));
                            else
                                Console.WriteLine(Menu.WyswietlDane(pair.Value, pair.Key) + Menu.WyswietlRaty(pair.Value.pieniadze_do_splaty, pair.Value.rata, pair.Value.ilosc_rat) + Menu.WyswietlDluznik(0 , false));
                        }
                    }
                }
                else
                {
                    Console.WriteLine(Menu.KomunikatDane());
                    foreach (var pair in BazaPozyczkobiorcow)
                    {
                        if (pair.Value.CzyObecny() == false)
                            Console.WriteLine(Menu.WyswietlDane(pair.Value, pair.Key));
                    }
                }   
            }

            void WyswietlDluznikow(int i)
            {
                Console.WriteLine(Menu.KomunikatDane() + Menu.KomunikatRaty());
                if (i == 1)
                {
                    foreach (var pair in BazaDluznikow)
                    {
                        if (pair.Value.CzyObecny() == true)
                            Console.WriteLine(Menu.WyswietlDane(pair.Value, pair.Key.pesel));
                    }
                }
                else
                {
                    foreach (var pair in BazaDluznikow)
                    {

                        if (pair.Value.CzyObecny() == false)
                            Console.WriteLine(Menu.WyswietlDane(pair.Value, pair.Key.pesel));
                    }
                }
            }


            MenuGlowne();
            Console.ReadKey();
        }
    }
}
