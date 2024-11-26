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
        public bool Add(Project entity)
        {
            return projectRepository.Save(entity);
        }
        public List<Project> GetRows()
        {
            return projectRepository.Read();
        }
        public Project ObtainById(int id)
        {
            return projectRepository.GetById(id);
        }
        public List<Project> ProjectsByUser(string username)
        {

        }
    }
}
