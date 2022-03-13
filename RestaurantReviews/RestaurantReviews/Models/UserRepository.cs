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
            try
            {
                using (MySqlConnection conn = ConnectionFactory.CreateConnection())
                {
                    string sql = "select id, email, first_name, last_name, role from user where e-mail=@email and password=@password";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
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
                        user.FirstName = dateReader.GetString("first_name");
                        user.LastName = dateReader.GetString("last_name");
                        string role = dateReader.GetString("role");
                        user.Role = (Role)Enum.Parse(typeof(Role), role);
                    }
                    return user;
                }
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public bool SaveUser(User user)
        {
            try
            {
                using (MySqlConnection conn = ConnectionFactory.CreateConnection())
                {
                    string sql = "insert into user (email, password, first_name, last_name, role) values(@emal, @password, @first_name, @last_name, @role)";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("email", user.Email);
                    cmd.Parameters.AddWithValue("password", user.Password);
                    cmd.Parameters.AddWithValue("first_name", user.FirstName);
                    cmd.Parameters.AddWithValue("last_name", user.LastName);
                    cmd.Parameters.AddWithValue("role", user.Role.ToString());

                    conn.Open();

                    int result = cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
      
        public void DeleteUser(User user)
        {

        }

        public List<User> findAll()
        {
            try
            {
                using (MySqlConnection conn = ConnectionFactory.CreateConnection())
                {
                    List<User> users = new List<User>();
                    string sql = "select id, email, first_name, last_name, from user where role = 'USER' order by email";
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
            catch (Exception ex)
            {
                return null;       
            }
        }
    }
}
