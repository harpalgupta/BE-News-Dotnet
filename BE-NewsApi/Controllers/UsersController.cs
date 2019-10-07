using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using User.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BE_NewsApi.Controllers
{
    public class Blah
    {
        [JsonProperty]
        public string Hello { get; set; }
    }

    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        private readonly UserContext _context;

        public UsersController(UserContext context)
        {
            _context = context;


        }
        // GET: api/users
        [HttpGet]
        public ActionResult<List<UserItem>> Get()
        {
            return _context.Users?.ToList();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public ActionResult<UserItem> Get(int id)
        {
            return _context.Users
                .Where(u => u.Id == id).FirstOrDefault();
        }

        // POST api/<controller>
        [HttpPost]
        public async Task<ActionResult<UserItem>> Post([FromBody]UserItem user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return user;

        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {

        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
