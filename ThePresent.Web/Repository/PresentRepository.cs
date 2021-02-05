using System.Linq;
using ThePresent.Web.Core.Common;
using ThePresent.Web.Data.DbModel;

namespace ThePresent.Web.Repository
{
    public class PresentRepository : DbContextRepositoryBase<ThePresentDbContext>, IPresentRepository
    {
        public PresentRepository(ThePresentDbContext dbContext) : base(dbContext)
        {
        }

        public IQueryable<CustomerEntity> Customers => DbContext.Set<CustomerEntity>();
        public IQueryable<FriendEntity> Friends => DbContext.Set<FriendEntity>();
        public IQueryable<PresentEntity> Presents => DbContext.Set<PresentEntity>();
    }
}