using Goodviews.Services;

namespace Goodviews.Ratings
{
    public class MovieCommentedEvent : Event
    {
        public string MovieId { get; set; }
        public string UserId { get; set; }
        public string CommentTextAbridged { get; set; }
    }
}
