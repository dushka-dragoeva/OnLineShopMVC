using OnLineShop.Data.Models;

namespace OnLineShop.Services.Data.Contracts
{
    public interface IUserService
    {
         User GetById(string id);

       // User GetByUserName(string name);

        int Update(User user);

        // int Delete(int? id);
    }
}
