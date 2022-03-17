using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace RestaurantReviews.Models
{
    public class UserRepository
    {
        public User FindUser(string email, string password)
        {

            using (MySqlConnection conn = ConnectionFactory.CreateConnection())

            {
                string sql = "select id, email, first_name, last_name, role from user where @email=email and @password=password;";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("email", email);
                cmd.Parameters.AddWithValue("password", password);


                conn.Open();
                User user = null;
                MySqlDataReader dateReader = cmd.ExecuteReader();
                if (dateReader.Read())
                {
                    user = new User();
                    user.Id = dateReader.GetInt32("id");
                    user.Email = dateReader.GetString("email");
                    user.FirstName = dateReader.GetString("first_name");
                    user.LastName = dateReader.GetString("last_name");
                    user.Roles = (Role)Enum.Parse(typeof(Role), dateReader.GetString("role"), true) ;
                }
                return user;
            }
        
        }

        public User FindUserByEmail(string email)
        {
            using (MySqlConnection conn = ConnectionFactory.CreateConnection())

            {
                string sql = "select id, email, first_name, last_name, role from user where @email=email;";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("email", email);
                
                conn.Open();
                User user = null;
                MySqlDataReader dateReader = cmd.ExecuteReader();
                if (dateReader.Read())
                {
                    user = new User();
                    user.Id = dateReader.GetInt32("id");
                    user.Email = dateReader.GetString("email");
                    user.FirstName = dateReader.GetString("first_name");
                    user.LastName = dateReader.GetString("last_name");

                }
                return user;
            }

        }

        public void SaveUser(User user)
        {
                using (MySqlConnection conn = ConnectionFactory.CreateConnection())
                {
                    string sql = "insert into user (email, password, first_name, last_name, role) values(@email, @password, @first_name, @last_name, @role);";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("email", user.Email);
                    cmd.Parameters.AddWithValue("password", user.Password);
                    cmd.Parameters.AddWithValue("first_name", user.FirstName);
                    cmd.Parameters.AddWithValue("last_name", user.LastName);
                    cmd.Parameters.AddWithValue("role", user.Roles.ToString());

                    conn.Open();

                    int result = cmd.ExecuteNonQuery();
                 
                }
        }
      
        public void DeleteUser(User user)
        {
            using (MySqlConnection conn = ConnectionFactory.CreateConnection())
            {
                string sql = "Delete from user where @id=id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("id", user.Id);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<User> findAll()
        {
                using (MySqlConnection conn = ConnectionFactory.CreateConnection())
                {
                    List<User> users = new List<User>();
                    string sql = "select id, email, first_name, last_name, role from user where role = 'USER' order by email;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    conn.Open();

                    MySqlDataReader dateReader = cmd.ExecuteReader();
                    while (dateReader.Read())
                    {
                        User user = new User();
                        user.Id = dateReader.GetInt32("id");
                        user.Email = dateReader.GetString("email");
                        user.FirstName = dateReader.GetString("first_name");
                        user.LastName = dateReader.GetString("last_name");
                        user.Roles = (Role)Enum.Parse(typeof(Role), dateReader.GetString("role"), true);
                        users.Add(user);
                    }
                    return users;
                } 
        }



        public List<User> FindAllReguralUsers()
        {
            using (MySqlConnection conn = ConnectionFactory.CreateConnection())
            {
                List<User> users = new List<User>();
                string sql = "select id, email, first_name, last_name, from user where role = 'USER' order by email;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();

                MySqlDataReader dateReader = cmd.ExecuteReader();
                while (dateReader.Read())
                {
                    User user = new User();
                    user.Id = dateReader.GetInt32("id");
                    user.Email = dateReader.GetString("email");
                    user.FirstName = dateReader.GetString("first_name");
                    user.LastName = dateReader.GetString("last_name");
                    users.Add(user);
                }
                return users;
            }
        }


    }
}
