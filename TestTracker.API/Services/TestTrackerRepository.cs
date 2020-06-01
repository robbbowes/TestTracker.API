using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTracker.API.Contexts;
using TestTracker.API.Entities;

namespace TestTracker.API.Services
{
    public class TestTrackerRepository : ITestTrackerRepository
    {
        private readonly TestTrackerContext _context;

        public TestTrackerRepository(TestTrackerContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IEnumerable<Package> GetPackages()
        {
            throw new NotImplementedException();
        }
    }
}
