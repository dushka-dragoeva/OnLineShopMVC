using System.Data.Entity;
using System.Linq;
using System.Collections.Generic;
using OnLineShop.Data.Models;
using OnLineShop.Services.Data.Contracts;
using OnLineShop.Data.Contracts;
using Bytes2you.Validation;

namespace OnLineShop.Services.Data
{
    public class ProductService : IProductService
    {
        private readonly IEfDbSetWrapper<Product> productSetWrapper;

        private readonly IOnLineShopDbContextSaveChanges dbContext;

        public ProductService(IEfDbSetWrapper<Product> productSetWrapper, IOnLineShopDbContextSaveChanges dbContext)
        {
            Guard.WhenArgument(productSetWrapper, "productSetWrapper").IsNull().Throw();
            Guard.WhenArgument(dbContext, "dbContext").IsNull().Throw();
            this.productSetWrapper = productSetWrapper;
            this.dbContext = dbContext;
        }

        public IEnumerable<Product> GetAllWithCategoryBrand()
        {
            return this.productSetWrapper
                .All()
                .Where(p => p.IsDeleted == false)
                 .Include(p => p.Brand)
                 .Include(p => p.Category)
                 .ToList();
        }

        public IEnumerable<Product> GetLast12WithCategoryAndBrand()
        {
            return this.productSetWrapper
                .All()
                .Where(p => p.IsDeleted == false)
                 .Include(p => p.Brand)
                 .Include(p => p.Category)
                 .Take(12)
                 .ToList();
        }

        public Product GetById(int? id)
        {
            return id.HasValue ? this.productSetWrapper.GetById(id) : null;
        }

        public int Insert(Product product)
        {
            this.productSetWrapper.Add(product);
            return this.dbContext.SaveChanges();
        }

        public int Delete(int? id)
        {
            Guard.WhenArgument(id, nameof(id)).IsNull().Throw();

            var entity = this.GetById(id);
            entity.IsDeleted = true;
            this.productSetWrapper.Update(entity);
            return this.dbContext.SaveChanges();
        }

        public int Update(Product product)
        {
            Product productToUpdate = this.GetById(product.Id);
            this.productSetWrapper.Update(productToUpdate);
            return this.dbContext.SaveChanges();
        }
    }
}
