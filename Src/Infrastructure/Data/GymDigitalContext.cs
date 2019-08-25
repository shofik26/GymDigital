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
    }
}
