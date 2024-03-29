﻿using goodtrip.Storage.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace goodtrip.Storage
{
    public class GoodTripContext : IdentityDbContext<User, UserRole, Guid>
    {
        public GoodTripContext(DbContextOptions<GoodTripContext> options) : base(options)
        {
        }
        public DbSet<UserOperatorProfile> UserOperatorProfiles { get; set; }
        public DbSet<UserCustomerProfile> UserCustomerProfiles { get; set; }
        public DbSet<Tour> Tours { get; set; }

        public DbSet<Hotel> Hotels { get; set; }

        public DbSet<Excurtion> Excurtions { get; set; }

        public DbSet<Review> Reviews { get; set; }
        public DbSet<ImageExcurtion> ImagesExcurtion { get; set; }
        public DbSet<ImageHotel> ImagesHotel { get; set; }
        public DbSet<Request> Requests { get; set; }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<User>()
                .HasOne(u => u.Profile)
                .WithOne(p => p.User)
                .HasForeignKey<UserProfile>(p => p.UserId);
        }
    }
}
