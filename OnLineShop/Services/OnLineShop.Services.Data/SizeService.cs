using OnLineShop.Data;
using OnLineShop.Data.Contracts;
using OnLineShop.Data.Models;
using OnLineShop.Services.Data.Contracts;
using System.Linq;
using System.Collections.Generic;
using Bytes2you.Validation;

namespace OnLineShop.Services.Data
{
    public class SizeService : ISizeService

    {
        private IEfDbSetWrapper<Size> sizeSetWrapper;
        private IOnLineShopDbContextSaveChanges dbContext;

        public SizeService(IEfDbSetWrapper<Size> SizeSetWrapper, IOnLineShopDbContextSaveChanges dbContext)
        {
            Guard.WhenArgument(SizeSetWrapper, "SizeSetWrapper").IsNull().Throw();
            Guard.WhenArgument(dbContext, "dbContext").IsNull().Throw();

            this.sizeSetWrapper = SizeSetWrapper;
            this.dbContext = dbContext;
        }

        public IEnumerable<Size> GetAll()
        {
            return this.sizeSetWrapper
                .All()
                .Where(c => c.IsDeleted == false)
                .ToList();
        }

        public Size GetById(int? id)
        {
            return id.HasValue ? this.sizeSetWrapper.GetById(id) : null;
        }

       // public int Update(Size Size)
       // {

            //    Size sizeToUpdate = this.sizeSetWrapper.GetById(Size.Id);
            //    this.sizeSetWrapper.Update(sizeToUpdate);

            //    return this.dbContext.SaveChanges();
            //}

            //public int Insert(Size Size)
            //{
            //    this.sizeSetWrapper.Add(Size);
            //    return this.dbContext.SaveChanges();
            //}

            //public int Delete(int? id)
            //{
            //    Guard.WhenArgument(id, nameof(id)).IsNull().Throw();

            //    var entity = this.GetById(id);
            //    entity.IsDeleted = true;
            //    this.sizeSetWrapper.Update(entity);
            //    return this.dbContext.SaveChanges();
            //}
        }
}
