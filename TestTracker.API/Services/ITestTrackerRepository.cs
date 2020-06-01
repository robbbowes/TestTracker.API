using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTracker.API.Entities;

namespace TestTracker.API.Services
{
    public interface ITestTrackerRepository
    {
        IEnumerable<Package> GetPackages();
    }
}
