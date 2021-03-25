using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Wba.MovieRating.Domain.Entities
{
    public class MovieActors
    {
        public long MovieId { get; set; }
        public long ActorId { get; set; }
        //navigation props
        public Movie Movie { get; set; }
        public Actor Actor { get; set; }
    }
}
