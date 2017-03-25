using System.Collections.Generic;
using System.Linq;

using OnLineShop.Data.Models;
using OnLineShop.Services.Data.Contracts;
using OnLineShop.Data.Contracts;
using Bytes2you.Validation;

namespace OnLineShop.Services.Data
{
    public class BrandService : IBrandService
    {
        private IEfDbSetWrapper<Brand> brandSetWrapper;
        private IOnLineShopDbContextSaveChanges dbContext;

        public BrandService(IEfDbSetWrapper<Brand> brandSetWrapper, IOnLineShopDbContextSaveChanges dbContext)
        {
            Guard.WhenArgument(brandSetWrapper, "BrandSetWrapper").IsNull().Throw();
            Guard.WhenArgument(dbContext, "dbContext").IsNull().Throw();

            this.brandSetWrapper = brandSetWrapper;
            this.dbContext = dbContext;
        }

        public IEnumerable<Brand> GetAll()
        {
            return this.brandSetWrapper
                .All()
                .Where(c => c.IsDeleted == false)
                .ToList();
        }

        public Brand GetById(int? id)
        {
            return id.HasValue ? this.brandSetWrapper.GetById(id) : null;
        }

        public int Update(Brand Brand)
        {

            Brand brandToUpdate = this.brandSetWrapper.GetById(Brand.Id);
            this.brandSetWrapper.Update(brandToUpdate);

            return this.dbContext.SaveChanges();
        }

        public int Insert(Brand Brand)
        {
            this.brandSetWrapper.Add(Brand);
            return this.dbContext.SaveChanges();
        }

        public int Delete(int? id)
        {
            Guard.WhenArgument(id, nameof(id)).IsNull().Throw();

            var entity = this.GetById(id);
            entity.IsDeleted = true;
            this.brandSetWrapper.Update(entity);
            return this.dbContext.SaveChanges();
        }
    }
}
