using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace myapi.controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SayHelloController : ControllerBase
    {
        [HttpPost]
        [Route("SayHello/{addName}")]
        public string HelloMessage(string addName)
        {
            
            return $"Hello,{addName}!";
        }

    }
}