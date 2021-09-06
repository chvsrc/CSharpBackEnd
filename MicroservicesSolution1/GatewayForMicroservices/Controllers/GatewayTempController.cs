﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GatewayForMicroservices.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GatewayTempServicesController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Gateway-Temp-Services-Data";
        }
    }
}
