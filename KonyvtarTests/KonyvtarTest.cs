using Microsoft.VisualStudio.TestTools.UnitTesting;
using Konyvtar;

namespace KonyvtarTests
{
    [TestClass]
    public class KonyvtarTest
    {
        [TestMethod]
        public void Kolcsonzes_ErvenyesOsszeggel_KolcsonzottKonyvekFrissites()
        {
            // Elrendez�s
            int kiKolcsonoz = 2;           
            double elvartErtek = 2;
            KolcsonzoSzemely ksz = new KolcsonzoSzemely("Figura M�ria");

            // M�velet
            ksz.Kolcsonoz(kiKolcsonoz);

            // Ellen�rz�s
            double jelenlegiOsszeg = ksz.GetKolcsonzottKonyvekSzama();
            Assert.AreEqual(elvartErtek, jelenlegiOsszeg, 0.001, "K�lcs�nz�tt k�nyvek sz�m�t�sa k�lcs�nz�s eset�n nem megfelel�.");
        }

        [TestMethod]
        public void Visszahoz_ErvenyesOsszeggel_KolcsonzottKonyvekFrissites()
        {
            // Elrendez�s
            int kiKolcsonoz = 2;
            int visszahoz = 1;
            double elvartErtek = 1;
            KolcsonzoSzemely ksz = new KolcsonzoSzemely("Figura M�ria");

            // M�velet
            ksz.Kolcsonoz(kiKolcsonoz);
            ksz.Visszahoz(visszahoz);

            // Ellen�rz�s
            double jelenlegiOsszeg = ksz.GetKolcsonzottKonyvekSzama();
            Assert.AreEqual(elvartErtek, jelenlegiOsszeg, 0.001, "K�lcs�nz�tt k�nyvek sz�m�t�sa k�lcs�nz�s eset�n nem megfelel�.");
        }

        [TestMethod]
        public void Kolcsonoz_KolcsonozniKivantDarabNagyobbMintAMaxKolcsonozhetoKonyvek_ArgumentumHiba()
        {
            // Elrendez�s
            int kiKolcsonoz = 4;            
            KolcsonzoSzemely ksz = new KolcsonzoSzemely("Figura M�ria");

            // M�velet �s ellen�rz�s            
            try
            {
                ksz.Kolcsonoz(kiKolcsonoz);
            }
            catch (System.ArgumentOutOfRangeException e)
            {
                // Ellen�rz�s
                StringAssert.Contains(e.Message, ksz.KolcsonzesnagyobbMaxKolcsonozheto);
                return;
            }
            Assert.Fail("A v�rt kiv�tel nem ker�lt el�.");
        }

        [TestMethod]
        public void Visszahoz_VisszahozniKivantKonyvekSzamaNagyobbMintKikolcsonzottKonyvek_ArgumentumHiba()
        {
            // Elrendez�s
            int kiKolcsonoz = 2;
            int visszahoz = 3;            
            KolcsonzoSzemely ksz = new KolcsonzoSzemely("Figura M�ria");
            
            // M�velet �s ellen�rz�s            
            try
            {
                ksz.Kolcsonoz(kiKolcsonoz);
                ksz.Visszahoz(visszahoz);
            }
            catch (System.ArgumentOutOfRangeException e)
            {
                // Ellen�rz�s
                StringAssert.Contains(e.Message, ksz.VisszahoKonyvekSzamaNagyobbMintKikolcsonzott);
                return;
            }
            Assert.Fail("A v�rt kiv�tel nem ker�lt el�.");
        }

    }
}
