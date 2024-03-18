using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.KalitimUygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bilgisayar B1 = new bilgisayar();
            //B1.id baseClass sıralı şekilde atama yapılacak. İLK DEĞER "1";
            B1.marka = "HP";
            B1.model = "Victus";
            B1.islemci = "i5";
            B1.alisFiyat = 1000;
            B1.satisFiyat = 2000;
            B1.kampanyaFiyat = 500;
            B1.barkod = "12345";

            sanalDatabase.yeniUrunEkle(B1);


        }
    }
}
