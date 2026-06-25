using BuildingBlocks.Abstractions.Domain;
using BuildingBlocks.Abstractions.Domain.EventSourcing;
using BuildingBlocks.Abstractions.Events;

namespace BuildingBlocks.Abstractions.Persistence.EvenStore;

/// <summary>
/// Interface que define um agregado que utiliza o modelo de versionamento de eventos (Event Sourcing).
/// </summary>
/// <remarks>
/// Este tipo de agregado mantém seu estado ao longo do tempo através de uma sequência de eventos.
/// Ele implementa interfaces para projeção de estado, controle de versão e operações básicas de agregado.
/// </remarks>
public interface IHaveEventSourcingAggregate
    : IHaveAggregateStateProjection,
      IAggregateBase,
      IHaveEventSourcedAggregateVersion
{
    /// <summary>
    /// Reconstrói o estado do agregado a partir de um histórico de eventos.
    /// </summary>
    /// <param name="history">Sequência ordenada de eventos que compõem o histórico do agregado.</param>
    void LoadFromHistory(IEnumerable<IDomainEvent> history);
}