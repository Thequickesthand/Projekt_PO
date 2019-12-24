using System;
using System.Collections.Generic;
using System.Text;

namespace Pożyczki
{
    public class Klient : IWyswietl
    {
        public string imie;
        public string nazwisko;
        public int pesel;
        public bool obecny;
        public bool dluznik;

        public Klient(string imie, string nazwisko, int pesel)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.pesel = pesel;
        }

        static bool CzyDluznik()
        {

        }
        public virtual void Byli(Klient klient)
        {
            throw new NotImplementedException();
        }

        public virtual void Obecni(Klient klient)
        {
            throw new NotImplementedException();
        }

        public virtual void Wszyscy(Klient klient)
        {
            throw new NotImplementedException();
        }
    }
}
