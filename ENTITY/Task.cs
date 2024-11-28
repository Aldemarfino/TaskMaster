using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Task:IEntityOptions
    {
        public int IdTask { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime Deadline { get; set; }
        public string State { get; set; }
        public string Priority { get; set; }
        public int Percentage { get; set; }
        public Project Project { get; set; }
        public User User { get; set; }

        public Task(int idTask, string title, string description, DateTime creationDate, DateTime? startDate, DateTime deadline, 
                    string state, string priority, int percentage, Project project, User user)
        {
            IdTask = idTask;
            Title = title;
            Description = description;
            CreationDate = creationDate;
            StartDate = startDate;
            Deadline = deadline;
            State = state;
            Priority = priority;
            Percentage = percentage;
            Project = project;
            User = user;
        }

        public Task(){}

        public SqlCommand SQLCommandInsert(SqlConnection connection)
        {
            string ssql = "INSERT INTO Tareas " +
                "VALUES (@Titulo, @Descripcion, @Fecha_Creacion, @Fecha_Inicio, " +
                "@Fecha_Limite, @Estado, @Prioridad, @Porcentaje, @Id_Proyecto, @Nombre_Usuario)";
            SqlCommand cmd = connection.CreateCommand();
            cmd.Parameters.AddWithValue("@Titulo", Title);
            cmd.Parameters.AddWithValue("@Descripcion", Description ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Fecha_Creacion", CreationDate);
            cmd.Parameters.AddWithValue("@Fecha_Inicio", StartDate ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Fecha_Limite", Deadline);
            cmd.Parameters.AddWithValue("@Estado", State);
            cmd.Parameters.AddWithValue("@Prioridad", Priority);
            cmd.Parameters.AddWithValue("@Porcentaje", Percentage);
            cmd.Parameters.AddWithValue("@Id_Proyecto", Project.IdProject);
            cmd.Parameters.AddWithValue("@Nombre_Usuario", User.UserName);

            return cmd;
        }
    }
}
