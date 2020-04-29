using Goodviews.Domain;

namespace Goodviews.Discover
{
    public class ListCreatedEvent : Event
    {
        public string ListId { get; set; }
        public string ListName { get; set; }
        public string CreatorUserId { get; set; }
    }
}
