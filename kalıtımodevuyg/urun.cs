using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalıtımodevuyg
{
    public class urun : baseClass
    {

        public string marka { get; set; } // belirli markalar eklenebilecek
        public string model { get; set; }

        public decimal alisFiyat
        {   //0dan küçük olamaz 
            get { return _alisFiyat; }
            set
            {
                if (value > 0)
                {
                    _alisFiyat = value;
                } else
                {
                    Console.WriteLine("Alış fiyatı 0'dan küçük veya eşit olamaz.");
                }
            }
        }
        private decimal _alisFiyat { get; set; }

        public decimal satisFiyat
        {   //alisFiyattan küçük olamaz
            get { return _satisFiyat; }
            set
            {
                if (value > alisFiyat)
                {
                    _satisFiyat = value;
                } else
                {
                    Console.WriteLine("Ürünün satış, alış fiyatından küçük olamaz.");
                }
            }
        }
        private decimal _satisFiyat { get; set; }

        public decimal kampanya  //kampanya fiyat degeri 0dan küçük olamaz
        {
            get { return _kampanya; }
            set
            {
                if (value > 0)
                {
                    _kampanya = value;
                }
                else
                {
                    Console.WriteLine("Kapmpanya diyatı 0'dan küçük veya eşit olamaz.");
                }
            }
        }
        private decimal _kampanya { get; set; }
    }
}
