using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rastgele
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayac = 0;
            
            
            Random random= new Random();
            ArrayList adamlar;
            adamlar = new ArrayList();
            Console.WriteLine("Toplam kaptan sayisini giriniz: ");

            int Kackisi = Convert.ToInt32(Console.ReadLine());
            string[] list=new string[Kackisi];
            for (int i=0; i<Kackisi; i++)
            {
                Console.WriteLine("{0}. Kaptanı giriniz",i+1);
                list[i]=Console.ReadLine();
            }
            
            
            while (sayac<4)
            {



                int rastgelesayi = random.Next(4);
                if (adamlar.Contains(list[rastgelesayi]))
                {

                    


                }
                else
                {
                    adamlar.Add(list[rastgelesayi]);
                    sayac++;
                }


            }
            string[] strings = new string[Kackisi];
            sayac = 0; 
            foreach(string i in adamlar)
            {
                
                
                Console.WriteLine("{0}. seçim hakkına ait kaptan: {1}",sayac+1,i);
                strings[sayac] = i;
                sayac++;
            }
            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine("ilk seçim sahibi {0}", strings[i]);
            }





            Console.ReadLine();
        }
    }
}
