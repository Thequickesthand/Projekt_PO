using System;
using System.Collections.Generic;
using System.Text;

namespace Pożyczki
{
    public static class Kalkulator
    {
        private static bool OstatniaRata(int ilosc_rat, double rata, double pieniadze_do_splaty) 
        {
            if (pieniadze_do_splaty - (rata * ilosc_rat) == -rata)
            {
                return false;
            }
            else
                return true;
        }
        public static double[] ObliczRaty(bool dluznik)
        {
            Console.WriteLine("Zarobki: ");
            double zarobki = double.Parse(Console.ReadLine());
            Console.WriteLine("Wysokosc pożyczki: ");
            double pozyczka = double.Parse(Console.ReadLine());
            Console.WriteLine("Rodzaj spłaty ( [1] - Szybko / [2] - Wolno ): ");
            int splata = int.Parse(Console.ReadLine());

            double pieniadze_do_splaty = 0;
            double rata = 0;
            int ilosc_rat = 0;
            if (dluznik == true)
                pieniadze_do_splaty = (pozyczka * Stale.oprocentowanie) * Stale.dod_op_dluz;
            else
                pieniadze_do_splaty = pozyczka * Stale.oprocentowanie;

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

            double[] tablica = new double[3] { pieniadze_do_splaty, rata, ilosc_rat };
            Console.Clear();
            return tablica;
        }
    }
}
