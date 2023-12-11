using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormApp1
{
    internal class AbdVatandas
    {
        public string AdSoyad { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Dil{ get; set; }



        public int Yas
        {
            get
            {
                return DateTime.Now.Year-DogumTarihi.Year;
            }
        }
    }
}
