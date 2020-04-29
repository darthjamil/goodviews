using System.Collections.Generic;

namespace Goodviews.Users
{
    public class BrowseHistory
    {
        public string Id => $"browse-history/{UserId}/{Year}";
        public string UserId { get; set; }
        public int Year { get; set; }
        public List<string> MovieIds { get; set; }
    }
}
