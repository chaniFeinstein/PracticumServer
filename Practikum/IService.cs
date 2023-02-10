﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IService<T>
    {
        Task<T> GetById(int id);
        Task<List<T>> GetAll();
        Task<T> Add(T entity);
    }
}
