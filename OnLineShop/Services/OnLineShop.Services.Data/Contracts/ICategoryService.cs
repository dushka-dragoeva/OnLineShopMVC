using OnLineShop.Data.Models;
using System.Linq;

namespace OnLineShop.Services.Data.Contracts
{
    public interface ICategoryService
    {
        IQueryable<Category> GetAll();

        Category GetById(int? id);

        //Category GetByName(string name);

        int Update(Category category);

        int Delete(int? id);

        int Insert(Category category);
    }
}
