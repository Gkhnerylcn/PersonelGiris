using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp35
{
     public class Personel
    {
        public int ScilNo { get; set; }
        public string Ad { get; set; }
        public string SoyAd { get; set; }
        public string Adres { get; set; }
        public DateTime DoğumTarihi { get; set; }
        public DateTime IsegirisTarihi { get; set; }
        public int Telefon { get; set; }

        public string PersonelBilgileri()
        {
            return Ad;


        }

    }
}
