using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wba.MovieRating.Domain.Entities;

namespace Wba.MovieRating.Web.Data
{
    public class MovieDbContext : DbContext
    {
        //entities
        public DbSet<Movie> Movies { get; set; }
        public DbSet<User> Users { get; set; }
        public MovieDbContext(DbContextOptions options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //configure movie table
            modelBuilder.Entity<Movie>()
                .HasKey(m => m.MovieId);
                
                
                
                
            
            //eigen implementatie
            //fluent api configuration
            base.OnModelCreating(modelBuilder);
        }
    }
}
