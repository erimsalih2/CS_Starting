using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankForm
{
    abstract internal class BankAccount
    {
        public long HesapNo { get; set; }
        public int SubeKodu { get; set; }
        public string Iban { get; set; }
        public decimal Bakiye { get; set; }


        public virtual string ParaCek(decimal tutar)
        {
            Bakiye-=tutar;
            return "Hesabınızdan " + tutar + "Tl çekilmiştir.Güncel Bakiyeniz: " + Bakiye;
        }
        public virtual string ParaYatir(decimal tutar)
        {
            Bakiye += tutar;
            return "Hesabınıza " + tutar + "Tl yatirilmiştir.Güncel Bakiyeniz: " + Bakiye;
        }
    }
    class VadesizHesap:BankAccount
    {
        public override string ParaCek(decimal tutar)
        {
            if (Bakiye < tutar)
            {
                return "Yetersiz Bakiye";
            }
            if(tutar%5==0)
            {
                return base.ParaCek(tutar);
            }
            else
            {
                return "5 ve 5'in katlarını çekebilirsiniz";
            }
        }
    }
    class VadeliHesap:BankAccount
    {
        public DateTime VadeBaslangicTarihi { get; set; }
        public int VadeGunSayisi { get; set; }
        public DateTime VadeSonTarihi {
            get
            {
                return VadeBaslangicTarihi.AddDays(VadeGunSayisi);
            }
                 }
        public override string ParaCek(decimal tutar)
        {
            if (DateTime.Today.Date != VadeSonTarihi.Date)
            {
                return "Vade Sonu tarihini bekleyiniz";
            }
            else if (Bakiye < tutar)
            {
                return "Yetersiz Bakiye";

            }
            else if (tutar % 5 != 0)
            {

                return "5 ve 5 in katlarini cekebilirsiniz";
            }
            else { return base.ParaCek(tutar) ;}
        }
        public override string ParaYatir(decimal tutar)
        {
            if (DateTime.Today.Date == VadeSonTarihi)
            {
                return base.ParaYatir(tutar);
            }
            else
            {
                return "Vade sonu tarihini bekleyiniz";
            }
        }
    }
}
