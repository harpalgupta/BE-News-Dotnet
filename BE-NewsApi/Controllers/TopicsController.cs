using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Article.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using User.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BE_NewsApi.Controllers
{


    [Route("api/[controller]")]
    public class TopicsController : Controller
    {
        private readonly NewsContext _context;

        public TopicsController(NewsContext context)
        {
            _context = context;


        }
        // GET: api/articles
        [HttpGet]
        public ActionResult<List<TopicItem>> Get()
        {
            return _context.Topics?.ToList();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public ActionResult<TopicItem> Get(string slug)
        {
            return _context.Topics
                .Where(u => u.Slug == slug).FirstOrDefault();
        }

        // POST api/<controller>
        [HttpPost]
        public async Task<ActionResult<TopicItem>> Post([FromBody]TopicItem topic)
        {
            _context.Topics.Add(topic);
            await _context.SaveChangesAsync();
            return topic;

        }

        //// PUT api/<controller>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{

        //}

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TopicItem>> Delete(string slug)
        {
            var deleteTopic = _context.Topics
                .Where(t => t.Slug == slug).FirstOrDefault();

            _context.Topics.Remove(deleteTopic);
            await _context.SaveChangesAsync();
            return deleteTopic;

        }
    }
}
