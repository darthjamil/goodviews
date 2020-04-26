using System;
using System.Collections.Generic;

namespace Goodviews.Users
{
    public class BrowseHistory
    {
        public Guid UserId { get; set; }
        public List<Guid> MovieIds { get; set; }
    }
}
