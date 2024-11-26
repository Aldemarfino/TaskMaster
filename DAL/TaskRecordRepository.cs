using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using ENTITY;

namespace DAL
{
    public class TaskRecordRepository : BaseRepository<TaskRecord>
    {
        TaskRepository taskRepository;
        public TaskRecordRepository() 
        {
            taskRepository = new TaskRepository();
        }
        protected override TaskRecord Mapper(SqlDataReader reader)
        {
            int idTaskRecord = reader.GetInt32(0);
            DateTime modificationDate = reader.GetDateTime(1);
            string description = reader.GetString(2);
            int idTask = reader.GetInt32(3);
            return new TaskRecord(idTaskRecord, modificationDate, description, idTask);
        }

        
    }
}
