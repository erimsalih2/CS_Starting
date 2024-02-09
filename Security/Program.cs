using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Net.Security;

namespace Security
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanicidan sifreyi aliyoruz
            Console.WriteLine("Sifrenizi girin: ");
            string password = Console.ReadLine();

            //Şifreleme
            string SifrelemeVar = Sifreleme(password);
            Console.WriteLine("Sifrelenmis Sifre: " + SifrelemeVar);

            //Şifreyi çözme 
            string SifreiptalVar=Sifreiptal(SifrelemeVar);
            Console.WriteLine("Cozulen Sifre: " + SifreiptalVar);
        }
        static string Sifreleme(string password)
        {
            char[] SifreKarakterleri=password.ToCharArray();
            for(int i =0;i<SifreKarakterleri.Length;i++)
            {
                SifreKarakterleri[i] = (char)(SifreKarakterleri[i] + 1);
            }
            return new string(SifreKarakterleri);
        }
        static string Sifreiptal(string encryptedPassword)
        {
            //şifreyi çözme işlemi

            char[] SifreKarakterleri= encryptedPassword.ToCharArray();

#pragma warning disable CS0162 // Unreachable code detected
            for(int i = 0;i<SifreKarakterleri.Length;i++)
            {
                SifreKarakterleri[i] = (char)(SifreKarakterleri[i] - 1);

                return new string(SifreKarakterleri);
            }
#pragma warning restore CS0162 // Unreachable code detected
        }
    }
}
