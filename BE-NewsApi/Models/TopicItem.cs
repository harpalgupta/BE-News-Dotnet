using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BE_NewsApi.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Article.Models
{
    [Table("topics")]
    public class TopicItem
    {
        [Key, Column("slug"), JsonProperty]
        public string Slug { get; set; }
        [Column("description"), JsonProperty]
        public string String { get; set; }
    }
}