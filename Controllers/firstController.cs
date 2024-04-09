using Microsoft.AspNetCore.Mvc;
using webapi_tutorial.Models;

namespace webapi_tutorial.Controllers
{
    [Route("api/first")]
    [ApiController]
    public class firstController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<First> getFirst()
        {
            

           return new List<First>
            {
                new First{Id=1,Name="lakshay"},
                new First{Id=2,Name="Nitin mishra"},
            };
        }
    }
}
