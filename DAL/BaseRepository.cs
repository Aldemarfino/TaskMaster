using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;

namespace DAL
{
    public abstract class BaseRepository<T> where T : IEntityOptions, new()
    {
        protected readonly SqlConnection _connection;
        
        public BaseRepository()
        {
            string cadenaConexion = "Server=.\\SQLEXPRESS;Database=TaskMaster;Trusted_Connection=True;";
            _connection = new SqlConnection(cadenaConexion);
        }

        public string Save(T entity)
        {
            try
            {
                SqlCommand cmd = entity.SQLCommandInsert(_connection);
                _connection.Open();
                int affectedRows = cmd.ExecuteNonQuery();
                _connection.Close();
                if (affectedRows > 0) return "Guardado exitosamente";
                return "Ocurrió un problema";
            }
            catch (SqlException e)
            {
                _connection.Close();
                return "Ocurrió un problema al tratar de guardar la entidad";
            }
            catch (Exception e )
            {
                _connection.Close();
                return $"{e.Message}";
            }
            
        }

        protected abstract T Mapper(SqlDataReader reader);
    }
}
