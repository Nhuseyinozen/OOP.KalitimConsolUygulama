using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.KalitimUygulama
{
    public class urun : baseClass
    {
        //Belirtmiş olduğumuz markalar içerisinden ürün eklenecek.
        public string marka { get; set; }
        public string model { get; set; }

        #region Alış fiyatı 0 dan küçük olmamalı !!


        private decimal _alisFiyat;
        public decimal alisFiyat
        {
            get { return _alisFiyat; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Alış fiyatı 0'dan küçük veya eşit olamaz !");
                }
                else
                {
                    _alisFiyat = value;
                }
            }
        }
        #endregion

        #region Satış fiyatı alış fiyatından küçük olamaz.

        private decimal _satisFiyat;
        public decimal satisFiyat
        {
            get { return satisFiyat; }
            set
            {
                if (_alisFiyat > value)
                {
                    Console.WriteLine("Satış fiyatı alış fiyatından küçük olamaz!!!");
                }
                else
                { _satisFiyat = value; }
            }
        }
        #endregion

        #region Kampanya fiyatı değeri 0 dan küçük olamaz.

        private decimal _kampanyaFiyat;
        public decimal kampanyaFiyat 
        {
            get { return _kampanyaFiyat; }
            set
            {
                if (value <= 0) 
                {
                    Console.WriteLine("Kampanya fiyatı 0'dan küçük veya eşit olamaz !");
                }
                else
                {
                    _kampanyaFiyat = value;
                }
            }
        }
        #endregion

    }
}
