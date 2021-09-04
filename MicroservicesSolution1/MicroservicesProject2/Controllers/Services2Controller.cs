using Microsoft.AspNetCore.Mvc;

namespace MicroservicesProject2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Services2Controller : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Services2-Controller-Data";
        }
    }
}
