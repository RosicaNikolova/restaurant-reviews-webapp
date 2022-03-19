﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace RestaurantReviews.Models
{
    public class UserRepository : IUserRepository
    {
        public User FindUser(string email, string password)
        {
            try
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
                        user.Roles = (Role)Enum.Parse(typeof(Role), dateReader.GetString("role"), true);
                    }
                    return user;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public User FindUserByEmail(string email)
        {
            try
            {
                using (MySqlConnection conn = ConnectionFactory.CreateConnection())

                {
                    string sql = "select id from user where email=@email;";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("email", email);
                    conn.Open();
                    User user = null;
                    MySqlDataReader dateReader = cmd.ExecuteReader();
                    if (dateReader.Read())
                    {
                        user = new User();
                        user.Id = dateReader.GetInt32("id");
                    }
                    return user;
                }
            }
            catch (Exception)
            {
                return null;
            }

        }
        public List<User> FindAll()
        {
            try
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
            catch (Exception)
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
                    string sql = "insert into user (email, password, first_name, last_name, role) values(@email, @password, @first_name, @last_name, @role);";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("email", user.Email);
                    cmd.Parameters.AddWithValue("password", user.Password);
                    cmd.Parameters.AddWithValue("first_name", user.FirstName);
                    cmd.Parameters.AddWithValue("last_name", user.LastName);
                    cmd.Parameters.AddWithValue("role", user.Roles.ToString());

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
      
        public bool DeleteUser(User user)
        {
            try
            {
                using (MySqlConnection conn = ConnectionFactory.CreateConnection())
                {
                    string sql = "Delete from user where @id=id";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("id", user.Id);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

       


        //public List<User> FindAllReguralUsers()
        //{
        //    using (MySqlConnection conn = ConnectionFactory.CreateConnection())
        //    {
        //        List<User> users = new List<User>();
        //        string sql = "select id, email, first_name, last_name, from user where role = 'USER' order by email;";
        //        MySqlCommand cmd = new MySqlCommand(sql, conn);

        //        conn.Open();

        //        MySqlDataReader dateReader = cmd.ExecuteReader();
        //        while (dateReader.Read())
        //        {
        //            User user = new User();
        //            user.Id = dateReader.GetInt32("id");
        //            user.Email = dateReader.GetString("email");
        //            user.FirstName = dateReader.GetString("first_name");
        //            user.LastName = dateReader.GetString("last_name");
        //            users.Add(user);
        //        }
        //        return users;
        //    }
        //}


    }
}
