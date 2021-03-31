using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Wba.MovieRating.Domain.Entities
{
    public class Movie
    {
        
        public long Id { get; set; }
        public string Title { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public ICollection<MovieActors> Actors { get; set; }
        public ICollection<Rating> Ratings { get; set; }
        public Company Company { get; set; }//nav prop 
        public long CompanyId { get; set; }//foreign key
        public ICollection<MovieDirectors> Directors { get; set; }
    }
}
