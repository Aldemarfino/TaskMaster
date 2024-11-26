using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ENTITY;

namespace BLL
{
    public class TaskLogic:IBasicOperations<Task>
    {
        TaskRepository taskRepository;
        public TaskLogic()
        {
            taskRepository = new TaskRepository();
        }

        public bool Add(Task entity)
        {
            return taskRepository.Save(entity);
        }

        public List<Task> GetRows()
        {
            return taskRepository.Read();
        }
    }
}
