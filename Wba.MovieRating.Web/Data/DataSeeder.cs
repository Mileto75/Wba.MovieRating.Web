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
            //companies
            var companies = new Company[]
            {
                new Company{Id=1,Name="Warner Bros"},
                new Company{Id=2,Name="Universal"},
                new Company{Id=3,Name="Pixar"}
            };
            //users
            var users = new User[]
            {
                new User{Id=1,FirstName="Slash", LastName="Slash",Username="slash@GandR.com" },
                new User{Id=2,FirstName="John", LastName="Frusciante",Username="johnF@RedHotChillis.com" }
            };
            //Actors
            var actors = new Actor[]
            {
                new Actor{Id=1,FirstName="Keanu",LastName="Reeves"},
                new Actor{Id=2,FirstName="Kim",LastName="Basinger"},
                new Actor{Id=3,FirstName="Robert",LastName="De Niro"},
                new Actor{Id=4,FirstName="Walter",LastName="Capiau"},
            };
            //Directors
            var directors = new Director[]
            {
                new Director{Id=1,FirstName="Steven",LastName="Spielberg"},
                new Director{Id=2,FirstName="Sly",LastName="Stallone"},
                new Director{Id=3,FirstName="Kathryn",LastName="Bigelow"}
            };
            //movies
            var movies = new Movie[]
            {
                new Movie{Id=1,Title="Point Break",CompanyId=1 },
                new Movie{Id=2,Title="Rocky",CompanyId=2 },
                new Movie{Id=3,Title="Rambo",CompanyId=1 }
            };
            //MovieActors
            var movieActors = new MovieActors[]
            {
                new MovieActors{ActorId=1,MovieId=1},
                new MovieActors{ActorId=2,MovieId=3},
                new MovieActors{ActorId=2,MovieId=2},
                new MovieActors{ActorId=3,MovieId=3}
            };
            //movieDirectors
            var movieDirectors = new MovieDirectors[]
            {
                new MovieDirectors{MovieId=1,DirectorId=1},
                new MovieDirectors{MovieId=2,DirectorId=2},
                new MovieDirectors{MovieId=3,DirectorId=3}
            };
            //Ratings
            var ratings = new Rating[]
            {
                new Rating{Id=1, UserId=1,MovieId=1,Score=10,Review="Very good! Loved it!"},
                new Rating{Id=2,UserId=2,MovieId=3,Score=4,Review="Sucks monkeyballs!"},
                new Rating{Id=3,UserId=2,MovieId=3,Score=10,Review="Effing awesome!!"}
            };

            //call the hasdata methods for each entity
            //mind the volgorde!!
            modelBuilder.Entity<Company>().HasData(companies);
            modelBuilder.Entity<Actor>().HasData(actors);
            modelBuilder.Entity<Director>().HasData(directors);
            modelBuilder.Entity<User>().HasData(users);
            modelBuilder.Entity<Movie>().HasData(movies);
            modelBuilder.Entity<MovieDirectors>().HasData(movieDirectors);
            modelBuilder.Entity<MovieActors>().HasData(movieActors);
            modelBuilder.Entity<Rating>().HasData(ratings);
            
        }
    }
}
