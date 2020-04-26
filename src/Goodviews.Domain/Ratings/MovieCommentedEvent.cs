using Goodviews.Domain;
using System;

namespace Goodviews.Ratings
{
    public class MovieCommentedEvent : Event
    {
        public Guid MovieId { get; set; }
        public Guid UserId { get; set; }
        public string CommentTextAbridged { get; set; }
    }
}
