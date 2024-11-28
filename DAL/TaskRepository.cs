using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using ENTITY;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DAL
{
    public class TaskRepository : BaseRepository<Task>
    {
        UserRepository userRepository;
        ProjectRepository projectRepository;

        public TaskRepository()
        {
            userRepository = new UserRepository();
            projectRepository = new ProjectRepository();
        }

        protected override Task Mapper(SqlDataReader reader)
        {
            int idTask = reader.GetInt32(0);
            string title = reader.GetString(1);
            string description = reader.IsDBNull(2) ? null : reader.GetString(2);
            DateTime creationDate = reader.GetDateTime(3);
            DateTime? startdate = DateOrNull(reader);
            DateTime deadline = reader.GetDateTime(5);
            string state = reader.GetString(6);
            string priority = reader.GetString(7);
            int percentage = reader.GetInt32(8);

            Project project = projectRepository.GetById(reader.GetInt32(9));
            User user = userRepository.GetByUsername(reader.GetString(10));

            return new Task(idTask, title, description, creationDate, startdate, deadline, state, priority, percentage, project, user);
        }

        private DateTime? DateOrNull(SqlDataReader reader)
        {
            if (reader.IsDBNull(4))
            {
                return null;
            }
            else
            {
                return reader.GetDateTime(4);
            }
        }

        public Task GetById(int id)
        {
            string ssql = "Select * From Tareas Where Id_Tarea = @Id_Tarea";

            SqlCommand cmd = new SqlCommand(ssql, _connection);
            cmd.Parameters.AddWithValue("@Id_Tarea", id);

            _connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            Task task = new Task();
            if (reader.Read())
            {
                task = Mapper(reader);
            }
            else
            {
                task = null;
            }
            _connection.Close();
            return task;
        }

        public List<Task> GetTasksByProject(int projectId)
        {
            List<Task> tasks = new List<Task>();

            string ssql = "SELECT * FROM Tareas WHERE [Id_Proyecto] = @Id_Proyecto " +
                "ORDER BY Fecha_Limite ASC;";

            SqlCommand cmd = new SqlCommand(ssql, _connection);
            cmd.Parameters.AddWithValue("@Id_Proyecto", projectId);

            _connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                tasks.Add(Mapper(reader));
            }
            _connection.Close();
            return tasks;
        }
    }
}
