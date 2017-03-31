using OnLineShop.Data.Models;

namespace OnLineShop.Services.Data.Contracts
{
    public interface IContactInfoService
    {
        ContactInfo GetById(int? id);

       // ContactInfo GetByName(string name);

        int Update(ContactInfo contactInfo);

       // int Delete(int? id);

        int Create(ContactInfo contactInfo);
    }
}
