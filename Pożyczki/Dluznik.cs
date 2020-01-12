using System;
using System.Collections.Generic;
using System.Text;

namespace Pożyczki
{
    class Dluznik : Pozyczkobiorca
    {
        public double wysokosc_dlugu;

        public Dluznik(double[] tablica, string imie, string nazwisko, ulong pesel, double wysokosc_dlugu) : base(tablica, imie, nazwisko, pesel)
        {
            this.wysokosc_dlugu = wysokosc_dlugu;
        }

        public override bool CzyObecny()
        {
            if (wysokosc_dlugu == 0)
                return false;
            else
                return true;
        }
    }
}
