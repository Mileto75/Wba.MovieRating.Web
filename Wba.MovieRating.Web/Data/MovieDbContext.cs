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
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<MovieActors> MovieActors { get; set; }
        public DbSet<MovieDirectors> MovieDirectors { get; set; }

        public MovieDbContext(DbContextOptions options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //configure movie table
            modelBuilder.Entity<Movie>()
                .HasKey(m => m.Id);
            //movieproperties
            modelBuilder.Entity<Movie>()
                .Property(m => m.Title)
                .IsRequired()
                .HasMaxLength(200);
            modelBuilder.Entity<Movie>()
                .Property(m => m.ReleaseDate)
                .ValueGeneratedOnAdd()
                .HasDefaultValueSql("GETDATE()");
            //user table
            modelBuilder.Entity<User>()
                .HasKey(u => u.Id);
            modelBuilder.Entity<User>()
                .Property(u => u.FirstName)
                .HasMaxLength(150);
            modelBuilder.Entity<User>()
               .Property(u => u.LastName)
               .HasMaxLength(150);
            modelBuilder.Entity<User>()
                .Property(u => u.Username)
                .HasMaxLength(150)
                .IsRequired();
            
            //configure composite key for movieActors
            modelBuilder.Entity<MovieActors>()
                 .HasKey(ma => new { ma.ActorId, ma.MovieId });

            //configure composite key MovieDirectors
            modelBuilder.Entity<MovieDirectors>()
                .HasKey(md => new { md.DirectorId, md.MovieId });
            //configure relation in fluent
            base.OnModelCreating(modelBuilder);
        }
    }
}
