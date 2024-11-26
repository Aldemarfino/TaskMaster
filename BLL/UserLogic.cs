using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL;
using ENTITY;

namespace BLL
{
    public class UserLogic:IBasicOperations<User>
    {
        UserRepository userRepository;
        public UserLogic()
        {
            userRepository = new UserRepository();
        }

        public bool Add(User entity)
        {
            return userRepository.Save(entity);
        }

        public List<User> GetRows()
        {
            return userRepository.Read();
        }
        public User ObtainByUsername(string username)
        {
            return userRepository.GetByUsername(username);
        }
    }
}
