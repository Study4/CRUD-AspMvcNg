using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAppDemo.Api.Controllers
{
    public class HelloWorldController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok("Hello World");
        }
    }
}
