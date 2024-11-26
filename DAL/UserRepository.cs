using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ENTITY;

namespace DAL
{
    public class UserRepository : BaseRepository<User>
    {
        public UserRepository() { }
        protected override User Mapper(SqlDataReader reader)
        {
            int idUser = reader.GetInt32(0);
            string userName = reader.GetString(1);
            string name = reader.GetString(2);
            string lastName = reader.GetString(3);
            string email = reader.GetString(4);
            string password = reader.GetString(5);
            return new User(idUser, userName, name, lastName, email, password);
        }

        public User GetByUsername(string username)
        {
            string ssql = "Select * From Usuarios Where Nombre_Usuario = @Nombre_Usuario";
            SqlCommand cmd = new SqlCommand(ssql, _connection);
            cmd.Parameters.AddWithValue("@Nombre_Usuario", username);
            _connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            
            User user = new User();
            if (reader.Read())
            {
                user = Mapper(reader);
            }
            else
            {
                user = null;
            }
            _connection.Close();
            return user;
        }
    }
}
