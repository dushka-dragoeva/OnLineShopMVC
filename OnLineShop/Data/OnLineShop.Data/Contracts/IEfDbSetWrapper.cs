using System;
using System.Linq;
using System.Linq.Expressions;

namespace OnLineShop.Data.Contracts
{
    public interface IEfDbSetWrapper<T>
       where T : class
    {
        IQueryable<T> All();

        IQueryable<T> AllWithInclude<TProperty>(Expression<Func<T, TProperty>> includeExpression);

        IQueryable<T> AllWithTowInclude<TProperty>(
            Expression<Func<T, TProperty>> firstIncludeExpression,
            Expression<Func<T, TProperty>> secondIncludeExpression);

        IQueryable<T> AllWithThreeInclude<TProperty>(
            Expression<Func<T, TProperty>> firstIncludeExpression,
            Expression<Func<T, TProperty>> secondIncludeExpression,
            Expression<Func<T, TProperty>> thirdIncludeExpression);

        T GetById(int? id);

        T GetById(string id);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}
