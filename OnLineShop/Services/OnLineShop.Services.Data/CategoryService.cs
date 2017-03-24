using System.Collections.Generic;
using System.Linq;

using Bytes2you.Validation;
using OnLineShop.Data.Contracts;
using OnLineShop.Data.Models;
using OnLineShop.Services.Data.Contracts;

namespace OnLineShop.Services.Data
{
    public class CategoryService : ICategoryService
    {
        private readonly IEfDbSetWrapper<Category> categorySetWrapper;

        private readonly IOnLineShopDbContextSaveChanges dbContext;

        public CategoryService(IEfDbSetWrapper<Category> categorySetWrapper, IOnLineShopDbContextSaveChanges dbContext)
        {
            Guard.WhenArgument(categorySetWrapper, "categorySetWrapper").IsNull().Throw();
            Guard.WhenArgument(dbContext, "dbContext").IsNull().Throw();

            this.categorySetWrapper = categorySetWrapper;
            this.dbContext = dbContext;
        }

        public IEnumerable<Category> GetAll()
        {
            return this.categorySetWrapper.All().Where(c => c.IsDeleted == false).ToList();
        }

        public Category GetById(int? id)
        {
            return id.HasValue ? this.categorySetWrapper.GetById(id) : null;
        }

        //public Category GetByName(string name)
        //{
        //    return this.Context.Categories.Find(name);
        //}

        public int Update(Category category)
        {

            Category categoryToUpdate = this.categorySetWrapper.GetById(category.Id);
            this.categorySetWrapper.Update(categoryToUpdate);

            return this.dbContext.SaveChanges();
        }

        public int Insert(Category category)
        {
            this.categorySetWrapper.Add(category);
            return this.dbContext.SaveChanges();
        }

        public int Delete(int? id)
        {
            Guard.WhenArgument(id, nameof(id)).IsNull().Throw();

            var entity = this.GetById(id);
            entity.IsDeleted = true;
            this.categorySetWrapper.Update(entity);
            return this.dbContext.SaveChanges();
        }
    }
}

