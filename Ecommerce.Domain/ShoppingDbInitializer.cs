using Ecommerce.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain
{
    public static class ShoppingDbInitializer
    {
        public static void Initialize(ShoppingDbContext context)
        {
            context.Database.EnsureCreated();
            if (context.Payments.Any())
            {
                return;
            }
            var payments = new Payment[]
            {
                new Payment{Name="Divisa",},
                new Payment{Name="Zelle"},
                new Payment{Name="Bitcoin"},
                new Payment{Name="PagoMovil"},
            };

            context.Payments.AddRange(payments);
            context.SaveChanges(); //SAVE PAYMENTS

            var category = new Category[]
            {
                new Category{Name="Auto",},
                new Category{Name="Accesorios"},
                new Category{Name="Teléfonos"},
            };
            context.Categories.AddRange(category);
            context.SaveChanges(); //SAVE CATEGORIES

            var offices = new Office[]
            {
                new Office{Name="Maracay"},
                new Office{Name="Carúpano"},
                new Office{Name="Caracas"}
            };
            context.Offices.AddRange(offices);
            context.SaveChanges(); //SAVE OFFICES

            var products = new Product[]
            {
                new Product{Name="SmartPhone X60 Pro",CategoryId=3,RetailPrice=75,WholesalePrice=60},
                new Product{Name="Luces Led C6 H4", CategoryId=1,RetailPrice=12,WholesalePrice=8},
                new Product{Name="SmartWatch P8", CategoryId=2,RetailPrice=25,WholesalePrice=20}
            };

            context.Products.AddRange(products);
            context.SaveChanges(); //SAVE PRODUCTS

            var sellers = new Seller[]
            {
                new Seller{Name="Jose",Surname="Gonzales",Email="Jose.Gonzales@gmail.com",PhoneNumber="+58 4248768262",Commission=15}
            };

            context.Sellers.AddRange(sellers);
            context.SaveChanges(); //SAVE SELLERS

            var Customer = new Customer[]
            {
                new Customer{Name="Luis",Surname="Eduardo",Email="LuisEduardo22@gmail.com",ShippingAddress="Plaza la pepita, casa 234"},
                new Customer{Name="Javier",Surname="Tracana",Email="javier.tracanaa@gmail.com",ShippingAddress="Macarapana, al lado de reboyen"},
                new Customer{Name="Domenico",Surname="Zopito",Email="Domenico.zopito@gmail.com",ShippingAddress="CC LaDama Maracay"},
            };

            context.Customers.AddRange(Customer);
            context.SaveChanges(); //SAVE CUSTOMERS

            var Users = new User[]
            {
                new User{firstName="Eleazar",lastName="eleazartracana@gmail.com",}
            };
        }
    }
}
