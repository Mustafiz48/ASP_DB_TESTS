using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP_DB_TESTS.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ASP_DB_TESTS.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }

        public DbSet<Book> Books { get; set; }

        public DbSet<BookCharacter> BookCharacters { get; set; }


    }

}
