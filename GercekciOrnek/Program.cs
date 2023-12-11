using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GercekciOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CustomerManager customerManager = new CustomerManager();
            //customerManager.Add(new OracleServerCustomerDal());
            InterfaceGercekHayat[] yeni = new InterfaceGercekHayat[3] 
            {
                new OracleServerCustomerDal(),
                new MysqlServerCustomerDal(),
                new SqlServerCustomerDal() 
            };
            foreach (var item in yeni)
            {
                item.Add(); 
                item.Update();
            }

        }
    }
}
