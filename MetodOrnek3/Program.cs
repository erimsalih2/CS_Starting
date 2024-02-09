using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarih_saat
{
    internal class Program
    {
        static void Main(string[] args)
        {

            TarihFormat();
           

            //Surehesabı("2023-12-01:2023-09-14");// gun cinsinden
        }

        private static void TarihFormat()
        {
            DateTime simdi = DateTime.Now;
            Console.WriteLine(simdi.ToString());
            Console.WriteLine(simdi.ToShortDateString());
            Console.WriteLine(simdi.ToLongDateString());
            Console.WriteLine(simdi.ToShortTimeString());
            Console.WriteLine(simdi.ToLongTimeString());


            //MM ay(sayı)
            //MMMM ay(yazı)
            //dd gün
            //yyyy yıl
            //hh saat(12saat)
            //HH saat(24 saat)
            Console.WriteLine(simdi.ToString("MM/dd/yyyy MMMM dd - can hh:mm dddd "));
        }

        private static void IleriTarih()
        {
            DateTime bugün = DateTime.Today;
            DateTime birAySonra = bugün.AddMonths(1);
            DateTime birayonce = bugün.AddMonths(-1);
            DateTime birGunSonrasi = bugün.AddDays(1);
            DateTime birGunOncesi = bugün.AddDays(-1);
            Console.WriteLine("bir ay sonrası :" + birAySonra);
            Console.WriteLine("bir ay oncesi :" + birayonce);
            Console.WriteLine("bir gun sonrası :" + birGunSonrasi);
            Console.WriteLine("bir gun oncesi :" + birGunOncesi);
        }
        private static void CikisaNeKadarVar()
        {
            var simdi = DateTime.Now;
            var cikis = Convert.ToDateTime("2023-10-27 23:00:00");
            var cikisim = new DateTime(2023, 12, 02, 23, 0, 0);
            TimeSpan sure = cikis - simdi;
            Console.WriteLine(Convert.ToInt32(sure.TotalMinutes));
        }

        private static void Surehesabı(string x, string y)
        {
            TimeSpan kalansure = Convert.ToDateTime(x) - Convert.ToDateTime(y);
            Console.WriteLine(kalansure.TotalDays);
        }

        private static void FarkliTarih()
        {
            DateTime tarih = Convert.ToDateTime("2019/01/01");

            Console.WriteLine(tarih.ToString());//Veritabanında yıl ay gün şeklinde tutulur
            DateTime mezuniyet = new DateTime(2019, 06, 20);
            Console.WriteLine("Yılın " + mezuniyet.DayOfYear + ". günü ");
        }

        private static void timeAndHour()
        {
            DateTime Bugun = DateTime.Today;
            Console.WriteLine(Bugun.ToString());
            DateTime simdi = DateTime.Now;
            Console.WriteLine(simdi.ToString());
        }

    }
}

