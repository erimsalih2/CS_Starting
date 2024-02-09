using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable
{
    internal class Program
    {
        static void Main(string[] args)
        {
#pragma warning disable CS0219 // Variable is assigned but its value is never used
            string a = null;
#pragma warning restore CS0219 // Variable is assigned but its value is never used
            //string bir class olduğu için null olabilir.
            //int ve double gibi değişkenler null değerini alamaz.

#pragma warning disable CS0219 // Variable is assigned but its value is never used
            Nullable<int>  sayi= null;
#pragma warning restore CS0219 // Variable is assigned but its value is never used
#pragma warning disable CS0219 // Variable is assigned but its value is never used
            int? bosSayi=null;
#pragma warning restore CS0219 // Variable is assigned but its value is never used
#pragma warning disable CS0219 // Variable is assigned but its value is never used
            DateTime? dateSayi = null;
#pragma warning restore CS0219 // Variable is assigned but its value is never used
            

        }
    }
}
