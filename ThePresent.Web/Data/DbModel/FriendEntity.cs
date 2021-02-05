using System.ComponentModel.DataAnnotations;
using ThePresent.Web.Core.Common;

namespace ThePresent.Web.Data.DbModel
{
    public class FriendEntity : AuditableEntity
    {
        public string UserId { get; set; }
        public virtual CustomerEntity Customer { get; set; }

        public string FriendId { get; set; }
        public CustomerEntity Friend { get; set; }

    }
}