using System;

namespace Goodviews.Domain
{
    public class ListCreatedEvent : Event
    {
        public Guid ListId { get; set; }
        public string ListName { get; set; }
        public Guid CreatorUserId { get; set; }
    }
}
