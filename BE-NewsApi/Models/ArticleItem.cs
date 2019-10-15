using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BE_NewsApi.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using User.Models;

namespace Article.Models
{
    [Table("articles")]
    public class ArticleItem
    {
        [Key, Column("article_id"), JsonProperty]
        public int Id { get; set; }
        [Column("comments"), JsonProperty]
        public IEnumerable<CommentItem> Comments { get; set; }
        [Column("title"), JsonProperty]
        public string Title { get; set; }
        [Column("votes"), JsonProperty]
        public int Votes { get; set; }
        [Column("created_at"), JsonProperty]
        public DateTime CreatedAt { get; set; }
        [Column("body"), JsonProperty]
        public string Body { get; set; }

        [Column("topic"), JsonProperty]
        public string Topic { get; set; }


        [ForeignKey("Topic")]
        public virtual TopicItem TopicItem { get; set; }

        [Column("user_id"), JsonProperty]
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual UserItem UserItem { get; }




    }
}