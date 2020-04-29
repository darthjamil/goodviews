using Goodviews.Services;

namespace Goodviews.Ratings
{
    public interface IRatingsService
    {
        /// <summary>
        /// Adds a user rating for a movie.
        /// </summary>
        /// <param name="userId">The user doing the rating</param>
        /// <param name="movieId">The ID of th movie being rated</param>
        /// <param name="ratingOutOfFive">The number of stars out of five. Can be Zero.</param>
        public void RateMovie(string userId, string movieId, int ratingOutOfFive);

        /// <summary>
        /// Adds a user comment to a movie.
        /// </summary>
        /// <param name="userId">The ID of the user making the comment</param>
        /// <param name="movieId">The ID of the movie being commented on</param>
        /// <param name="commentText">The comment text</param>
        public void AddMovieComment(string userId, string movieId, string commentText);

        /// <summary>
        /// Gets the ratings and other stats of a movie.
        /// </summary>
        /// <param name="movieId">The ID of the movie whose stats we're getting</param>
        /// <returns></returns>
        public MovieStats GetMovieRatings(string movieId);

        /// <summary>
        /// Gets a paginated list of comments for a movie.
        /// </summary>
        /// <param name="movieId">The ID of the movie whose comments we're getting</param>
        /// <param name="pagination">The current page and max items per page</param>
        /// <returns>A paginated set of comments for a movie in the order they added, with latest first</returns>
        public Page<Comment> GetMovieComments(string movieId, Pagination pagination);
    }
}
