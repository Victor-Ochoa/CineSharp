using CineSharp.Domain.Core.Entities;

namespace CineSharp.Domain.Entities;

public class Filme : Entity
{
    public Filme(string titulo, string sinopse, int duracao)
    {
        Titulo = titulo;
        Sinopse = sinopse;
        Duracao = duracao;
    }

    public string Titulo { get; private set; }
    public string Sinopse { get; private set; }
    public int Duracao { get; private set; }
}
