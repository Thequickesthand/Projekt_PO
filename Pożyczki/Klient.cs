using System;
using System.Collections.Generic;
using System.Text;

namespace Pożyczki
{
    public class Klient : IWyswietl
    {
        string imie;
        string nazwisko;
        double pieniadze_do_splaty;
        double rata;
        int ilosc_rat;

        public Klient(double[] lista, string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.pieniadze_do_splaty = lista[0];
            this.rata = lista[1];
            this.ilosc_rat = (int)lista[2];
        }


        public virtual void Byly(Klient klient)
        {
            throw new NotImplementedException();
        }

        public virtual void Obecny(Klient klient)
        {
            throw new NotImplementedException();
        }

        public virtual void Wszyscy(Klient klient)
        {
            throw new NotImplementedException();
        }
    }
}
