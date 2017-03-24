using System.Linq;
using System.Data.Entity;

using OnLineShop.Data;
using OnLineShop.Data.Models;
using OnLineShop.Services.Data.Contracts;
using OnLineShop.Data.Contracts;

namespace OnLineShop.Services.Data
{
    public class ProductService : IProductService
    {
        private readonly IOnLineShopDbContext Context;

        public ProductService(IOnLineShopDbContext context)
        {
            this.Context = context;
        }

        public IQueryable<Product> GetLast12WithCategoryAndBrand()
        {
            return this.Context.Products
                .Where(p => p.IsDeleted == false)
                 .Include(p => p.Brand)
                 .Include(p => p.Category)
                 .Take(12);
        }

        public IQueryable<Product> GetAllWithCategoryBrand()
        {
            return this.Context.Products
                .Where(p => p.IsDeleted == false)
                 .Include(p => p.Brand)
                 .Include(p => p.Category);
        }

        //public IQueryable<Product> GetAllByCategory(int categoryId)
        //{
        //    return this.Context.Products
        //        .Where(p => p.IsDeleted == false)
        //        .Where(p => p.CategoryId == categoryId)
        //        .Include(p => p.Brand);
        //}

        public Product GetById(int? id)
        {
            return id.HasValue ? this.Context.Products.Find(id) : null;
        }

        public int Insert(Product product)
        {
            this.Context.Products.Add(product);
            return this.Context.SaveChanges();
        }

        public int Delete(int? id)
        {
            var entity = this.GetById(id);
            entity.IsDeleted = true;
            return this.Context.SaveChanges();
        }

        public int Update(Product product)
        {
            Product productToUpdate = this.GetById(product.Id);
            this.Context.Entry(productToUpdate).CurrentValues.SetValues(product);

            return this.Context.SaveChanges();
        }
    }
}
