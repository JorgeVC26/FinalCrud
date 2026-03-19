using Microsoft.EntityFrameworkCore;
using FinalCrud.Models;
using System.Collections.Generic;

namespace FinalCrud.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}