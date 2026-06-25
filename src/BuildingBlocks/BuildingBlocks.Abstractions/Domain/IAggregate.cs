namespace BuildingBlocks.Abstractions.Domain;

/// <summary>
/// Define um agregado de domínio com identidade e suporte a eventos de domínio.
/// </summary>
/// <typeparam name="TId">Tipo do identificador do agregado.</typeparam>
public interface IAggregate<out TId> : IEntity<TId>, IAggregateBase;

/// <summary>
/// Define um agregado de domínio com uma identidade fortemente tipada.
/// </summary>
/// <typeparam name="TIdentity">Tipo da identidade do agregado.</typeparam>
/// <typeparam name="TId">Tipo primitivo armazenado pela identidade.</typeparam>
public interface IAggregate<out TIdentity, TId> : IAggregate<TIdentity>
    where TIdentity : Identity<TId>;

/// <summary>
/// Define um agregado de domínio com o identificador padrão.
/// </summary>
public interface IAggregate : IAggregate<AggregateId, long>;
