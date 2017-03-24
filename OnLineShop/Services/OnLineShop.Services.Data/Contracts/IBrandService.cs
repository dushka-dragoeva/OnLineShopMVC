using System.Collections.Generic;

using OnLineShop.Data.Models;

namespace OnLineShop.Services.Data.Contracts
{
    public interface IBrandService
    {
        IEnumerable<Brand> GetAll();

        Brand GetById(int? id);

        Brand GetByName(string name);

        int Update(Brand Brand);

        int Delete(int? id);

        int Insert(Brand Brand);
    }
}
