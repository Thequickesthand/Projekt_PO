using System;
using System.Collections.Generic;
using System.Text;

namespace Pożyczki
{
    class Dluznik : Pozyczkobiorca
    {
        double wysokosc_dlugu = 0.0;

        public Dluznik(double[] lista, string imie, string nazwisko) : base(lista, imie, nazwisko)
        {
        }

        public override bool CzyObecny()
        {
            if (wysokosc_dlugu == 0)
            {
                return false;
            }
            else
                return true;
        }
    }
}
