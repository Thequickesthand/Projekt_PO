using System;
using System.Collections.Generic;
using System.Text;

namespace Pożyczki
{
    class Dluznik : Klient
    {
        public Dluznik(string imie, string nazwisko, int pesel) : base(imie, nazwisko, pesel)
        {
        }
    }
}
