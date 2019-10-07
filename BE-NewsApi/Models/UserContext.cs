using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using User.Models;

namespace User.Models
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {
        }

        public DbSet<UserItem> Users { get; set; }

    }
}