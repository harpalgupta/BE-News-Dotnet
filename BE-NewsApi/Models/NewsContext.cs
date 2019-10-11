using System.ComponentModel.DataAnnotations.Schema;
using Article.Models;
using BE_NewsApi.Models;
using Microsoft.EntityFrameworkCore;
using User.Models;

namespace User.Models
{
    public class NewsContext : DbContext
    {
        public NewsContext(DbContextOptions<NewsContext> options) : base(options)
        {
        }

        public DbSet<UserItem> Users { get; set; }

        public DbSet<CommentItem> Comments { get; set; }

        public DbSet<TopicItem> Topics { get; set; }

        public DbSet<ArticleItem> Articles { get; set; }


    }
}