using Goodviews.Contracts;
using System;

namespace Goodviews.Feeds
{
    public interface IFeedService
    {
        /// <summary>
        /// Retrieves a user's real-time feed. This service can be polled.
        /// </summary>
        /// <param name="userId">The user whose feed we're getting</param>
        /// <param name="pagination">How many events to show. We're assuming the use case is an infinite scroll.</param>
        /// <returns>A paginated list of events for this user to see, ordered by date descending</returns>
        public UserFeed GetFeed(Guid userId, Pagination pagination);
    }
}
