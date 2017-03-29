using Bytes2you.Validation;
using OnLineShop.Data.Contracts;
using OnLineShop.Data.Models;
using OnLineShop.Services.Data.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace OnLineShop.Services.Data
{
    public class OrderService: IOrderService
    {
        private readonly IEfDbSetWrapper<Order> orderSetWrapper;
        private readonly IOnLineShopDbContextSaveChanges dbContext;

        public OrderService(IEfDbSetWrapper<Order> orderSetWrapper, IOnLineShopDbContextSaveChanges dbContext)
        {
            Guard.WhenArgument(orderSetWrapper, "orderSetWrapper").IsNull().Throw();
            Guard.WhenArgument(dbContext, "dbContext").IsNull().Throw();

            this.orderSetWrapper = orderSetWrapper;
            this.dbContext = dbContext;
        }

        public IEnumerable<Order> GetAll()
        {
            return this.orderSetWrapper
                .All()
                .Where(c => c.IsDeleted == false)
                .ToList();
        }

        public Order GetById(int? id)
        {
            return id.HasValue ? this.orderSetWrapper.GetById(id) : null;
        }

        public int Update(Order order)
        {

            Order orderToUpdate = this.orderSetWrapper.GetById(order.Id);
            this.orderSetWrapper.Update(orderToUpdate);

            return this.dbContext.SaveChanges();
        }

        public int Create(Order order)
        {
            this.orderSetWrapper.Add(order);
            this.dbContext.SaveChanges();
            return order.Id;
        }

        public int Delete(int? id)
        {
            Guard.WhenArgument(id, nameof(id)).IsNull().Throw();

            var entity = this.GetById(id);
            entity.IsDeleted = true;
            this.orderSetWrapper.Update(entity);
            return this.dbContext.SaveChanges();
        }
    }
}
