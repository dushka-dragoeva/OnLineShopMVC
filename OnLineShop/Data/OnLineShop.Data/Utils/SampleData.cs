using OnLineShop.Data.Models;

namespace OnLineShop.Data.Utils
{
    public static class SampleData
    {

        public static string[] categories = { "Рокли", "Поли", "Панталони", "Сака и Якета", "Аксесоари", };
        public static string[] brands = { "LucyPatis", "Dafnea", "Danny", "BraySteveAlan", "Jonson", };
        public static string[] sizes = { "S", "M", "L", "XL", "XXL", };


        public static Product[] Products =
        {

         new Product
            {
                Name= "Рокля Ферия 1",
                Description="Лятна Рокля от еластично памучно трико - леко меланжирано.Роклята е с обло деколте и 3/4 ръкав, подходяща за пролетно - летния сезон.",
                ModelNumber="А001",
                PictureUrl="~/Content/Images/14420-c .jpg",
                Price=39.90m,
                CategoryId=1,
                BrandId=2,
                Sizes = new []{ new Size {Value ="S"}, new Size { Value = "L" }, new Size { Value = "XL" }, },
                Quantity=5
            },

          new Product
            {
                Name= "Рокля Ферия 2",
                Description="Лятна Рокля от еластично памучно трико - леко меланжирано.Роклята е с обло деколте и 3/4 ръкав, подходяща за пролетно - летния сезон.",
                ModelNumber="А001",
                PictureUrl="~/Content/Images/14420-c .jpg",
                Price=39.90m,
                CategoryId=1,
                BrandId=2,
                Sizes = new []{ new Size {Value ="S"}, new Size { Value = "L" }, new Size { Value = "XL" }, },
                Quantity=3
            },

           new Product
            {
                Name= "Рокля Ферия 3",
                Description="Лятна Рокля от еластично памучно трико - леко меланжирано.Роклята е с обло деколте и 3/4 ръкав, подходяща за пролетно - летния сезон.",
                ModelNumber="А001",
                PictureUrl="~/Content/Images/14420-c .jpg",
                Price=39.90m,
                CategoryId=4,
                BrandId=3,
                Sizes = new []{ new Size {Value ="S"}, new Size { Value = "L" }, new Size { Value = "XL" }, },
                Quantity=7
            },

            new Product
            {
                Name= "Рокля Ферия 4",
                Description="Лятна Рокля от еластично памучно трико - леко меланжирано.Роклята е с обло деколте и 3/4 ръкав, подходяща за пролетно - летния сезон.",
                ModelNumber="А001",
                PictureUrl="~/Content/Images/14420-c .jpg",
                Price=39.90m,
                CategoryId=2,
                BrandId=2,
                Sizes = new []{ new Size {Value ="S"}, new Size { Value = "L" }, new Size { Value = "XL" }, },
                 Quantity=5
            },

             new Product
            {
                Name= "Рокля Ферия 5",
                Description="Лятна Рокля от еластично памучно трико - леко меланжирано.Роклята е с обло деколте и 3/4 ръкав, подходяща за пролетно - летния сезон.",
                ModelNumber="А001",
                PictureUrl="~/Content/Images/14420-c .jpg",
                Price=39.90m,
                CategoryId=2,
                BrandId=5,
                Sizes = new []{ new Size {Value ="S"}, new Size { Value = "L" }, new Size { Value = "XL" }, },
                 Quantity=5
            },

              new Product
            {
                Name= "Рокля Ферия 6",
                Description="Лятна Рокля от еластично памучно трико - леко меланжирано.Роклята е с обло деколте и 3/4 ръкав, подходяща за пролетно - летния сезон.",
                ModelNumber="А001",
                PictureUrl="~/Content/Images/14420-c .jpg",
                Price=39.90m,
                CategoryId=18,
                BrandId=5,
                Sizes = new []{ new Size {Value ="S"}, new Size { Value = "L" }, new Size { Value = "XL" }, },
                 Quantity=5
            },

               new Product
            {
                Name= "Рокля Ферия 7",
                Description="Лятна Рокля от еластично памучно трико - леко меланжирано.Роклята е с обло деколте и 3/4 ръкав, подходяща за пролетно - летния сезон.",
                ModelNumber="А001",
                PictureUrl="~/Content/Images/10446_taupe.jpg",
                Price=39.90m,
                CategoryId=4,
                BrandId=2,
                Sizes = new []{ new Size {Value ="S"}, new Size { Value = "L" }, new Size { Value = "XL" }, },
                 Quantity=5
            },

               new Product
            {
                Name= "Рокля Ферия 8",
                Description="Лятна Рокля от еластично памучно трико - леко меланжирано.Роклята е с обло деколте и 3/4 ръкав, подходяща за пролетно - летния сезон.",
                ModelNumber="А001",
                PictureUrl="~/Content/Images/14420-c .jpg",
                Price=39.90m,
                CategoryId=18,
                BrandId=2,
                Sizes = new []{ new Size {Value ="S"}, new Size { Value = "L" }, new Size { Value = "XL" }, },
                 Quantity=5
            },

          new Product
            {
                Name= "Рокля Ферия 9",
                Description="Лятна Рокля от еластично памучно трико - леко меланжирано.Роклята е с обло деколте и 3/4 ръкав, подходяща за пролетно - летния сезон.",
                ModelNumber="А001",
                PictureUrl="~/Content/Images/14420-c .jpg",
                Price=39.90m,
                CategoryId=1,
                BrandId=2,
                Sizes = new []{ new Size {Value ="S"}, new Size { Value = "L" }, new Size { Value = "XL" }, },
                 Quantity=5
            },

           new Product
            {
                Name= "Рокля Ферия 10",
                Description="Лятна Рокля от еластично памучно трико - леко меланжирано.Роклята е с обло деколте и 3/4 ръкав, подходяща за пролетно - летния сезон.",
                ModelNumber="А001",
                PictureUrl="~/Content/Images/14420-c .jpg",
                Price=39.90m,
                CategoryId=4,
                BrandId=3,
                Sizes = new []{ new Size {Value ="S"}, new Size { Value = "L" }, new Size { Value = "XL" }, },
                 Quantity=5
            },

            new Product
            {
                Name= "Рокля Ферия 11",
                Description="Лятна Рокля от еластично памучно трико - леко меланжирано.Роклята е с обло деколте и 3/4 ръкав, подходяща за пролетно - летния сезон.",
                ModelNumber="А001",
                PictureUrl="~/Content/Images/14420-c .jpg",
                Price=39.90m,
                CategoryId=2,
                BrandId=2,
                Sizes = new []{ new Size {Value ="S"}, new Size { Value = "L" }, new Size { Value = "XL" }, },
                 Quantity=5
            },

             new Product
            {
                Name= "Рокля Ферия 12",
                Description="Лятна Рокля от еластично памучно трико - леко меланжирано.Роклята е с обло деколте и 3/4 ръкав, подходяща за пролетно - летния сезон.",
                ModelNumber="А001",
                PictureUrl="~/Content/Images/14420-c .jpg",
                Price=39.90m,
                CategoryId=2,
                BrandId=4,
                Sizes = new []{ new Size {Value ="S"}, new Size { Value = "L" }, new Size { Value = "XL" }, },
                 Quantity=5
            },

              new Product
            {
                Name= "Рокля Ферия 13",
                Description="Лятна Рокля от еластично памучно трико - леко меланжирано.Роклята е с обло деколте и 3/4 ръкав, подходяща за пролетно - летния сезон.",
                ModelNumber="А001",
                PictureUrl="~/Content/Images/14420-c .jpg",
                Price=39.90m,
                CategoryId=1,
                BrandId=2,
                 Sizes = new []{ new Size {Value ="S"}, new Size { Value = "L" }, new Size { Value = "XL" }, },
                 Quantity=5
            },

               new Product
            {
                Name= "Рокля Ферия 14",
                Description="Лятна Рокля от еластично памучно трико - леко меланжирано.Роклята е с обло деколте и 3/4 ръкав, подходяща за пролетно - летния сезон.",
                ModelNumber="А001",
                PictureUrl="~/Content/Images/10446_taupe.jpg",
                Price=39.90m,
                CategoryId=1,
                BrandId=2,
                 Quantity=5,
                Sizes = new []{ new Size {Value ="S"}, new Size { Value = "L" }, new Size { Value = "XL" }, }
            }
        };
    }
}
