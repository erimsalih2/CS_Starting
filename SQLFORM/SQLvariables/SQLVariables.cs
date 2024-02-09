using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace SQLFORM.SQLvariables
{
    internal class SQLVariables
    {
        public static SqlConnection connect=new SqlConnection("Data Source=DESKTOP-10DIGTP;Initial Catalog=OgrenciDB;Integrated Security=True");
        


       public static  void CheckConnection(SqlConnection TempConnection)
        {

            if (TempConnection.State==ConnectionState.Closed)
            {
                TempConnection.Open();
            }
            else
            {
                
            }
        }
    }
}
