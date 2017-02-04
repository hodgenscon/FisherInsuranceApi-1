using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FisherInsuranceApi.Controllers
{
    [Route("api/auto/quotes")]
    public class AutoController : Controller
    {

        // GET api/auto/quotes/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok("The id is: " + id);
        }

        // POST api/auto/quotes
        [HttpPost]
        public IActionResult Post([FromBody]string value)
        {
            return Created("", value);
        }

        // PUT api/auto/quotes/id
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]string value)
        {
            return NoContent();
        }

        // DELETE api/auto/quotes/id
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }
    }
}
