
namespace Goodviews.Feeds
{
    public interface IFeedGeneratorService
    {
        /// <summary>
        /// Batch processes the set of events that have not yet been processed
        /// and turns them into feed events that can be easily consumed by
        /// clients and pontentially cached. This service is meant to be called
        /// as a batch process.
        /// </summary>
        public void GenerateFeeds();
    }
}
