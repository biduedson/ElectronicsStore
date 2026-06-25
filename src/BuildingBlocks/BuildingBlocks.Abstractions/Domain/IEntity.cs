namespace BuildingBlocks.Abstractions.Domain;

/// <summary>
/// Define uma entidade de domínio com identidade e informações de criação.
/// </summary>
/// <typeparam name="TId">Tipo do identificador da entidade.</typeparam>
public interface IEntity<out TId> : IHaveIdentity<TId>, IHaveCreator;

/// <summary>
/// Define uma entidade de domínio com uma identidade fortemente tipada.
/// </summary>
/// <typeparam name="TIdentity">Tipo da identidade da entidade.</typeparam>
/// <typeparam name="TId">Tipo primitivo armazenado pela identidade.</typeparam>
public interface IEntity<out TIdentity, in TId> : IEntity<TIdentity>
    where TIdentity : Identity<TId>;

/// <summary>
/// Define uma entidade de domínio com o identificador padrão.
/// </summary>
public interface IEntity : IEntity<EntityId>;
