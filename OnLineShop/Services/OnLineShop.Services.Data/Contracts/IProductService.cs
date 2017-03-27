using OnLineShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnLineShop.Services.Data.Contracts
{
    public interface IProductService
    {
       // IEnumerable<Product> GetAllWithCategoryBrand();

       // IQueryable<Product> GetAllByCategory(int categoryId);

        IEnumerable<Product> GetLast12WithCategoryAndBrand();

        Product GetById(int? id);

        //int Update(Product product);

        //int Delete(int? id);

        //int Insert(Product product);
    }
}
