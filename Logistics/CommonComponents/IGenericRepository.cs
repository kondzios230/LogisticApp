﻿using System.Collections.Generic;

namespace Logistics.CommonComponents
{
    public interface IGenericRepository<T>
    {
        void Insert(T entity);

        void Delete(T entity);

        T Find(int id);

        List<T> FindAll();
        //VO do agregatu
        //Report service w app zamias rep w domain
    }
}
