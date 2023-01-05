using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShowRooms.Models;

namespace ShowRooms.Data
{
    public class ShowRoomsContext : DbContext
    {
        public ShowRoomsContext (DbContextOptions<ShowRoomsContext> options)
            : base(options)
        {
        }

        public DbSet<ShowRooms.Models.Car> Car { get; set; } = default!;
        public DbSet<ShowRooms.Models.Category> Categorys { get; set; } = default!;
        public DbSet<ShowRooms.Models.Service> Services { get; set; } = default!;
        public DbSet<ShowRooms.Models.Car_store> Car_stores { get; set; } = default!;

        public DbSet<ShowRooms.Models.Store> Stores { get; set; } = default!;
        public DbSet<ShowRooms.Models.Contact> Contacts { get; set; } = default!;



    }
}
