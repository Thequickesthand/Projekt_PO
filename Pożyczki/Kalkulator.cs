using System;
using System.Collections.Generic;
using System.Text;

namespace Pożyczki
{
    public static class Kalkulator
    {
        private static bool OstatniaRata(int ilosc_rat, double rata, double pieniadze_do_splaty)
        {
            if (pieniadze_do_splaty - (rata * ilosc_rat) == rata)
            {
                return false;
            }
            else
                return true;
        }
        public static double[] ObliczRaty()
        {
            Console.WriteLine("Zarobki: ");                                         //Do wszystkich ReadLine - dokładnie ten sam wyjątek co w menu, oraz dokładnie ta sama poprawaka estetyczna (numery po dwukropku)
            double zarobki = double.Parse(Console.ReadLine());
            Console.WriteLine("Wysokosc pożyczki: ");
            double pozyczka = double.Parse(Console.ReadLine());
            Console.WriteLine("Rodzaj spłaty ( [1] - Szybko / [2] - Wolno ): ");
            int splata = int.Parse(Console.ReadLine());

            double pieniadze_do_splaty = pozyczka + (pozyczka * Stale.oprocentowanie);
            double rata = 0.0;
            int ilosc_rat = 0;

            if (splata == 1)
            {
                rata = zarobki * Stale.szypko;
                ilosc_rat = (int)(pieniadze_do_splaty / rata) + 1;
                if (OstatniaRata(ilosc_rat, rata, pieniadze_do_splaty) == false)
                    ilosc_rat--;
            }
            else if (splata == 2)
            {
                rata = zarobki * Stale.wolmo;
                ilosc_rat = (int)(pieniadze_do_splaty / rata) + 1;
                if (OstatniaRata(ilosc_rat, rata, pieniadze_do_splaty) == false)
                    ilosc_rat--;
            }

            double[] lista = new double[3] { pieniadze_do_splaty, rata, ilosc_rat };
            Console.Clear();
            return lista;
        }
    }
}
