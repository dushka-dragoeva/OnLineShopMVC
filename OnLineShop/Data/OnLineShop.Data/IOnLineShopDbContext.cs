using OnLineShop.Data.Models;
using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace OnLineShop.Data
{
    public interface IOnLineShopDbContext : IOnLineShopBaseDbContext
    {
        IDbSet<User> Users { get; set; }

        IDbSet<Brand> Brands { get; set; }

        IDbSet<ContactInfo> ContactInfos { get; set; }

        IDbSet<Size> Sizes { get; set; }

        IDbSet<Town> Towns { get; set; }

        IDbSet<Category> Categories { get; set; }

        IDbSet<Product> Products { get; set; }

        //  IDbSet<CartItem> ShoppingCartItems { get; set; }

        IDbSet<OrderDetail> OrderDetail { get; set; }

        IDbSet<Order> Order { get; set; }

        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
    }
}
