using System;
using System.Collections.Generic;
using System.Text;

namespace Pożyczki
{
    interface IWyswietl
    {
        public void Obecni(Klient klient);
        public void Byli(Klient klient);
        public void Wszyscy(Klient klient);
    }
}
