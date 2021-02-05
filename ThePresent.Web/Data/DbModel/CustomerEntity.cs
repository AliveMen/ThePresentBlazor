using System;
using System.Collections.ObjectModel;
using Microsoft.AspNetCore.Identity;
using ThePresent.Web.Core.Common;

namespace ThePresent.Web.Data.DbModel
{
    public class CustomerEntity : IdentityUser
    {
        public DateTime BirthdayDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual ObservableCollection<PresentEntity> Presents { get; set; }
            = new NullCollection<PresentEntity>();
        public virtual ObservableCollection<FriendEntity> Friends { get; set; }
            = new NullCollection<FriendEntity>();

    }
}