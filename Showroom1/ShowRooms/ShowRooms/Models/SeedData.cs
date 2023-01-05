using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.CodeAnalysis.Elfie.Serialization;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.DependencyInjection;
using ShowRooms.Data;
using System;
using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ShowRooms.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ShowRoomsContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ShowRoomsContext>>()))
            {
                // Look for any movies.
                if (context.Car.Any())
                {
                    return;   // DB has been seeded
                }


                //category
                var categorys = new Category[]
                {
                    new Category
                    {
                        Name = "Family"
                    },
                    new Category
                    {
                        Name = "Sport"
                    },

                 };
                foreach (Category cate in categorys)
                {
                    context.Categorys.Add(cate);
                }
                context.SaveChanges();



                // car
                var cars = new Car[] {
                    new Car
                    {
                         Fullname= "Car 1",
                         Year    = DateTime.Parse("2022-1-15"),
                          Length = 4800,
                          Width = 1437,
                         Height = 1437,
                          Weight = 1650,
                          Maximum_weight = "2165kg",
                          Top_speed = 248,
                          Interior_color = "black",
                          number_of_seat = 4,
                          Price = 9000,
                          CategoryID=categorys.Single(cate => cate.Name == "Family").Id,
                          

                    },
                     new Car
                    {
                         Fullname   = "Car 2",
                         Year    = DateTime.Parse("2022-1-11"),
                          Length = 4800,
                          Width = 1437,
                         Height = 1437,
                          Weight = 1650,
                          Maximum_weight = "2165kg",
                          Top_speed = 248,
                          Interior_color = "black",
                          number_of_seat = 4,
                          Price = 9000,
                          CategoryID=categorys.Single(cate => cate.Name == "Sport").Id


                    }
                };
                foreach (Car ca in cars)
                {
                    context.Car.Add(ca);

                }
                context.SaveChanges();


                var stores = new Store[]
             {
                    new Store
                    {
                       Name = "Ha Noi"
                    },
                    new Store
                    {
                        Name = "Sai Gon"
                    },
             };
                foreach (Store sto in stores)
                {
                    context.Stores.Add(sto);
                }
                context.SaveChanges();

                //car_store
                var car_stores = new Car_store[]
                    {
                       new Car_store
                       {
                          CarID = cars.Single(ca => ca.Fullname == "Car 1").Id,
                         StoreID = stores.Single(sto => sto.Name == "Sai Gon").ID


                     },
                      new Car_store
                      {
                          CarID = cars.Single(ca => ca.Fullname == "Car 2").Id,
                          StoreID = stores.Single(sto => sto.Name == "Sai Gon").ID

                     },
                };
                foreach (Car_store Car_ in car_stores)
                {
                    context.Car_stores.Add(Car_);
                }
                //context.SaveChanges();

               

                // service
                var services = new Service[]
                {
                    new Service
                    {
                       inurance="1 year",
                       aotomotive_parts="full option",
                       service_about_car="basic",
                    },
                     new Service
                    {
                       inurance="2 year",
                       aotomotive_parts="no",
                       service_about_car="classic",
                     }
                };
                     foreach (Service se in services)
                   {
                        context.Services.Add(se);
                   }
                context.SaveChanges();

           
             

                //contact
                var contact = new Contact[]
                {
                    new Contact
                    {
                        username = "John",
                        address="Usa",
                        phone="955234243",
                        mail_address="abc@gmail.com",
                        date = DateTime.Parse("1992-1-11"),
                    },
                    new Contact
                    {
                        username = "Tom",
                        address="Franch",
                        phone="955234243",
                        mail_address="bbc@gmail.com",
                        date = DateTime.Parse("1984-1-16"),
                    },
                };
            }
        }
    }
}
