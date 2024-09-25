using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Principal;

namespace Blazor_Login_System.Data
{
    public class MySqlDbContext : DbContext
    {
        public MySqlDbContext(DbContextOptions<MySqlDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>()
                .HasIndex(u => u.userName)
                .IsUnique();
            builder.Entity<User>()
                .HasIndex(u => u.emailAddress)
                .IsUnique();
        }
    }

    public class User
    {
        public int UserId { get; set; }
        [Column(TypeName = "varchar(40)")]
        public string userName { get; set; }
        [Column(TypeName = "varchar(255)")]
        public string password { get; set; }
        [Column(TypeName = "varchar(40)")]
        public string firstName { get; set; }
        [Column(TypeName = "varchar(40)")]
        public string lastName { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string emailAddress { get; set; }
    }
}
