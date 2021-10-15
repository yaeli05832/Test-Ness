using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        [HttpGet("GetCity/{city}")]
        public List<string> GetCity(string s)
        {
            List<string> list = new List<string>();
            list.Add("hello");
            return list;
        }
    }
}
