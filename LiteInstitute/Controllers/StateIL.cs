using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiteInstitute.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class StateIL : ControllerBase
    {
        [HttpGet(Name = "SchoolProfile")]
        public async Task<IActionResult> SchoolProfile()
        {
            var client = new RestClient($"https://api.cps.edu/SchoolProfile/CPS/AllSchoolProfiles");
            var request = new RestRequest(Method.GET);
            IRestResponse response = await client.ExecuteAsync(request);
           
            return Ok(response.Content);
        }

    }
}
