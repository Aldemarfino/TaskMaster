using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ENTITY
{
    public class TaskRecord:IEntityOptions
    {
        public int IdTaskRecord { get; set; }
        public DateTime ModificationDate { get; set; }
        public string Description { get; set; }
        public int IdTask { get; set; }

        public TaskRecord() { }

        public TaskRecord(int idTaskRecord, DateTime modificationDate, string description, int idTask)
        {
            IdTaskRecord = idTaskRecord;
            ModificationDate = modificationDate;
            Description = description;
            IdTask = idTask;
        }

        public SqlCommand SQLCommandInsert(SqlConnection connection)
        {
            string ssql = "INSERT INTO [Cambios] ([Fecha_Modificacion],[Descripcion],[Id_Tarea])" +
                   "VALUES (@Fecha_Modificacion, @Descripcion, @Id_Tarea)";
            SqlCommand cmd = new SqlCommand(ssql, connection);
            cmd.Parameters.AddWithValue("@Fecha_Modificacion", ModificationDate);
            cmd.Parameters.AddWithValue("@Descripcion", Description);
            cmd.Parameters.AddWithValue("@Id_Tarea", IdTask);
            return cmd;
        }

        public string SQLCommandSelect()
        {
            return "select * from Cambios";
        }
    }
}
