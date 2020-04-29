using Goodviews.Services;

namespace Goodviews.Discover
{
    public interface ICarouselService
    {
        /// <summary>
        /// Retrieves the movie IDs in a carousel.
        /// </summary>
        /// <param name="carouselId">The list to show</param>
        /// <param name="pagination">The page of results to show and number of items per page</param>
        /// <returns>An ordered list of movie IDs matching the query in the dynamic list, executed in real-time</returns>
        public CuratedCarousel GetCarousel(string carouselId, Pagination pagination);
    }
}
