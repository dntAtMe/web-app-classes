﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppClasses.Repositories
{
    public interface IDataRepository<T>
    {
        IEnumerable<T> GetAll();

        long Count();
        Message Add(T entity);
    }
}
