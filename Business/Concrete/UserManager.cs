using Business.Abstract;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal userDal=null;

        public UserManager(IUserDal userDal)
        {
            this.userDal = userDal;
        }

        public List<User> GetData()
        {
            return userDal.GetAll();
        }
    }
}
