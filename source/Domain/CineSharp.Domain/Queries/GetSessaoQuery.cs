using CineSharp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CineSharp.Domain.Queries;

public static class GetSessaoQuery
{
    public static Expression<Func<Sessao, bool>> GetSessaoByFilme(Guid FilmeId)
    => x => x.Filme.Id== FilmeId;

    public static Expression<Func<Sessao, bool>> GetSessaoByData(DateOnly data)
        => x => DateOnly.FromDateTime(x.Data.Date) >= data;
}
