using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tranings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[,] arr = new int[3, 4] { {0,0,0,0 },{ 0, 0, 0, 0 },{ 0, 0, 0, 0 } };
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    Console.WriteLine("arr[{0},{1}] Degerini giriniz: ",i,j);
                    arr[i,j] = Convert.ToInt32(Console.ReadLine());
                }
                

            }
           for(int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("arr[{0}{1}]={2}\n", i, j, arr[i,j]);
                }
                Console.WriteLine();
            }
            for(int i = 0;i < 3; i++)
            {
                int toplam = 0;
                for (int j = 0; j < 4; j++)
                {
                    toplam+= arr[i,j];
                }
                Console.WriteLine("ilk satirin toplami:{0} \nIlk satirin ortalamasi{1} ",toplam,toplam/4);
            }
            for (int i = 0; i < 4; i++)
            {
                int toplam = 0;
                for (int j = 0; j < 3; j++)
                {
                    toplam += arr[j, i];
                }
                Console.WriteLine("ilk sutünün toplami:{0} \nIlk sutünün ortalamasi{1} ", toplam, toplam / 3);
            }

            for(int i = 0;i<3 ; i++)
            {
                int temp = 0;
                for (int j = 0; j < 4; j++)
                {
                    if (arr[i,j] > temp)
                    {
                        temp = arr[i,j];
                    }
                    Console.WriteLine("Toplam {0} yildiz yazdirilicak bu arr[{1}] satirinin en buyuk sayisidir ayni zamanda", temp,i);
                for(int x = 0; x < temp; x++)
                    {
                        Console.Write('*');
                    }

                }
            }
        }
        
        
        
    }
}
