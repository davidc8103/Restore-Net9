using System;
using API.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class StoreContext(DbContextOptions options) : IdentityDbContext<User>(options)
    {
        public required DbSet<Product> Products { get; set; }
        public required DbSet<Basket> Baskets { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>()
                .HasData(
                    new IdentityRole { Id = "5b1c64c5-bb1f-4ecd-ad84-1ee7ef496f9a", Name = "Member", NormalizedName = "MEMBER" },
                    new IdentityRole { Id = "a05beb93-17e6-4ec3-ba73-554a1234ce25", Name = "Admin", NormalizedName = "ADMIN" }
                );
        }
    }
}