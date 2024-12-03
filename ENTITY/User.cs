using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class User:IEntityOptions
    {
        public int? IdUser { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public User() { }

        public User(int? idUser, string userName, string password, string name, string lastName, string email)
        {
            IdUser = idUser;
            UserName = userName;
            Password = password;
            Name = name;
            LastName = lastName;
            Email = email;
        }

        public SqlCommand SQLCommandInsert(SqlConnection connection)
        {
                string ssql = "INSERT INTO Usuarios(Nombre_Usuario,Contrasena,Nombres,Apellidos,Correo) " +
                    "VALUES (@Nombre_Usuario, @Contrasena, @Nombres, @Apellidos, @Correo)";
            SqlCommand cmd = new SqlCommand(ssql, connection);
            cmd.Parameters.AddWithValue("@Nombre_Usuario", this.UserName);
            cmd.Parameters.AddWithValue("@Contrasena", this.Password);
            cmd.Parameters.AddWithValue("@Nombres", this.Name);
            cmd.Parameters.AddWithValue("@Apellidos", this.LastName);
            cmd.Parameters.AddWithValue("@Correo", this.Email);
            return cmd;
        }
    }
}
