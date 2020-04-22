using System;

namespace Konyvtar
{
    class Program
    {
        static void Main(string[] args)
        {
           
            KolcsonzoSzemely ksz = new KolcsonzoSzemely("Konyves Lajos");

            ksz.Kolcsonoz(2);
            ksz.Visszahoz(1);
            Console.WriteLine(ksz.GeGetKolcsonzoSzemelyNeve() + " eddig " + ksz.GetKolcsonzottKonyvekSzama() + " könyvet kölcsönzött ki.");
        }
    }
}
