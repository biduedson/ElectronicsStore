namespace BuildingBlocks.Abstractions.Domain;

/// <summary>
/// Define um objeto que possui uma identidade tipada.
/// </summary>
/// <typeparam name="TId">Tipo do identificador.</typeparam>
public interface IHaveIdentity<out TId> : IHaveIdentity
{
    /// <summary>
    /// Identificador tipado do objeto.
    /// </summary>
    new TId Id { get; }

    object IHaveIdentity.Id => Id;
}

/// <summary>
/// Define um objeto que possui uma identidade acessível de forma genérica.
/// </summary>
public interface IHaveIdentity
{
    /// <summary>
    /// Identificador do objeto.
    /// </summary>
    object Id { get; }
}
