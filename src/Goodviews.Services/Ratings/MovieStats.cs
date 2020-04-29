
namespace Goodviews.Ratings
{
    public class MovieStats
    {
        public string Id => $"movie-stats/{MovieId}";
        public string MovieId { get; set; }
        public decimal RottenTomatoesCriticsScore { get; set; }
        public int RottenTomatoesCriticsCount { get; set; }
        public decimal RottenTomatoesAudienceScore { get; set; }
        public int RottenTomatoesAudienceCount { get; set; }
    }
}
