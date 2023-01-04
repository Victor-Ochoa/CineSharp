using CineSharp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineSharp.Domain.Contracts.Services;

public interface ISessaoService
{
    IEnumerable<Sessao> GetSessoes(Guid filmeId = default, DateOnly data = default);
}
