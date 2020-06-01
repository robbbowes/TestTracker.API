using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTracker.API.Models;

namespace TestTracker.API
{
    public class TestTrackerDataStore
    {
        public static TestTrackerDataStore Current { get; } = new TestTrackerDataStore();
        public List<PackageDto> Packages { get; set; }

        public TestTrackerDataStore()
        {
            Packages = new List<PackageDto>()
            {
                new PackageDto()
                {
                    Id = 1,
                    Name = "Package #1",
                    Tests = new List<TestDto>()
                    {
                        new TestDto()
                        {
                            Id = 1,
                            Name = "Test #1",
                            Description = "Test #1 Description",
                            IsBroken = true,
                            TimesBroken = 3,
                            Breakages = new List<BreakageDto>()
                            {
                                new BreakageDto()
                                {
                                    Id = 1,
                                    Reason = "Timeout"
                                }
                            }
                        }
                    }
                },
                new PackageDto()
                {
                    Id = 2,
                    Name = "Package #2",
                    Tests = new List<TestDto>()
                    {
                        new TestDto()
                        {
                            Id = 2,
                            Name = "Test #2",
                            Description = "Test #2 Description",
                            IsBroken = false,
                            TimesBroken = 0
                        }
                    }
                }
            };
        }
    }
}
