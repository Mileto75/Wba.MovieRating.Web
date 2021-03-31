using System;
using System.Collections.Generic;
using System.Text;

namespace Wba.MovieRating.Domain.Entities
{
    public class MovieDirectors
    {
        //foreign keys
        public long MovieId { get; set; }
        public long DirectorId { get; set; }
        //navigation props
        public Movie Movie { get; set; }
        public Director Director { get; set; }
    }
}
