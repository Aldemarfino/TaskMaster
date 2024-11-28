using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProjectLogic : IBasicOperations<Project>
    {
        ProjectRepository projectRepository;

        public ProjectLogic()
        {
            projectRepository = new ProjectRepository();
        }
        public string Add(Project entity)
        {
            return projectRepository.Save(entity);
        }
        public Project ObtainById(int id)
        {
            return projectRepository.GetById(id);
        }
        public List<Project> ProjectsByUser(string username)
        {
            return projectRepository.GetProjectsByUser(username);
        }
    }
}
