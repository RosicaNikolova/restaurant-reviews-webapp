using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLibrary.Business
{
    public class ConnectionFactory
    {
        public static MySqlConnection CreateConnection()
        { 
            return new MySqlConnection("Server=studmysql01.fhict.local;Uid=dbi497286;Database=dbi497286;Pwd=9Rosica9");
        }
    }
}
