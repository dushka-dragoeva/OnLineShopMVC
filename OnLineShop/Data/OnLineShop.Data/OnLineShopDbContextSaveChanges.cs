using OnLineShop.Data.Contracts;

namespace OnLineShop.Data
{
    public class OnLineShopDbContextSaveChanges :  IOnLineShopDbContextSaveChanges
    {
        private IOnLineShopDbContext onLineSystemDbContext;

        public OnLineShopDbContextSaveChanges(IOnLineShopDbContext onLineSystemDbContext)
        {
            this.onLineSystemDbContext = onLineSystemDbContext;
        }

        public int SaveChanges()
        {               
            return this.onLineSystemDbContext.SaveChanges();
        }
    }
}
