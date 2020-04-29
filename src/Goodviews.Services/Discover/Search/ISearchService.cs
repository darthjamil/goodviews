using Goodviews.Services;

namespace Goodviews.Discover
{
    public interface ISearchService
    {
        /// <summary>
        /// Search for a movie by term.
        /// </summary>
        /// <param name="query">A token to match against the movie title or synopsis</param>
        /// <param name="sortOrder">The order in which to return the results</param>
        /// <param name="pagination">The page of results to show and number of items per page</param>
        /// <returns>An ordered list of movie IDs matching the search term</returns>
        public Page<string> Search(string query, SortOrder sortOrder, Pagination pagination);

        /// <summary>
        /// Perform an advanced search using a query term and facet filters.
        /// </summary>
        /// <param name="criteria">The filtering facets and search term</param>
        /// <param name="pagination">The page of results to show and number of items per page</param>
        /// <returns>An ordered list of movie IDs matching the search criteria</returns>
        public Page<string> Search(SearchCriteria criteria, Pagination pagination);

        /// <summary>
        /// Look for all movies in a particular genre.
        /// </summary>
        /// <param name="genre">The category/genre in which to search. This can be a sub-genre.</param>
        /// <param name="sortOrder">The order in which to return the results</param>
        /// <param name="pagination">The page of results to show and number of items per page</param>
        /// <returns>A list of movie IDs in the provided category, ordered by </returns>
        public Page<string> Browse(string genre, SortOrder sortOrder, Pagination pagination);

        /// <summary>
        /// Retrieves the items of a dyanmic list of executing the underlying query.
        /// </summary>
        /// <param name="listId">The list whose results we're getting</param>
        /// <param name="sortOrder">The order in which to return the results</param>
        /// <param name="pagination">The page of results to show and number of items per page</param>
        /// <returns>An ordered list of movie IDs matching the query in the dynamic list, executed in real-time</returns>
        public Page<string> GetDynamicCarousel(string listId, SortOrder sortOrder, Pagination pagination);
    }
}
