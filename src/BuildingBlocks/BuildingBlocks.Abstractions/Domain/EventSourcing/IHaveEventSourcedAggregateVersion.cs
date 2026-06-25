namespace BuildingBlocks.Abstractions.Domain.EventSourcing;

/// <summary>
/// Interface que indica que o agregado possui controle de versão baseado em eventos.
/// </summary>
public interface IHaveEventSourcedAggregateVersion : IHaveAggregateVersion
{
    /// <summary>
    /// Versão atual do agregado.
    /// </summary>
    long Version { get; set; }
}