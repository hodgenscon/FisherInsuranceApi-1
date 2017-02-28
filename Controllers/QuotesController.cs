using FisherInsuranceApi.Data;
using FisherInsuranceApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace FisherInsuranceApi.Controllers
{
    [Route("api/quotes")]
    public class QuotesController : Controller
    {
        private readonly FisherContext db;

        public QuotesController(FisherContext context)
        {
            db = context;
        }


        [HttpGet]
        public IActionResult GetQuotes()
        {
            return Ok(db.Quotes.Where(q => q.Price > 90));

        }

        [HttpPost]
        public IActionResult Post([FromBody] Quote quote)
        {
            return Ok(db.Quotes.Add(quote));
        }


        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(db.Quotes.Find(id));
        }


        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Quote quote)
        {
            return Ok(db.Quotes.Update(quote));
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var quoteToDelete = db.Quotes.Find(id);
            db.Quotes.Remove(quoteToDelete);
            return Ok();

        }

    }
}
