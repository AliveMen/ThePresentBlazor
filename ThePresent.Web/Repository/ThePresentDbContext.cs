using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ThePresent.Web.Data.DbModel;

namespace ThePresent.Web.Repository
{
    public class ThePresentDbContext : IdentityDbContext<CustomerEntity>
    {
        public ThePresentDbContext(DbContextOptions<ThePresentDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {


            //builder.Entity<CustomerEntity>(b =>
            //{
            //    // Each User can have many UserClaims
            //    b.HasMany(e => e.)
            //        .WithOne()
            //        .HasForeignKey(uc => uc.UserId)
            //        .IsRequired();
            //});


            builder.Entity<PresentEntity>().ToTable("Present").HasKey(x => x.Id);
            builder.Entity<PresentEntity>().Property(x => x.Id).HasMaxLength(128).ValueGeneratedOnAdd();
            builder.Entity<PresentEntity>().HasOne(m => m.Customer).WithMany(x => x.Presents)
                .HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.Cascade);

            builder.Entity<FriendEntity>().ToTable("Friend").HasKey(x => x.Id);
            builder.Entity<FriendEntity>().Property(x => x.Id).HasMaxLength(128).ValueGeneratedOnAdd();
            builder.Entity<FriendEntity>().HasOne(m => m.Customer).WithMany(x => x.Friends)
                .HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(builder);
        }
    }
}
