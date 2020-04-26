using System;

namespace Goodviews.Domain
{
    public class MovieCommentedEvent : Event
    {
        public Guid MovieId { get; set; }
        public Guid UserId { get; set; }
        public string CommentTextAbridged { get; set; }
    }
}
