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
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }


        public User() { }

        public User(int? idUser, string userName, string name, string lastName, string email, string password)
        {
            IdUser = idUser;
            UserName = userName;
            Name = name;
            LastName = lastName;
            Email = email;
            Password = password;
        }

        public SqlCommand SQLCommandInsert(SqlConnection connection)
        {
            string ssql = "INSERT INTO Usuarios(Nombre_Usuario,Nombres,Apellidos,Correo,Contrasena) " +
                "VALUES (@Nombre_Usuario, @Nombres, @Apellidos, @Correo, @Contrasena)";
            SqlCommand cmd = new SqlCommand(ssql, connection);
            cmd.Parameters.AddWithValue("@Nombre_Usuario", this.UserName);
            cmd.Parameters.AddWithValue("@Nombres", this.Name);
            cmd.Parameters.AddWithValue("@Apellidos", this.LastName);
            cmd.Parameters.AddWithValue("@Correo", this.Email);
            cmd.Parameters.AddWithValue("@Contrasena", this.Password);
            return cmd;
        }

        public string SQLCommandSelect()
        {
            return "select * from Usuarios";
        }
    }
}
