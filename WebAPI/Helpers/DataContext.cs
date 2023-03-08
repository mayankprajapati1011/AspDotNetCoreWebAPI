using BCryptNet = BCrypt.Net.BCrypt;
using Microsoft.EntityFrameworkCore;
using WebAPI.Entities;

namespace WebAPI.Helpers
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>()
            .HasOne<Blog>()
            .WithMany(b => b.Posts)
            .HasForeignKey(p => p.BlogId);
        

        //modelBuilder.Entity<Post>()
        //.HasOne(p => p.Blog)
        //.WithMany(b => b.Posts);

        //    modelBuilder.Entity<Blog>()
        //.Navigation(b => b.Posts)
        //.UsePropertyAccessMode(PropertyAccessMode.Property);

        //modelBuilder.Entity<User>().HasData(
        //    new User
        //    {
        //        Id = 1,
        //        FirstName = "Mayank",
        //        LastName = "Prajapati",
        //        Username = "mayank.prajapati",
        //        PasswordHash = BCryptNet.HashPassword("123")
        //    });
    }
        public DbSet<User> Users { get; set; }
        public DbSet<Course> Cources { get; set; }
        public DbSet<Department> Departments { get; set; }

        public DbSet<Blog> Blogs { get; set; }

        public DbSet<Post> Posts { get; set; }

    }
}
