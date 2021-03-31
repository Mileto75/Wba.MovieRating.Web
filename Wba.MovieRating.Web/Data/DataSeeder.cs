using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wba.MovieRating.Domain.Entities;

namespace Wba.MovieRating.Web.Data
{
    public static class DataSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            //seeding data klaarzetten
            //denk aan de volgorde!!
            var companies = new Company[]
            {
                new Company{Id=1,Name="Warner Bros"},
                new Company{Id=2,Name="Universal"},
                new Company{Id=3,Name="Pixar"}
            };
            //
        }
    }
}
