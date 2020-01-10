using System;
using System.Collections.Generic;
using System.Text;

namespace Pożyczki
{
    public abstract class Klient
    {
        public string imie;
        public string nazwisko;
        public double pieniadze_do_splaty;
        public double rata;
        public int ilosc_rat;

        public abstract bool CzyObecny();
        public abstract void Splac(double splata);
        public abstract bool CzyDluznik();
    }
}
