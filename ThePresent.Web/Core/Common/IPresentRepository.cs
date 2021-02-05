using System;
using System.Linq;
using ThePresent.Web.Data.DbModel;

namespace ThePresent.Web.Core.Common
{
    public interface IPresentRepository : IRepository, IDisposable
    {
        public IQueryable<CustomerEntity> Customers { get; }
        public IQueryable<FriendEntity> Friends { get; }
        public IQueryable<PresentEntity> Presents { get; }

    }
}