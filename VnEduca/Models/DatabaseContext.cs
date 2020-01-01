using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VnEduca.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>().HasData(new Account[] {
            new Account() {Id=1, UserName = "namvh", Password = "12345", Email = "mjnamjkaze@gmail.com" },
            new Account() {Id=2, UserName = "admin", Password = "12345", Email = "vo.hai.nam@gosei.com.vn" }
            });


            modelBuilder.Entity<Course>().HasData(new Course[] {
            new Course() { Id=1, CourseName=@"Lập trình C#",Description=@"Dạy bạn lập trình c#" },
            });
        }


        //entities
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Lession> Lessions { get; set; }
        public DbSet<LessionCategory> LessionCategorys { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<TextLesstion> TextLesstions { get; set; }
        public DbSet<VideoLesstion> VideoLesstions { get; set; }
    }
}
