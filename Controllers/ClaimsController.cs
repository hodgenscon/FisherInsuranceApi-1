using FisherInsuranceApi.Data;
using FisherInsuranceApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace FisherInsuranceApi.Controllers
{
    [RouteAttribute("api/claims")]
    public class ClaimsController : Controller
    {

    private IMemoryStore db;

        public ClaimsController(IMemoryStore repo)
        {
            db = repo;
            
        }
        

        [HttpGet]
        public IActionResult GetClaims()
        {
            return Ok(db.RetrieveAllClaims);

        }
        
        [HttpPost]
        public IActionResult Post([FromBody] Claim claim)
        {
            return Ok(db.CreateClaim(claim));
        }


        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(db.RetrieveClaim(id));
        }


        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Claim claim)
        {
            return Ok(db.UpdateClaim(claim));
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            db.DeleteClaim(id);
            return Ok();

        }
    }
}