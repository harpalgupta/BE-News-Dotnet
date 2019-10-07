using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace User.Models
{
    [Table("users")]
    public class UserItem
    {
        [Key, Column("user_id"), JsonProperty]
        public int Id { get; set; }
        [Column("username"), JsonProperty]
        public string Username { get; set; }
        [Column("name"), JsonProperty]
        public string Name { get; set; }
        [Column("avatar_url"), JsonProperty]
        public string Avatar_url { get; set; }
    }
}