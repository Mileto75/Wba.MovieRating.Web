using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Wba.MovieRating.Domain.Entities
{
    public class Rating
    {
        [Key]
        public long Id { get; set; }
        [Required]
        [Range(1,5)]
        public int Score { get; set; }
        public string Review { get; set; }
        public Movie Movie { get; set; }
        public long MovieId { get; set; }
    }
}
