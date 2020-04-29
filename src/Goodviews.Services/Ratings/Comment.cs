using System;

namespace Goodviews.Ratings
{
    public class Comment
    {
        public string Id { get; set; }
        public string MovieId { get; set; }
        public string UserId { get; set; }
        public DateTime DateCreatedUtc { get; set; }
        public DateTime LastModifiedUtc { get; set; }
        public string CommentText { get; set; }
    }
}
