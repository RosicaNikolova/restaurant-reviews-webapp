using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace RestaurantReviews.Models
{
    public class UserRepository
    {

        public User FindUser(string username, string password)
        {
            MySqlConnection conn = new MySqlConnection("server=localhostrestaurants; datebase=restaurants_db; uid=root; password = 9Rosica9");
            string sql = "select id, email, firt_name, last_name, role from user where e-mail=@email and password=@password";
            MySqlCommand cmd = new MySqlCommand(sql,conn);
            cmd.Parameters.AddWithValue("username", username);
            cmd.Parameters.AddWithValue("password", password);

            conn.Open();
            User user = null;
            MySqlDataReader dateReader = cmd.ExecuteReader();
            if (dateReader.Read())
            {
                user = new User();
                user.Id = dateReader.GetInt32("id");
                user.Email = dateReader.GetString("email");
                user.FirstName = dateReader.GetString("fisrt_name");
                user.LastName = dateReader.GetString("last_name");
                string role = dateReader.GetString("role");
                user.Role = (Role)Enum.Parse(typeof(Role), role);
            }

            conn.Close();

            return user;
            
        }

        public void SaveUser(User user)
        {

        }
      
        public void DeleteUser(User user)
        {

        }
    }
}
