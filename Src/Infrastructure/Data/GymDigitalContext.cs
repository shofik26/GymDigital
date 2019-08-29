using ApplicationCore.Entities.MembershipAggregate;
using ApplicationCore.Entities.UserAggregate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data
{
    public class GymDigitalContext : DbContext
    {
        public GymDigitalContext(DbContextOptions<GymDigitalContext> options) : base(options)
        {

        }

        public DbSet<Account> Users { get; set; }
        public DbSet<Category> MembershipCategories { get; set; }
        public DbSet<InstallmentPlan> MembershipInstallmentPlans { get; set; }
        public DbSet<Membership> Memberships { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Membership>()
                .Property(membership => membership.Amount)
                .HasColumnType("DECIMAL(12,2)");

            modelBuilder.Entity<Membership>()
                .Property(membership => membership.Installment)
                .HasColumnType("DECIMAL(12,2)");

            modelBuilder.Entity<Membership>()
                .Property(membership => membership.SignupFee)
                .HasColumnType("DECIMAL(12,2)");
        }
    }
}
