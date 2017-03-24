﻿using OnLineShop.Data.Models;
using System.Linq;

namespace OnLineShop.Services.Data.Contracts
{
    public interface IBrandService
    {
        IQueryable<Brand> GetAll();

        Brand GetById(int? id);

        Brand GetByName(string name);

        int Update(Brand Brand);

        int Delete(int? id);

        int Insert(Brand Brand);
    }
}
