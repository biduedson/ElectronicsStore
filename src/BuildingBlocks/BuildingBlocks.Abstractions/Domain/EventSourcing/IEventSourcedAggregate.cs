using BuildingBlocks.Abstractions.Persistence.EvenStore;

namespace BuildingBlocks.Abstractions.Domain.EventSourcing;

/// <summary>
/// Define um agregado de domínio que tem seu estado reconstruído por event sourcing.
/// </summary>
/// <typeparam name="TId">Tipo do identificador do agregado.</typeparam>
public interface IEventSourcedAggregate<out TId> : IEntity<TId>, IHaveEventSourcingAggregate;

/// <summary>
/// Define um agregado event sourced com uma identidade fortemente tipada.
/// </summary>
/// <typeparam name="TIdentity">Tipo da identidade do agregado.</typeparam>
/// <typeparam name="TId">Tipo primitivo armazenado pela identidade.</typeparam>
public interface IEventSourcedAggregate<out TIdentity, TId> : IEventSourcedAggregate<TIdentity>
where TIdentity : Identity<TId>;

/// <summary>
/// Define um agregado event sourced com o identificador padrão.
/// </summary>
public interface IEventSourcedAggregate : IEventSourcedAggregate<AggregateId, long>;
