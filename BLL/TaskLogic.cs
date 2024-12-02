using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using tasks = System.Threading.Tasks;
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

        public string Add(Task entity)
        {
            return taskRepository.Save(entity);
        }

        public List<Task> TasksByProject(int projectId)
        {
            return taskRepository.GetTasksByProject(projectId);
        }

        public List<Task> InvitedTasks(string username)
        {
            return taskRepository.GetInvitedTasks(username);
        }

        public async tasks.Task<List<Task>> IASuggestedTask(Project project)
        {
            List<Task> tasks = new List<Task>();
            IALogic IAlogic = new IALogic();
            string reply = await IAlogic.SuggestTasks(project.Name, project.Description);

            if (reply == null)
            {
                tasks = null;
            }
            else
            {
                tasks = AnalyzeReply(reply, project);
            }

            return tasks;
        }

        private List<Task> AnalyzeReply(string reply, Project project)
        {
            List<Task> tasks = new List<Task>();
            string stringTasks = reply.Substring(reply.IndexOf(":") + 1).Trim();
            string[] taskVector = stringTasks.Split('/');

            for (int i = 0; i < taskVector.Length; i++)
            {
                tasks.Add(CreateTaskByString(taskVector[i], project));
            }

            return tasks;
        }

        private Task CreateTaskByString(string taskString, Project project)
        {
            string[] attributesVector = taskString.Split(';');
            return new Task
            {
                Title = attributesVector[0].Substring(attributesVector[0].IndexOf(':') + 1).Trim(),
                Description = attributesVector[1].Substring(attributesVector[1].IndexOf(':') + 1).Trim(),
                Deadline = project.Deadline,
                State = project.State,
                Priority = attributesVector[2].Substring(attributesVector[2].IndexOf(':') + 1).Trim(),
                Project = project,
                User = project.CreatorUser
            };

        }
    }
}
