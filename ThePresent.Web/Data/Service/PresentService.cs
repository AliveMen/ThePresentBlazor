using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ThePresent.Web.Core;
using ThePresent.Web.Core.Common;
using ThePresent.Web.Data.DbModel;
using ThePresent.Web.Data.DtoModel;
using ThePresent.Web.Repository;

namespace ThePresent.Web.Data.Service
{
    public class PresentService : IPresentService
    {
        private readonly Func<IPresentRepository> _repositoryFunc;

        public PresentService(Func<IPresentRepository> repositoryFunc)
        {
            _repositoryFunc = repositoryFunc;
        }

        public Task AddService(Present present)
        {
            throw new System.NotImplementedException();
        }

        public Task RemovePresent(string id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Present>> GetByIdsAsync(string[] ids)
        {
            throw new System.NotImplementedException();
        }

        public async Task<PresentEntity[]> GetByUserIds(string[] ids)
        {
            using (var repository = _repositoryFunc())
            {
                return await repository.Presents.Where(x => ids.Contains(x.UserId)).ToArrayAsync();
                
            }
        }
    }
}