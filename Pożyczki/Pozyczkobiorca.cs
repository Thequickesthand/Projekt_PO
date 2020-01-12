using System;
using System.Collections.Generic;
using System.Text;

namespace Pożyczki
{
    public class Pozyczkobiorca : Klient
    {
        public Pozyczkobiorca(double[] tablica, string imie, string nazwisko, ulong pesel)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.pesel = pesel;
            this.pieniadze_do_splaty = tablica[0];
            this.rata = tablica[1];
            this.ilosc_rat = (int)tablica[2];
        }

        public override bool CzyObecny()
        {
            if (pieniadze_do_splaty == 0 && this.czy_dluznik == false)
            {
                this.rata = 0;
                return false;
            }
            else
                return true;
        }
    }
}
