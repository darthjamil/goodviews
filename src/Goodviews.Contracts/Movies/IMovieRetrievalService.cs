using System;
using System.Collections.Generic;

namespace Goodviews.Movies
{
    public interface IMovieRetrievalService
    {
        /// <summary>
        /// Returns a list of movies matching the list of movie IDs provided.
        /// If a movie was not found, an error is thrown.
        /// </summary>
        /// <param name="movieIds">A list of movie IDs to retrieve</param>
        /// <returns>A list of movies in the order of the IDs provided</returns>
        public List<Movie> GetMovies(List<Guid> movieIds);
    }
}
