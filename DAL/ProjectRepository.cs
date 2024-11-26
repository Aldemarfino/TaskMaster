using ENTITY;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace DAL
{
    public class ProjectRepository : BaseRepository<Project>
    {
        UserRepository userRepository;
        public ProjectRepository() 
        {
            userRepository = new UserRepository();
        }
        
        
        protected override Project Mapper(SqlDataReader reader)
        {
            int idProject = reader.GetInt32(0);
            string name = reader.GetString(1);
            string description = reader.IsDBNull(2) ? null : reader.GetString(2);
            DateTime startDate = reader.GetDateTime(3);
            DateTime deadline = reader.GetDateTime(4);
            string state = reader.GetString(5);
            byte[] fileContent = reader.IsDBNull(6) ? null : reader["Archivo"] as byte[];

            User user = userRepository.GetByUsername(reader.GetString(7));
            return new Project(idProject, name, description, startDate, deadline, state, fileContent, user);
        }

        public Project GetById(int id)
        {
            string ssql = "Select * From Proyectos Where Id_Proyecto = @Id_Proyecto";
            SqlCommand cmd = new SqlCommand(ssql, _connection);
            cmd.Parameters.AddWithValue("@Id_Proyecto", id);
            _connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            Project project = new Project();
            if (reader.Read())
            {
                project = Mapper(reader);
            }
            else
            {
                project = null;
            }
            _connection.Close();
            return project;
        }

        public List<Project> GetProjectsByUser(string username)
        {
            List<Project> projects = new List<Project>();
            string ssql = "SELECT * FROM [dbo].[Proyectos] WHERE [Usuario_Creador] = @UsuarioCreador";
            SqlCommand cmd = new SqlCommand(ssql, _connection);
            cmd.Parameters.AddWithValue("@UsuarioCreador", username);
            _connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                projects.Add(Mapper(reader));
            }
            _connection.Close();
            return projects;
        }
    }
}
