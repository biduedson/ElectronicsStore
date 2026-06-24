namespace BuildingBlocks.Core.Exception;

/// <summary>
/// Representa uma exceção de concorrência para agregados com versão diferente da esperada.
/// </summary>
public class ConcurrencyException<TId> : DomainException
{
    /// <summary>
    /// Inicializa uma nova instância de <see cref="ConcurrencyException{TId}"/>.
    /// </summary>
    public ConcurrencyException(TId id)
        : base($"A different version than expected was found in aggregate {id}") { }
}
