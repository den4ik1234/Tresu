﻿using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public interface ITresuRepository<T>
    {
        IEnumerable<T> GetUsers();
        bool Add(T user);
        bool Delete(int id);
        bool Edit(int id, T user);
        T FindById(int id);
    }
}
