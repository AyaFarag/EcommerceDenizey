using Ecommerce.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Infrastructure.Presistance
{
    public static class SeedingData
    {
        public static void CategorySeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category() { Id = 1, Name = "Cat 1"  },
                new Category() { Id = 2, Name = "Cat 2" },
                new Category() { Id = 3, Name = "Cat 3" },
                new Category() { Id = 4, Name = "Cat 4" },
                new Category() { Id = 5, Name = "Cat 5" }

                );

           
        }

        public static void UserSeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
               new User() { Id = 1, FirstName = "Ahmed", LastName = "Mohamed", Email = "a@gmail.com", Password = "123456" },
               new User() { Id = 2, FirstName = "Ibrahim", LastName = "Mohamed", Email = "ah@gmail.com", Password = "123456" },
               new User() { Id = 3, FirstName = "Fath", LastName = "Mohamed", Email = "f@gmail.com", Password = "123456" }
               );
        }
    }
}
