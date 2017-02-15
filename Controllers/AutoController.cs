using System.Collections.Generic;
using FisherInsuranceApi.Data;
using FisherInsuranceApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace FisherInsuranceApi.Controllers
{
    [Route("api/auto/quotes")]
    public class AutoController : Controller
    {
        private IMemoryStore db;

        public AutoController(IMemoryStore repo)
        {
            db = repo;
            
        }
        

        [HttpGet]
        public IActionResult GetQuotes()
        {
            return Ok(db.RetrieveAllQuotes);

        }
        
        [HttpPost]
        public IActionResult Post([FromBody] Quote quote)
        {
            return Ok(db.CreateQuote(quote));
        }


        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(db.RetrieveQuote(id));
        }


        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Quote quote)
        {
            return Ok(db.UpdateQuote(quote));
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            db.DeleteQuote(id);
            return Ok();

        }

    }
}
