using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestTracker.API.Models
{
    public class TestDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsBroken { get; set; }
        public int TimesBroken { get; set; }
        public int NumberOfBreakages 
        { 
            get
            {
                return Breakages.Count;
            }
        }
        public ICollection<BreakageDto> Breakages { get; set; }
            = new List<BreakageDto>();
    }
}
