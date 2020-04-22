using System;
using System.Collections.Generic;
using System.Text;

namespace Konyvtar
{
    public class KolcsonzoSzemely
    {
        public const int MaxKolcsonozhetoKonyvekSzam = 3;
        private string Nev { get; set; }
        private int KolcsonzottKonyvekSzama = 0;

        public KolcsonzoSzemely() {}
        public KolcsonzoSzemely(string nev)
        {
            Nev = nev;
        }

        public string GeGetKolcsonzoSzemelyNeve()
        {
            return Nev;
        }
        public int GetKolcsonzottKonyvekSzama() 
        {
            return KolcsonzottKonyvekSzama;
        }
        public string KolcsonzesnagyobbMaxKolcsonozheto = "A kölcsönözni kívánt könyvek száma meghaladja a maximálisan kölcsönözhetők darabszámát";
        public void Kolcsonoz(int darab)
        {
            if (darab > MaxKolcsonozhetoKonyvekSzam)
            {
                throw new ArgumentOutOfRangeException("darab", darab, KolcsonzesnagyobbMaxKolcsonozheto);
            }
            KolcsonzottKonyvekSzama += darab;
        }
        public string VisszahoKonyvekSzamaNagyobbMintKikolcsonzott = "A visszahozni kívánt könyvelk száma meghaladja a kikölcsönzött könyvek számát";
        public void Visszahoz(int darab)
        {
            if (darab > KolcsonzottKonyvekSzama)
            {
                throw new ArgumentOutOfRangeException("darab", darab, VisszahoKonyvekSzamaNagyobbMintKikolcsonzott);
            }
            KolcsonzottKonyvekSzama -= darab;
        }
    }
}
