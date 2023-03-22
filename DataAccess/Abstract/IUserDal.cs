﻿using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IUserDal
    {
        List<User> GetAll();
        void Add(User user);
        void Update(User user);
        void Delete(User user);
    }
}
