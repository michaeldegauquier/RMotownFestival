using Microsoft.EntityFrameworkCore;
using RMotownFestival.Api.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RMotownFestival.Api.Data
{
    public class MotownDbContext : DbContext
    {
        public MotownDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        public DbSet<Artist> Artists { get; set; }
        public DbSet<Festival> Festivals { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<ScheduleItem> ScheduleItems { get; set; }
        public DbSet<Stage> Stages { get; set; }
    }
}
