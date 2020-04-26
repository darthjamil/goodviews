using System;

namespace Goodviews.Domain
{
    public class UserListItem
    {
        public Guid MovieId { get; set; }
        public int Order { get; set; }
        public string Annotation { get; set; }
    }
}
