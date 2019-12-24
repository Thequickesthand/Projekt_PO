using System;
using System.Collections.Generic;

namespace Pożyczki
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Klient> BazaKlientow = new Dictionary<int, Klient>();
            Dictionary<int, Klient> BazaDluznikow = new Dictionary<int, Klient>();
            Menu.MenuGlowne();
            Console.ReadKey();
        }
    }
}
