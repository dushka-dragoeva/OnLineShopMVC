using System.Data.Entity.Migrations;

namespace OnLineShop.Data.Migrations
{
    public sealed class Configuration : DbMigrationsConfiguration<OnLineShop.Data.OnLineShopDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(OnLineShopDbContext context)
        {
            //foreach (var category in Utils.SampleData.categories)
            //{
            //    context.Categories.AddOrUpdate(c => c.Name, new Category { Name = category });
            //}

            //context.SaveChanges();

            //foreach (var brand in Utils.SampleData.brands)
            //{
            //    context.Brands.AddOrUpdate(b => b.Name, new Brand { Name = brand });
            //}

            //context.SaveChanges();

            //foreach (var size in Utils.SampleData.sizes)
            //{
            //    context.Sizes.AddOrUpdate(s => s.Value, new Size { Value = size });
            //}

            //context.SaveChanges();

            //foreach (var product in Utils.SampleData.Products)
            //{
            //    var productToAdd = new Product();
            //    productToAdd.Name = product.Name;
            //    productToAdd.PictureUrl = product.PictureUrl;
            //    productToAdd.Price = product.Price;
            //    productToAdd.Quantity = product.Quantity;
            //    productToAdd.AddedOn = DateTime.Now;
            //    productToAdd.BrandId = product.BrandId;
            //    productToAdd.CategoryId = product.CategoryId;
            //    productToAdd.Description = product.Description;
            //    product.IsDeleted = false;
            //    productToAdd.ModelNumber = product.ModelNumber;

            //    foreach (var size in product.Sizes)
            //    {
            //        var sizeToAdd = context.Sizes.FirstOrDefault(s => s.Value == size.Value);
            //        productToAdd.Sizes.Add(sizeToAdd);
            //    }

            //    context.Products.AddOrUpdate(productToAdd);
            //}

            //context.SaveChanges();
        }
    }
}
