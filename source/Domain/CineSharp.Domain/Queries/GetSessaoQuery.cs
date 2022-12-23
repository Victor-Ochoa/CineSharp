using CineSharp.Domain.Entities;
using System.Linq.Expressions;

namespace CineSharp.Domain.Queries;

public static class GetSessaoQuery
{
    public static Expression<Func<Sessao, bool>> GetSessaoByFilme(Guid FilmeId)
    => x => x.Filme.Id== FilmeId;

    public static Expression<Func<Sessao, bool>> GetSessaoByData(DateOnly data)
        => x => DateOnly.FromDateTime(x.Data.Date) >= data;
}
