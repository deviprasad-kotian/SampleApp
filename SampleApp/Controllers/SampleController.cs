using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SampleApp.Domain.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SampleApp.Controllers
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
            try
            {
                return _context.sample_tbl.ToList();
            }
            catch (Exception ex)
            {

                return Ok(ex.Message + "\nNew Error\n"+ex.StackTrace);

            }
           
        }

        // GET api/<SampleController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SampleController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
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
