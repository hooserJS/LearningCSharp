using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace ASPCoreWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarsController : ControllerBase
    {



        List<Cars> CarList = new List<Cars> {
        new Cars("Mercedes", 5, "Blue", 1700),
        new Cars("BMV", 2, "Black", 2700),
        new Cars("ISUZU", 9, "White", 900),
        new Cars("VW", 6, "Silver", 1500)
    };
        

        private readonly ILogger<CarsController> _logger;

        public CarsController(ILogger<CarsController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetCars")]

        public IEnumerable<Cars> Get()
        {
            return CarList;
        }
    }
}