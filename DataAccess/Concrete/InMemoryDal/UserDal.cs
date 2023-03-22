using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemoryDal
{
    public class UserDal : IUserDal
    {
        List<User> users;

        public UserDal() {
        users = new List<User> { new User { Name="Rashad",Surname="Azimov",Id=1,BirthYear=2001},
            new User { Name="Zivar",Surname="Aliyev",BirthYear=2000,Id = 2} };
        }
        public void Add(User user)
        {
            users.Add(user);
        }

        public void Delete(User user)
        {
            User userToDelete = null;
            foreach (var u in users)
            {
                if(u.Id == user.Id)
                {
                    userToDelete = u; 
                }
            }
            users.Remove(userToDelete);
        }

        public void Update(User user)
        {
            User userToUpdate = null;
            foreach (var u in users)
            {
                if(u.Id == user.Id)
                {
                    userToUpdate = u;
                }
                userToUpdate.Surname = user.Surname;
                userToUpdate.BirthYear = user.BirthYear;
                userToUpdate.Name = user.Name;
                userToUpdate.Id = user.Id;
            }
        }

        public List<User> GetAll()
        {
            return users;
        }
    }
}
