using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.KalitimUygulama
{
    public static class sanalDatabase
    {
        private static ArrayList Database = new ArrayList();

        public static void yeniUrunEkle(baseClass data)
        {
            if (data != null && !string.IsNullOrEmpty(data.barkod))
            {
                Database.Add(data.barkod);
            }
        }
        public static bool DatabaseBarkodKontrol(string barkod)
        {
            bool kontrolIslemi = false;
            if (Database.Count > 0 && Database != null)
            {
                for (int i = 0; i < Database.Count; i++)
                {
                    baseClass bc = (baseClass)Database[i];
                    if (bc.barkod == barkod)
                    {
                        kontrolIslemi = true;
                    }
                }
            }
            return kontrolIslemi;
        }

    }
}
