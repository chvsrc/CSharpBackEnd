using Microsoft.AspNetCore.Mvc;

namespace MicroservicesProject1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Services1Controller : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Services1-Controller-Data";
        }
    }
}
