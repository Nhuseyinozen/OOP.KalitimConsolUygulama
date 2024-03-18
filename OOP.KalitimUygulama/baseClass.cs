using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.KalitimUygulama
{
    public class baseClass // Temel değerler bulunduruacak.
    {
        public static int sayac = 1;// İlk oluştuğu zaman değer 1 olucak.

        public baseClass() // yapıcı metot.
        {
            _id = sayac;
            sayac = sayac + 1;
        }

        private int _id; // Kapsülleme.
        public int id
        {
            //Değeri içeriden dışarıya gönderme.
            get
            {
                return _id;
            }
            //Bir sayaç içerisindeki sıralı değeri çekicez.
            private set // Dışarıdan giriş yapılmayacak.
            {
                //_id = sayac;
                //sayac = sayac + 1;
                // set alanı private değer ataması yapılamaz. Yapıcı metot ile yapıcaz.
            }
        }

        private string _barkod;
        public string barkod
        {
            get
            {
                return _barkod;
            }

            set
            {
                bool kontrolIslemi = sanalDatabase.DatabaseBarkodKontrol(value);
                if (!kontrolIslemi) // değer sanal database içerisinde yok.
                {
                    _barkod = value;
                }
                else
                {
                    Console.WriteLine("Sanal database içerisinde bu barkod değeri daha önce girilmiştir.");
                }
            }
        }
        public DateTime olusturmaTarih { get; set; }
        public int olusturanKullanici { get; set; }

        public DateTime guncellemeTarih { get; set; }
        public int guncelleyenKullanici { get; set; }

        public bool silindi { get; set; }



    }
}
