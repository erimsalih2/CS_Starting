using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormApp1
{
    internal class Yorum
    {
        public string AdSoyad { get; set; }
        public DateTime YorumYazilmaTarihi { get; set; }
        public string GoreceliZaman {
            get
            {
                TimeSpan sure = DateTime.Now - YorumYazilmaTarihi;
                if(sure.TotalSeconds<20)
                {
                    return "Şimdi";
                }
                else if(sure.TotalSeconds<60){
                    return sure.Seconds + "Sn Önce";
                }
                else if (sure.TotalMinutes < 60)
                {
                    return sure.Minutes + "dk Önce";
                }

                return sure.Days + " gün" + sure.Hours + " saat" + sure.Minutes + " dk önce";
            }
            
        }
        public Yorum()
        {
            YorumYazilmaTarihi= DateTime.Now;
        }
    }
}
