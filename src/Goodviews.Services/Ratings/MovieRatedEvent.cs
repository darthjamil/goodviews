using Goodviews.Services;

namespace Goodviews.Ratings
{
    public class MovieRatedEvent : Event
    {
        public string Id => $"movie-rating/{MovieId}/{UserId}";
        public string MovieId { get; set; }
        public string UserId { get; set; }
        public int StarsOutOfFive { get; set; }
    }
}
