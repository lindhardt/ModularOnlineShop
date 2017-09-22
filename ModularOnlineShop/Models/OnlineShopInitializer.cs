using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;

namespace ModularOnlineShop.Models {
    public class OnlineShopInitializer : DropCreateDatabaseAlways<OnlineShopContext> {
        protected override void Seed(OnlineShopContext context) {
            base.Seed(context);

            var products = new List<Product>
            {
                new Product {
                    ProductID = 1,
                    Price = 150.60M,
                    Descrption = "very nice product",
                    Name = "Demo Product 1",
                    Stock = 500
                },
                new Product {
                    ProductID = 2,
                    Price = 200.00M,
                    Descrption = "very nice product",
                    Name = "Demo Product 2",
                    Stock = 500
                },
                new Product {
                    ProductID = 3,
                    Price = 550.85M,
                    Descrption = "very nice product",
                    Name = "Demo Product 3",
                    Stock = 500
                },
                new Product {
                    ProductID = 4,
                    Price = 1150.54M,
                    Descrption = "very nice product",
                    Name = "Demo Product 4",
                    Stock = 500
                },
                new Product {
                    ProductID = 5,
                    Price = 1550.65M,
                    Descrption = "very nice product",
                    Name = "Demo Product 5",
                    Stock = 500
                },
                new Product {
                    ProductID = 6,
                    Price = 2150.34M,
                    Descrption = "very nice product",
                    Name = "Demo Product 6",
                    Stock = 500
                },
                new Product {
                    ProductID = 7,
                    Price = 1750.12M,
                    Descrption = "very nice product",
                    Name = "Demo Product 7",
                    Stock = 500
                },
                new Product {
                    ProductID = 8,
                    Price = 7150.67M,
                    Descrption = "very nice product",
                    Name = "Demo Product 8",
                    Stock = 500
                },
                new Product {
                    ProductID = 9,
                    Price = 150.27M,
                    Descrption = "very nice product",
                    Name = "Demo Product 9",
                    Stock = 500
                },
                new Product {
                    ProductID = 10,
                    Price = 150.56M,
                    Descrption = "another very nice product",
                    Name = "Demo Product 10",
                    Stock = 500
                },
                new Product {
                    ProductID = 11,
                    Price = 150.75M,
                    Descrption = "very nice product",
                    Name = "Various Product",
                    Stock = 500
                },
                new Product {
                    ProductID = 12,
                    Price = 150.95M,
                    Descrption = "very nice product",
                    Name = "Danish Product",
                    Stock = 500
                }
            };
        }
    }
}