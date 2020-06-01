using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTracker.API.Entities;

namespace TestTracker.API.Models
{
    public class PackageDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberOfTests
        {
            get
            {
                return Tests.Count;
            }
        }
        public ICollection<TestDto> Tests { get; set; }
            = new List<TestDto>();
    }
}
