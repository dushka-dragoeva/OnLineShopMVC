using OnLineShop.Data.Models;
using System.Collections.Generic;

namespace OnLineShop.Services.Data.Contracts
{
    public interface IOrderService
    {
        IEnumerable<Order> GetAll();

        Order GetById(int? id);

        int Update(Order order);

        int Delete(int? id);

        int Create(Order order);
    }
}
