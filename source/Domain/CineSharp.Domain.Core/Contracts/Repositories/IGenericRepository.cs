using CineSharp.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineSharp.Domain.Core.Contracts.Repositories
{
    public interface IGenericRepository<T> where T : Entity
    {
        IQueryable<T> SelectAsync(CancellationToken cancellationToken = default);
    }
}
