﻿//using System;
using System.Data.Entity;

using Microsoft.AspNet.Identity.EntityFramework;

using OnLineShop.Data.Models;
using System.Data.Entity.ModelConfiguration.Conventions;
using OnLineShop.Data.Contracts;

namespace OnLineShop.Data
{
    public class OnLineShopDbContext : IdentityDbContext<User>, IOnLineShopDbContext,IOnLineShopDbContextSaveChanges
    {
        public OnLineShopDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {

        }

        public static OnLineShopDbContext Create()
        {
            return new OnLineShopDbContext();
        }

        public IDbSet<Brand> Brands { get; set; }

        public IDbSet<Size> Sizes { get; set; }

       // public IDbSet<Town> Towns { get; set; }

        public IDbSet<Category> Categories { get; set; }

        public IDbSet<Product> Products { get; set; }

       // public IDbSet<CartItem> ShoppingCartItems { get; set; }

        public IDbSet<OrderDetail> OrderDetail { get; set; }

        public IDbSet<Order> Order { get; set; }

        public IDbSet<ContactInfo> ContactInfos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           // modelBuilder.IncludeMetadataInDatabase = false;
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            base.OnModelCreating(modelBuilder);
        }
    }
}

