using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Wba.MovieRating.Domain.Entities
{
    public class Movie
    {
        
        public long MovieId { get; set; }
        public string Title { get; set; }
        public DateTime? ReleaseDate { get; set; }
    }
}
