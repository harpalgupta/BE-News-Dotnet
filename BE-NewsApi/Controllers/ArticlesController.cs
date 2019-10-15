﻿using System;
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
    public class ArticlesController : Controller
    {
        private readonly NewsContext _context;

        public ArticlesController(NewsContext context)
        {
            _context = context;


        }
        // GET: api/articles
        [HttpGet]
        public ActionResult<List<ArticleItem>> Get()
        {
            return _context.Articles?.ToList();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public ActionResult<ArticleItem> Get(int id, Paging paging)
        {

            return _context.Articles
                .Where(u => u.Id == id).FirstOrDefault();
        }

        // POST api/<controller>
        [HttpPost]
        public async Task<ActionResult<ArticleItem>> Post([FromBody]ArticleItem article)
        {
            _context.Articles.Add(article);
            await _context.SaveChangesAsync();
            return article;

        }

        //// PUT api/<controller>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{

        //}

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ArticleItem>> Delete(int id)
        {
            var deleteArticle = _context.Articles
                .Where(u => u.Id == id).FirstOrDefault();

            _context.Articles.Remove(deleteArticle);
            await _context.SaveChangesAsync();
            return deleteArticle;

        }
    }
}
