using System;
using System.Collections.Generic;
using System.Text;

namespace Pożyczki
{
    public abstract class Klient
    {
        public string imie;
        public string nazwisko;
        public ulong pesel;
        public double pieniadze_do_splaty;
        public double rata;
        public int ilosc_rat;
        public bool czy_dluznik = false;

        public abstract bool CzyObecny();
    }
}
