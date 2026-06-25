namespace BuildingBlocks.Abstractions.Domain;

/// <summary>
/// Classe base para identificadores fortemente tipados.
/// </summary>
/// <typeparam name="TId">Tipo primitivo usado como valor do identificador.</typeparam>
public abstract record Identity<TId>
{
    /// <summary>
    /// Valor interno do identificador.
    /// </summary>
    public TId Value { get; init; } = default!;

    public static implicit operator TId(Identity<TId> identityId)
    {
        return identityId.Value;
    }

    public override string ToString()
    {
        return IdAsString();
    }

    public string IdAsString()
    {
        return $"{GetType().Name}";
    }
}

/// <summary>
/// Classe base para identificadores que usam long como valor padrão.
/// </summary>
public abstract record Identity : Identity<long>;
