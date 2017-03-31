using System.Collections.Generic;
using System.Linq;

using Bytes2you.Validation;

using OnLineShop.Data.Contracts;
using OnLineShop.Data.Models;
using OnLineShop.Services.Data.Contracts;

namespace OnLineShop.Services.Data
{
    public class ContactInfoService : IContactInfoService
    {
        private readonly IEfDbSetWrapper<ContactInfo> contactInfoSetWrapper;
        private readonly IOnLineShopDbContextSaveChanges dbContext;

        public ContactInfoService(IEfDbSetWrapper<ContactInfo> contactInfoSetWrapper, IOnLineShopDbContextSaveChanges dbContext)
        {
            Guard.WhenArgument(contactInfoSetWrapper, "ContactInfoSetWrapper").IsNull().Throw();
            Guard.WhenArgument(dbContext, "dbContext").IsNull().Throw();

            this.contactInfoSetWrapper = contactInfoSetWrapper;
            this.dbContext = dbContext;
        }

        public IEnumerable<ContactInfo> GetAll()
        {
            return this.contactInfoSetWrapper
                .All()
                .Where(c => c.IsDeleted == false)
                .ToList();
        }

        public ContactInfo GetById(int? id)
        {
            return id.HasValue ? this.contactInfoSetWrapper.GetById(id) : null;
        }

        public int Create(ContactInfo contactInfo)
        {
            this.contactInfoSetWrapper.Add(contactInfo);
            return this.dbContext.SaveChanges();
        }

        public int Update(ContactInfo contactInfo)
        {

            ContactInfo ContactInfoToUpdate = this.contactInfoSetWrapper.GetById(contactInfo.Id);
            this.contactInfoSetWrapper.Update(ContactInfoToUpdate);

            return this.dbContext.SaveChanges();
        }
    }
}
