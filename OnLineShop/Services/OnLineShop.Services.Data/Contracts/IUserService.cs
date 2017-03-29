using OnLineShop.Data.Models;

namespace OnLineShop.Services.Data.Contracts
{
    public interface IUserService
    {
        User GetById(int? id);
    }
}
