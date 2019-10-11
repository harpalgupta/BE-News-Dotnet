using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Article.Models;
using User.Models;

namespace BE_NewsApi.Models
{
    [Table("comments")]
    public class CommentItem
    {
        [Key, Column("comment_id"), JsonProperty]
        public int Id { get; set; }

        [ForeignKey("UserId")]
        [Column("user_id"), JsonProperty]
        public int UserId { get; set; }
        public virtual UserItem User { get; set; }


        [Column("article_id")]
        public int ArticleId { get; set; }

        [ForeignKey("ArticleId")]
        public virtual ArticleItem Article { get; set; }


        [Column("votes"), JsonProperty]
        public int Votes { get; set; }
        [Column("created_at"), JsonProperty]
        public DateTime CreatedAt { get; set; }
        [Column("body"), JsonProperty]
        public string Body { get; set; }
    }
}