using Bytes2you.Validation;
using OnLineShop.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OnLineShop.Data
{
    public class EfDbSetWrapper<T> : IEfDbSetWrapper<T>
        where T : class
    {
        public EfDbSetWrapper(IOnLineShopDbContext efDbContext)
        {
            Guard.WhenArgument(efDbContext, "IOnLineShopDbContext").IsNull().Throw();

            this.EfDbContext = efDbContext;
            this.DbSet = efDbContext.Set<T>();
        }

        public IOnLineShopDbContext EfDbContext { get; private set; }

        public IDbSet<T> DbSet { get; private set; }

        public IQueryable<T> All()
        {

            return this.DbSet;

        }

        public IQueryable<T> AllWithInclude<TProperty>(Expression<Func<T, TProperty>> includeExpression)
        {
            return this.All().Include(includeExpression);
        }

        public IQueryable<T> AllWithTowInclude<TProperty>(
            Expression<Func<T, TProperty>> firstIncludeExpression,
            Expression<Func<T, TProperty>> secondIncludeExpression)
        {
            return this.All().Include(firstIncludeExpression).Include(secondIncludeExpression);
        }

        public IQueryable<T> AllWithThreeInclude<TProperty>(
            Expression<Func<T, TProperty>> firstIncludeExpression,
            Expression<Func<T, TProperty>> secondIncludeExpression,
            Expression<Func<T, TProperty>> thirdIncludeExpression)
        {
            return this
                .All()
                .Include(firstIncludeExpression)
                .Include(secondIncludeExpression)
                .Include(thirdIncludeExpression);
        }

        public T GetById(int? id)
        {
            return this.DbSet.Find(id);
        }

        public void Add(T entity)
        {
            DbEntityEntry entry = this.EfDbContext.Entry(entity);
            if (entry.State != EntityState.Detached)
            {
                entry.State = EntityState.Added;
            }
            else
            {
                this.DbSet.Add(entity);
            }
        }

        public void Update(T entity)
        {
            DbEntityEntry entry = this.EfDbContext.Entry(entity);
            if (entry.State == EntityState.Detached)
            {
                this.DbSet.Attach(entity);
            }

            entry.State = EntityState.Modified;
        }

        public void Delete(T entity)
        {
            DbEntityEntry entry = this.EfDbContext.Entry(entity);
            if (entry.State != EntityState.Deleted)
            {
                entry.State = EntityState.Deleted;
            }
            else
            {
                this.DbSet.Attach(entity);
                this.DbSet.Remove(entity);
            }
        }
    }
}
