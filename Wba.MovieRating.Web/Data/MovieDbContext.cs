﻿using Microsoft.EntityFrameworkCore;
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
                






            //eigen implementatie
            //fluent api configuration
            base.OnModelCreating(modelBuilder);
        }
    }
}
