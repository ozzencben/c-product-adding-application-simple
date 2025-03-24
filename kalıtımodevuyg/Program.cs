using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalıtımodevuyg
{
    internal class Program
    {
        static void Main(string[] args)
        {

            PC P1 = new PC();
            P1.marka = "lenovo";
            P1.model = "z50";
            P1.islemci = "i5";
            P1.alisFiyat = 1000m;
            P1.satisFiyat = 1500m;
            P1.kampanya = 1200m;
            P1.barkod = "1234567890";

            sanalDatabase.yeniUrunEkle(P1);

            PC P2 = new PC();
            P2.marka = "Casper";
            P2.model = "z10";
            P2.islemci = "i7";
            P2.alisFiyat = 1800m;
            P2.satisFiyat = 2400m;
            P2.kampanya = 2100m;
            P2.barkod = "1234567890";

            sanalDatabase.yeniUrunEkle(P2);

            Console.WriteLine(sanalDatabase.database.Count);

        }
    }
}
