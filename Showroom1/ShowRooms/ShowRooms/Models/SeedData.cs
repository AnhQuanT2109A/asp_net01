using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.CodeAnalysis.Elfie.Serialization;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.DependencyInjection;
using ShowRooms.Data;
using System;
using System.Linq;

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
                          Price = 9000
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
                          Price = 9000
                    }
                };
                foreach (Car ca in cars)
                {
                    context.Car.Add(ca);

                }
                context.SaveChanges();

                //category
                var categorys = new Category[]
                {
                    new Category
                    {
                        CarID = cars.Single(ca => ca.Fullname == "Car 1").Id,
                        exterior_color ="black",
                        work_productivity="200",
                        cylinder_number=21,
                    },
                     new Category
                    {
                       CarID = cars.Single(ca => ca.Fullname == "Car 2").Id,
                       exterior_color ="red",
                       work_productivity="2199",
                       cylinder_number=50
                    }
                 };
                 foreach (Category cate in categorys)
                       {
                         context.Categorys.Add(cate);
                    }
                context.SaveChanges();


                var stores = new Store[]
              {
                    new Store
                    {
                        StoreID = cars.Single(ca => ca.Fullname == "Car 1").Id,
                        Service = "Advanced service",

                    },
                    new Store
                    {
                        StoreID = cars.Single(ca => ca.Fullname == "Car 2").Id,
                        Service = "Basic service"
                    },
              };
                foreach (Store sto in stores)
                {
                    context.Stores.Add(sto);
                }
                context.SaveChanges();


                // service
                var services = new Service[]
                {
                    new Service
                    {
                       StoreID=stores.Single(sto => sto.Service == "Advanced service").ID,
                       inurance="1 year",
                       aotomotive_parts="full option",
                       service_about_car="basic",
                    },
                     new Service
                    {
                     StoreID=stores.Single(sto => sto.Service == "Basic service").ID,
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

           
              //car_store
                var car_stores = new Car_store[]
                    {
                       new Car_store
                       {
                          CarID = cars.Single(ca => ca.Fullname == "Car 1").Id,
                          
                     },
                      new Car_store
                      {
                          CarID = cars.Single(ca => ca.Fullname == "Car 2").Id,
                     },
                };
                 foreach (Car_store Car_ in car_stores)
                       {
                       context.Car_stores.Add(Car_);
                  }
                  context.SaveChanges();

                //contact
                var contact = new Contact[]
                {
                    new Contact
                    {
                        StoreID = stores.Single(sto => sto.Service == "Advanced service").ID,
                        username = "John",
                        address="Usa",
                        phone="955234243",
                        mail_address="abc@gmail.com",
                        date = DateTime.Parse("1992-1-11"),
                    },
                    new Contact
                    {
                        StoreID = stores.Single(sto => sto.Service == "Advanced service").ID,
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
