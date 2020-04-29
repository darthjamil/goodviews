using Goodviews.Services;

namespace Goodviews.Discover
{
    public class MovieAddedToListEvent : Event
    {
        public string ListId { get; set; }
        public string ListName { get; set; }
        public string MovieId { get; set; }
        public string CreatorUserId { get; set; }
    }
}
