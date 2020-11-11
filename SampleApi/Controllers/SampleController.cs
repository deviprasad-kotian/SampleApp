using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SampleApi.Domain.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SampleApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        ApplicationDbContext _context;
        public SampleController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: api/<SampleController>
        [HttpGet]
        public ActionResult<List<sample_tbl>> Get()
        {
            return _context.sample_tbl.ToList();
        }

        // GET api/<SampleController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SampleController>
        [HttpGet("test")]
        public void test()
        {
            _context.sample_tbl.Add(new sample_tbl() { id = 2, name = "abc", email = "abc@mail.com" });
            _context.SaveChanges();
        }

        // PUT api/<SampleController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SampleController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
