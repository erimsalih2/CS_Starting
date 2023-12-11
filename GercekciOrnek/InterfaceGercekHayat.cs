using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GercekciOrnek
{
    internal interface InterfaceGercekHayat
    {
        void Add();
        void Update();
        void Delete();
    }


    class SqlServerCustomerDal : InterfaceGercekHayat
    {
        public void Add()
        {
            Console.WriteLine("Sql Added");
        }

        public void Delete()
        {
            Console.WriteLine("Sql deleted");
        }

        public void Update()
        {
            Console.WriteLine("Sql updated");
        }

    }
    class OracleServerCustomerDal : InterfaceGercekHayat
    {
        public void Add()
        {
            Console.WriteLine("oracle Added");
        }

        public void Delete()
        {
            Console.WriteLine("oracle deleted");
        }

        public void Update()
        {
            Console.WriteLine("oracle updated");
        }

    }
    class MysqlServerCustomerDal : InterfaceGercekHayat
    {
        public void Add()
        {
            Console.WriteLine("Mysql Added");
        }

        public void Delete()
        {
            Console.WriteLine("Mysql deleted");
        }

        public void Update()
        {
            Console.WriteLine("Mysql updated");
        }

    }
    class CustomerManager
    {
        public void Add(InterfaceGercekHayat isim)
        {
            isim.Add();
        }
    }

}
