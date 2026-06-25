namespace BuildingBlocks.Abstractions.Events;


/// <summary>
/// Define o contrato base para eventos de domínio.
/// </summary>
public interface IDomainEvent : IEvent
{
    /// <summary>
    /// Obtém o identificador do agregado que gerou o evento.
    /// </summary>
    dynamic AggregateId { get; }

    /// <summary>
    /// Obtém o número de sequência do agregado no momento em que o evento foi gerado.
    /// </summary>
    long AggregateSequenceNumber { get; }

    /// <summary>
    /// Associa o evento ao agregado e à versão informada.
    /// </summary>
    /// <param name="aggregateId">Identificador do agregado que gerou o evento.</param>
    /// <param name="version">Versão ou sequência do agregado.</param>
    /// <returns>Evento de domínio associado ao agregado.</returns>
    public IDomainEvent WithAggregate(dynamic aggregateId, long version);
}
