using System;

namespace Goodviews.Ratings
{
    public class Comment
    {
        public Guid MovieId { get; set; }
        public Guid UserId { get; set; }
        public DateTime DateCreatedUtc { get; set; }
        public DateTime LastModifiedUtc { get; set; }
        public string CommentText { get; set; }
    }
}
