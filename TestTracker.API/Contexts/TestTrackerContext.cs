using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTracker.API.Entities;

namespace TestTracker.API.Contexts
{
    public class TestTrackerContext : DbContext
    {
        public DbSet<Package> Packages { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<Breakage> Breakages { get; set; }

        public TestTrackerContext(DbContextOptions<TestTrackerContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Package>()
                .HasData(
                new Package()
                {
                    Id = 1, Name = "Package #1"
                },
                new Package()
                {
                    Id = 2, Name = "Package #2"
                },
                new Package()
                {
                    Id = 3,
                    Name = "Package #3"
                });

            modelBuilder.Entity<Test>()
                .HasData(
                new Test()
                {
                    Id = 1, 
                    Name = "Test 1", 
                    Description = "Test 1 Description", 
                    PackageId = 1, 
                    IsBroken = true, 
                    TimesBroken = 3
                },
                new Test()
                {
                    Id = 2,
                    Name = "Test 2",
                    Description = "Test 2 Description",
                    PackageId = 2,
                    IsBroken = false,
                    TimesBroken = 0
                },
                new Test()
                {
                    Id = 3,
                    Name = "Test 3",
                    Description = "Test 3 Description",
                    PackageId = 3,
                    IsBroken = false,
                    TimesBroken = 0
                },
                new Test()
                {
                    Id = 4,
                    Name = "Test 4",
                    Description = "Test 4 Description",
                    PackageId = 1,
                    IsBroken = false,
                    TimesBroken = 0
                });

            modelBuilder.Entity<Breakage>()
                .HasData(
                new Breakage()
                {
                    Id = 1,
                    Reason = "Timeout",
                    TestId = 4
                });

            base.OnModelCreating(modelBuilder);
        }

    }
}
