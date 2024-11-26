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

        public bool Save(T entity)
        {
            try
            {
                SqlCommand cmd = entity.SQLCommandInsert(_connection);
                _connection.Open();
                int affectedRows = cmd.ExecuteNonQuery();
                _connection.Close();
                if (affectedRows > 0) return true;
                return false;
            }
            catch (Exception e)
            {
                _connection.Close();
                System.Diagnostics.Debug.WriteLine(e.Message);
                return false;
            }
            
        }

        public List<T> Read()
        {

            List<T> list = new List<T>();
            T entidad = new T();
            string ssql = entidad.SQLCommandSelect();
            SqlCommand cmd = new SqlCommand(ssql, _connection);
            _connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(Mapper(reader));
            }
            _connection.Close();
            return list;
        }

        protected abstract T Mapper(SqlDataReader reader);
    }
}
