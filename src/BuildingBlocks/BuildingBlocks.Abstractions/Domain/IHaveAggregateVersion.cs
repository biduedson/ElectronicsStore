namespace BuildingBlocks.Abstractions.Domain;

/// <summary>
/// Indica que a entidade possui versão de agregado.
/// </summary>
public interface IHaveAggregateVersion
{
    /// <summary>
    /// Versão original do agregado.
    /// </summary>
    long OriginalVersion { get; }

}