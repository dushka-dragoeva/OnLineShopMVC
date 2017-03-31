using System.Collections.Generic;
using System.Linq;

using Bytes2you.Validation;

using OnLineShop.Data.Contracts;
using OnLineShop.Data.Models;
using OnLineShop.Services.Data.Contracts;

namespace OnLineShop.Services.Data
{
    public class OrderDetailsService : IOrderDetailsService
    {
        private readonly IEfDbSetWrapper<OrderDetail> orderDetailsSetWrapper;
        private readonly IOnLineShopDbContextSaveChanges dbContext;

        public OrderDetailsService(IEfDbSetWrapper<OrderDetail> orderDetailsSetWrapper, IOnLineShopDbContextSaveChanges dbContext)
        {
            Guard.WhenArgument(orderDetailsSetWrapper, "orderDetailsSetWrapper").IsNull().Throw();
            Guard.WhenArgument(dbContext, "dbContext").IsNull().Throw();

            this.orderDetailsSetWrapper = orderDetailsSetWrapper;
            this.dbContext = dbContext;
        }

        public int Create(OrderDetail orderDetails)
        {
            this.orderDetailsSetWrapper.Add(orderDetails);
            this.dbContext.SaveChanges();
            return orderDetails.Id;
        }

        public OrderDetail GetById(int? id)
        {
            return id.HasValue ? this.orderDetailsSetWrapper.GetById(id) : null;
        }

        //public int Delete(int? id)
        //{
        //    Guard.WhenArgument(id, nameof(id)).IsNull().Throw();

        //    var entity = this.GetById(id);
        //    entity.IsDeleted = true;
        //    this.orderDetailsSetWrapper.Update(entity);
        //    return this.dbContext.SaveChanges();
        //}

        //public IEnumerable<OrderDetail> GetAll()
        //{
        //    return this.orderDetailsSetWrapper
        //         .All()
        //         .Where(c => c.IsDeleted == false)
        //         .ToList();
        //}

        public int Update(OrderDetail orderDetails)
        {
            OrderDetail orderToUpdate = this.orderDetailsSetWrapper.GetById(orderDetails.Id);
            this.orderDetailsSetWrapper.Update(orderToUpdate);

            return this.dbContext.SaveChanges();
        }
    }
}
