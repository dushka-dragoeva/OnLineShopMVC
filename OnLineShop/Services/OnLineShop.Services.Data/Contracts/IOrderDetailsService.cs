using OnLineShop.Data.Models;
using System.Collections.Generic;

namespace OnLineShop.Services.Data.Contracts
{
    public interface IOrderDetailsService
    {
       // IEnumerable<OrderDetail> GetAll();

        OrderDetail GetById(int? id);

        //int Update(OrderDetail orderDetails);

        //int Delete(int? id);

        int Create(OrderDetail orderDetail);

    }
}
