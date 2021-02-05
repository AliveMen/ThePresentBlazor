using System.Collections.Generic;
using System.Threading.Tasks;
using ThePresent.Web.Data.DbModel;
using ThePresent.Web.Data.DtoModel;

namespace ThePresent.Web.Core
{
    public interface IPresentService
    {
        public Task AddService(Present present);

        public Task RemovePresent(string id);

        public Task<IEnumerable<Present>> GetByIdsAsync(string[] ids);

        public Task<PresentEntity[]> GetByUserIds(string[] ids);
    }
}