using System;
using System.Collections.Generic;

namespace Goodviews.Domain
{
    public class UserList
    {
        public Guid ListId { get; set; }
        public UserListStatus Status { get; set; }
        public Guid CreatorUserId { get; set; }
        public string ListName { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public string DateCreatedTimeZone { get; set; }
        public DateTime LastModifiedUtc { get; set; }
        public ListVisibility ListVisibility { get; set; }
        public List<UserListItem> Movies { get; set; }
    }
}
