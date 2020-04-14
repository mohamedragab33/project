using Microsoft.EntityFrameworkCore;
using project.api.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project.api.EntityModels
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<User> User { get; set; }
        public DbSet<Posts> Post { get; set; }
        public DbSet<Category> Categaory { get; set; }
        public DbSet<Reply> Reply { get; set; }
        public DbSet<catguser> catgusers { get; set; }
/*
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // seed the database with dummy data
            modelBuilder.Entity<User>().HasData(
                new User()
                {
                    ID_User = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                    User_Name = "MOHAMED RAGAB",
                    Email = "Moha.ragab33@gmail.com",
                    Birth_date = new DateTime(1650, 7, 23),
                    Gender = "male",
                    Confirmed_Email = true,
                    Confirmed_Phone = true,
                    Date_Created = new DateTime(1650, 7, 23),
                    Password = "ASD46132",
                    Phone = "01025021692"


                } 

                );
        }
     */
    } 
}
