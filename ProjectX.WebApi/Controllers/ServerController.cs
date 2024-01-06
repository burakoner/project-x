using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjectX.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectX.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ServerController : ControllerBase
    {
        public ServerController()
        {
        }

        [HttpGet("")]
        public string Get() 
        {
            return "Server is running...";
        }

        [HttpGet("test")]
        public ActionResult Get2()
        {
            return this.Ok("Test is running...");
        }


        [HttpGet("test2")]
        public ActionResult Test2()
        {
            var response = new ApiResponse();
            response.Data = "Test2 is running...";



            return this.Ok(response);
        }
    }
}
