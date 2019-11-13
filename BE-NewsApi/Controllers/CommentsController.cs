using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Article.Models;
using BE_NewsApi.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using User.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BE_NewsApi.Controllers
{


    [Route("api/[controller]")]
    public class CommentsController : Controller
    {
        private readonly NewsContext _context;

        public CommentsController(NewsContext context)
        {
            _context = context;
        }
        // GET: api/articles
        [HttpGet]
        public ActionResult<List<CommentItem>> Get()
        {


            return _context.Comments?.ToList();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public ActionResult<CommentItem> Get(int id)
        {
            return _context.Comments.FirstOrDefault(u => u.Id == id);
        }

        // POST api/<controller>
        [HttpPost]
        public async Task<ActionResult<CommentItem>> Post([FromBody]CommentItem comment)
        {
            _context.Comments.Add(comment);
            await _context.SaveChangesAsync();
            return comment;

        }

        //// PUT api/<controller>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{

        //}

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CommentItem>> Delete(int id)
        {
            var deleteComment = _context.Comments.FirstOrDefault(u => u.Id == id);

            _context.Comments.Remove(deleteComment);
            await _context.SaveChangesAsync();
            return deleteComment;

        }
    }
}
