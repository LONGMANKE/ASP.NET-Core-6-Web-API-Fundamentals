using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers
{
    [ApiController]
    public class CitiesController : ControllerBase
    {
        public JsonResult GetCities()
        {
            return new JsonResult(
                new List<object>
                {
                    new {id=1, Name ="Nairobi"},
                    new {id=2, Name ="Kawangware"}
                });
        }
    }
}
