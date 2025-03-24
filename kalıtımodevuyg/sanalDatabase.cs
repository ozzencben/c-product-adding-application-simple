using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalıtımodevuyg
{
    public static class sanalDatabase
    {

        public static ArrayList database = new ArrayList();

        public static void yeniUrunEkle(baseClass data)
        {
            if (data != null && !string.IsNullOrEmpty(data.barkod))
            {
                database.Add(data);
            }
        }

        public static bool databaseBarkodKontrol(string barkod)
        {
            bool kontrol = false;
            for (int i = 0; i < database.Count; i++)
            {
                baseClass bc = (baseClass)database[i];
                if (bc.barkod == barkod)
                {
                    kontrol = true;
                } 
            }
            return kontrol;
        }
    }
}
