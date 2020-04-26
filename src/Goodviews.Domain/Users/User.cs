using System;
using System.Collections.Generic;

namespace Goodviews.Users
{
    public class User
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public UserStatus Status { get; set; }
        public DateTime DateCreatedUtc { get; set; }
        public DateTime LastModifiedUtc { get; set; }
        public string DefaultTimezone { get; set; }
        /// <summary>
        /// ISO-3166 alpha 2 country code
        /// </summary>
        public string CountryCode { get; set; }
        public string AvatarUrl { get; set; }
        public List<Guid> FriendIds { get; set; }

        public void Deactivate()
        {
            Status = UserStatus.Inactive;
        }
    }
}
