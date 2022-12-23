using CineSharp.Domain.Core.Entities;

namespace CineSharp.Domain.Entities;

public class Sessao : Entity
{
    public Sessao(DateTime data, int lugares, decimal valorIngreco, Filme filme)
    {
        Data = data;
        Lugares = lugares;
        ValorIngreco = valorIngreco;
        Filme = filme;
    }

    public DateTime Data { get; private set; }
    public int Lugares { get; private set; }
    public decimal ValorIngreco { get; private set; }
    public Filme Filme { get; private set; }
}
