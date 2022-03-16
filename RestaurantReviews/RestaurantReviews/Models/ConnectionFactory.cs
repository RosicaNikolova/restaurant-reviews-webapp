using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReviews.Models
{
    public class ConnectionFactory
    {
        public static MySqlConnection CreateConnection()
        {
            return new MySqlConnection("server=localhost; database=restaurants_db; uid=root; password = 9Rosica9");
        }
    }
}
