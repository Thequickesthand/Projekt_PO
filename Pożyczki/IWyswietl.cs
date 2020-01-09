using System;
using System.Collections.Generic;
using System.Text;

namespace Pożyczki
{
    interface IWyswietl
    {
        public void Obecny(Klient klient);
        public void Byly(Klient klient);
        public void Wszyscy(Klient klient);
    }
}
