using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTracker.API.Entities;

namespace TestTracker.API.Controllers
{
    [ApiController]
    [Route("api/packages")]
    public class PackageController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetPackages()
        {
            return Ok(new List<Package>()
            {

            });
        }

/*        [HttpGet("{id}")]
        public IActionResult GetPackageById(int id)
        {

        }*/

        
    }
}
