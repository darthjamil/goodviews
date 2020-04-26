using Goodviews.Contracts;
using System;
using System.Collections.Generic;

namespace Goodviews.Users
{
    public interface IUserService
    {
        // TODO Google Login stuff
        // public void CreateUser(string email);

        /// <summary>
        /// Retrieves a user by email.
        /// </summary>
        /// <param name="email">The email address of the user to get</param>
        /// <returns>The user with the given email</returns>
        public User GetUser(string email);

        /// <summary>
        /// Updates a user's information.
        /// </summary>
        public void UpdateUser(Guid userId, string username, string timeZone, string country, string avatarUrl);

        /// <summary>
        /// Deactivates a user.
        /// </summary>
        /// <param name="userId">The ID of the user to deactivate.</param>
        public void Deactivate(Guid userId);

        /// <summary>
        /// Retrieves a paginated list of a user's friends.
        /// </summary>
        /// <param name="userId">The user whose friends we're getting</param>
        /// <param name="pagination">The current page and number of friends per page</param>
        /// <returns>A list of friends in alphabetical order according to their username</returns>
        public List<User> GetFriends(Guid userId, Pagination pagination);

        /// <summary>
        /// Submits a friends request on behalf of a user.
        /// </summary>
        /// <param name="userId">The user making the request</param>
        /// <param name="email">The email of the requestee</param>
        public void SubmitFriendRequest(Guid userId, string email);

        /// <summary>
        /// Get a set of users who've made a friends request.
        /// </summary>
        /// <param name="userId">The user whose friend requests we're getting</param>
        /// /// <param name="pagination">The current page and number of friend requests per page</param>
        /// <returns>A list of users making a friend request to this person, ordered by the date of the request</returns>
        public List<FriendRequest> GetFriendRequests(Guid userId, Pagination pagination);

        /// <summary>
        /// Accepts the friend request of <code>requesterId</code>.
        /// </summary>
        /// <param name="userId">The user accepting the request</param>
        /// <param name="requesterId">The user making the request</param>
        public void AcceptFriendRequest(Guid userId, Guid requesterId);

        /// <summary>
        /// Rejects the friend request of <code>requesterId</code>. The request
        /// is NOT removed from the maker's request list.
        /// </summary>
        /// <param name="userId">The user rejecting the request</param>
        /// <param name="requesterId">The user making the request</param>
        public void RejectFriendRequest(Guid userId, Guid requesterId);
    }
}
