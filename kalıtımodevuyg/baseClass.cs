using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalıtımodevuyg
{
    public class baseClass
    {

        public static int sayac = 1; //ilk oluştugu zaman 1 degerini alsın 

        public baseClass()
        {
            _ID = sayac;
            sayac = sayac + 1;
        }

        public int ID {
            get
            {
                return _ID;
            } 
            private set 
            {
               
            }
        }
        private int _ID;

        public string barkod {
            get { return _barkod; }
            set
            {
                bool control = sanalDatabase.databaseBarkodKontrol(value);
                if (!control)
                {
                    _barkod = value;
                } else
                {
                    Console.WriteLine("Bu barkot değeri daha önce zaten bir ürün ile beraber girildi.");
                }
            }
        }
        private string _barkod;
        
        public DateTime olusturmaTarihi { get; set; }
        public int olusturanKullanici { get; set; }

        public DateTime guncellemeTarihi { get; set; }
        public int guncelleyenKullanici { get; set; }

        public bool silindi { get; set; }

       
    }
}
