using OnLineShop.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace OnLineShop.Services.Data.Contracts
{
    public interface ICategoryService
    {
        IEnumerable<Category> GetAll();

        Category GetById(int? id);

        //Category GetByName(string name);

        int Update(Category category);

        int Delete(int? id);

        int Insert(Category category);
    }
}
