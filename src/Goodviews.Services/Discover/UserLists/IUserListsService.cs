using Goodviews.Services;
using System.Collections.Generic;

namespace Goodviews.Discover
{
    public interface IUserListsService
    {
        /// <summary>
        /// Creates a new user list.
        /// </summary>
        /// <param name="createdByUserId">The ID of the user that created the list</param>
        /// <param name="name">The name of the list</param>
        /// <param name="description">The list description text</param>
        /// <param name="visibility">Whether the list can be viewed publicly, only by friends, etc</param>
        public void CreateList(string createdByUserId, string name, string description, ListVisibility visibility);

        /// <summary>
        /// Updates the list identified with ID <code>createdByUserId</code> with new metadata details.
        /// </summary>
        /// <param name="listId">The ID of the list to update</param>
        /// <param name="name">The new name of the list</param>
        /// <param name="description">The new description text</param>
        /// <param name="visibility">Whether the list can be viewed publicly, only by friends, etc</param>
        public void UpdateList(string listId, string name, string description, ListVisibility visibility);

        /// <summary>
        /// Deletes a user list.
        /// </summary>
        /// <param name="listId">The ID of the list to delete</param>
        public void DeleteList(string listId);

        /// <summary>
        /// Adds movies to the beginning of a user list in the order given. A movie will
        /// be ignored if it already exists in the list.
        /// </summary>
        /// <param name="listId">The ID of the list to ammend</param>
        /// <param name="movies">A list of (movie ID, annotation) tuples to append to the list</param>
        public void AddMovies(string listId, List<(string, string)> movies);

        /// <summary>
        /// Removes movies from a user list wherever they may occur in the list.
        /// </summary>
        /// <param name="listId">The ID of the list from which to remove movies</param>
        /// <param name="movieIds">The Ids of the movies to remove.</param>
        public void RemoveMovies(string listId, List<string> movieIds);

        /// <summary>
        /// Reorders the movies in a list based on the new order provided by 
        /// <code>moviesIds</code>. This service can be called on a Save action, or it
        /// can be called as a callback each time a user drags-n-drops a movie
        /// in any client UI.
        /// </summary>
        /// <param name="listId"></param>
        /// <param name="moviesIds"></param>
        public void ReorderMovies(string listId, List<string> moviesIds);

        /// <summary>
        /// Retrieves a user list by ID. The list contains the movie IDs, not the
        /// movies themselves.
        /// </summary>
        /// <param name="listId">The ID of the list of retrieve</param>
        /// <returns></returns>
        public UserList Get(string listId);

        /// <summary>
        /// Returns the list definitions for all lists created by a user.
        /// </summary>
        /// <param name="userId">The ID of the user who created the lists</param>
        /// <param name="pagination">The max number of user-lists to return per page</param>
        /// <returns>A paged list of all user-list definitions created by the user, ordered by date created descending</returns>
        public Page<UserList> GetListsForUser(string userId, Pagination pagination);
    }
}
