﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Pożyczki
{
    public class Pozyczkobiorca : Klient
    {
        public Pozyczkobiorca(double[] lista, string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.pieniadze_do_splaty = lista[0];
            this.rata = lista[1];
            this.ilosc_rat = (int)lista[2];
        }

        public override bool CzyObecny()
        {
            if (pieniadze_do_splaty == 0)
            {
                this.rata = 0;
                return false;
            }
            else
                return true;
        }
    }
}
