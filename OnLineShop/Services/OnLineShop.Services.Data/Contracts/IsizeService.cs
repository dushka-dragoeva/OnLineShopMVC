using OnLineShop.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace OnLineShop.Services.Data.Contracts
{
    public interface ISizeService
    {
        IEnumerable<Size> GetAll();

        Size GetById(int? id);

        int Update(Size size);

        int Delete(int? id);

        int Insert(Size size);
    }
}
