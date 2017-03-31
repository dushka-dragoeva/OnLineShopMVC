using Bytes2you.Validation;

using OnLineShop.Data.Contracts;
using OnLineShop.Data.Models;
using OnLineShop.Services.Data.Contracts;


namespace OnLineShop.Services.Data
{
    public class UserService : IUserService
    {
        private readonly IEfDbSetWrapper<User> userSetWrapper;
        private readonly IOnLineShopDbContextSaveChanges dbContext;

        public UserService(IEfDbSetWrapper<User> UserSetWrapper, IOnLineShopDbContextSaveChanges dbContext)
        {
            Guard.WhenArgument(UserSetWrapper, "UserSetWrapper").IsNull().Throw();
            Guard.WhenArgument(dbContext, "dbContext").IsNull().Throw();

            this.userSetWrapper = UserSetWrapper;
            this.dbContext = dbContext;
        }

        //public IEnumerable<User> GetAll()
        //{
        //    return this.UserSetWrapper
        //        .All()
        //        .Where(c => c.IsDeleted == false)
        //        .ToList();
        //}


        public int Update(User user)
        {
            this.userSetWrapper.Update(user);
            return this.dbContext.SaveChanges();
        }

        //public User GetByUserName(string name)
        //{
        //    return this.userSetWrapper.GetByName(name);
        //}

        public User GetById(string id)
        {
           return this.userSetWrapper.GetById(id);
        }
    }
}
