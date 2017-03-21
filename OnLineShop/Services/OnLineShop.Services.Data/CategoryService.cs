using Bytes2you.Validation;
using OnLineShop.Data.Models;
using System.Data.Entity;
using System.Linq;

namespace OnLineShop.Data.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IOnLineShopDbContext Context;

        public CategoryService(IOnLineShopDbContext context)
        {
            Guard.WhenArgument(context, nameof(context)).IsNull().Throw();
            this.Context = context;
        }

        public int Insert(Category category)
        {
            this.Context.Categories.Add(category);
            return this.Context.SaveChanges();
        }

        public int Delete(int? id)
        {
            var entity = this.GetById(id);
            entity.IsDeleted = true;
            return this.Context.SaveChanges();
        }

        public IQueryable<Category> GetAll()
        {
            return this.Context.Categories.Where(c => c.IsDeleted == false);
        }

        //public IQueryable<Category> GetAllWithProducts()
        //{
        //    return this.Context.Categories
        //         .Where(c => c.IsDeleted == false)
        //        .Include(c => c.Products);
        //}

        public Category GetById(int? id)
        {
            return id.HasValue ? this.Context.Categories.Find(id) : null;
        }

        public Category GetByIdWithProducts(int? id)
        {
            var category = this.Context.Categories.Find(id);

            return id.HasValue ?category : null;
        }

        public Category GetByName(string name)
        {
            return this.Context.Categories.Find(name);
        }

        public int Update(Category category)
        {

            Category categoryToUpdate = this.Context.Categories.Find(category.Id);
            this.Context.Entry(categoryToUpdate).CurrentValues.SetValues(category);

            return this.Context.SaveChanges();
        }
    }
}

