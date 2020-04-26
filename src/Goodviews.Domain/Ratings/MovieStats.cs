using System;

namespace Goodviews.Domain
{
    public class MovieStats
    {
        public Guid MovieId { get; set; }
        public decimal RottenTomatoesCriticsScore { get; set; }
        public int RottenTomatoesCriticsCount { get; set; }
        public decimal RottenTomatoesAudienceScore { get; set; }
        public int RottenTomatoesAudienceCount { get; set; }
        public decimal StarsOutOfFive { get; set; }
        public long NumRatings { get; set; }
    }
}
