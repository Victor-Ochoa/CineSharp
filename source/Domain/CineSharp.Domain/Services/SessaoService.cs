using CineSharp.Domain.Contracts.Repositories;
using CineSharp.Domain.Entities;
using CineSharp.Domain.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineSharp.Domain.Services
{
    public class SessaoService : Contracts.Services.ISessaoService
    {
        private readonly ISessaoRepository _sessaoRepository;

        public SessaoService(ISessaoRepository sessaoRepository)
        {
            _sessaoRepository = sessaoRepository;
        }
        public IEnumerable<Sessao> GetSessoes(Guid filmeId = default, DateOnly data = default)
        {
            var query = _sessaoRepository.SelectAsync();

            if(filmeId != default)
            {
                query = query.Where(GetSessaoQuery.GetSessaoByFilme(filmeId));
            }

            if (data != default)
            {
                query = query.Where(GetSessaoQuery.GetSessaoByData(data));
            }

            return query.ToList();
        }
    }
}
