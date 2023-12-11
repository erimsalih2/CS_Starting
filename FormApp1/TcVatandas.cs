using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormApp1
{
    internal class TcVatandas
    {
        public long TCKimlikno { get; set; }
        public string AdSoyad { get; set; }
        public DateTime DogumTarihi { get; set; }
        public  DateTime SistemeKayitTarihi { get; set; }




        public TcVatandas()
        {
            SistemeKayitTarihi = DateTime.Now;
        }
        public string Vizeal()
        {
            int yas = YasHesapla(DogumTarihi);
            if (yas >= 18)
            {
                return "Başvurabilsin";
            }
            else
                return "Başvuramazsın küçüksün";
        }

        private int YasHesapla(DateTime dogumTarihi)
        {
            return DateTime.Today.Year-dogumTarihi.Year;
        }
    }
}
