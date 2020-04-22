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
            // Elrendezés
            int kiKolcsonoz = 2;           
            double elvartErtek = 2;
            KolcsonzoSzemely ksz = new KolcsonzoSzemely("Figura Mária");

            // Mûvelet
            ksz.Kolcsonoz(kiKolcsonoz);

            // Ellenõrzés
            double jelenlegiOsszeg = ksz.GetKolcsonzottKonyvekSzama();
            Assert.AreEqual(elvartErtek, jelenlegiOsszeg, 0.001, "Kölcsönzött könyvek számítása kölcsönzés esetén nem megfelelõ.");
        }

        [TestMethod]
        public void Visszahoz_ErvenyesOsszeggel_KolcsonzottKonyvekFrissites()
        {
            // Elrendezés
            int kiKolcsonoz = 2;
            int visszahoz = 1;
            double elvartErtek = 1;
            KolcsonzoSzemely ksz = new KolcsonzoSzemely("Figura Mária");

            // Mûvelet
            ksz.Kolcsonoz(kiKolcsonoz);
            ksz.Visszahoz(visszahoz);

            // Ellenõrzés
            double jelenlegiOsszeg = ksz.GetKolcsonzottKonyvekSzama();
            Assert.AreEqual(elvartErtek, jelenlegiOsszeg, 0.001, "Kölcsönzött könyvek számítása kölcsönzés esetén nem megfelelõ.");
        }

        [TestMethod]
        public void Kolcsonoz_KolcsonozniKivantDarabNagyobbMintAMaxKolcsonozhetoKonyvek_ArgumentumHiba()
        {
            // Elrendezés
            int kiKolcsonoz = 4;            
            KolcsonzoSzemely ksz = new KolcsonzoSzemely("Figura Mária");

            // Mûvelet és ellenõrzés            
            try
            {
                ksz.Kolcsonoz(kiKolcsonoz);
            }
            catch (System.ArgumentOutOfRangeException e)
            {
                // Ellenõrzés
                StringAssert.Contains(e.Message, ksz.KolcsonzesnagyobbMaxKolcsonozheto);
                return;
            }
            Assert.Fail("A várt kivétel nem került elõ.");
        }

        [TestMethod]
        public void Visszahoz_VisszahozniKivantKonyvekSzamaNagyobbMintKikolcsonzottKonyvek_ArgumentumHiba()
        {
            // Elrendezés
            int kiKolcsonoz = 2;
            int visszahoz = 3;            
            KolcsonzoSzemely ksz = new KolcsonzoSzemely("Figura Mária");
            
            // Mûvelet és ellenõrzés            
            try
            {
                ksz.Kolcsonoz(kiKolcsonoz);
                ksz.Visszahoz(visszahoz);
            }
            catch (System.ArgumentOutOfRangeException e)
            {
                // Ellenõrzés
                StringAssert.Contains(e.Message, ksz.VisszahoKonyvekSzamaNagyobbMintKikolcsonzott);
                return;
            }
            Assert.Fail("A várt kivétel nem került elõ.");
        }

    }
}
