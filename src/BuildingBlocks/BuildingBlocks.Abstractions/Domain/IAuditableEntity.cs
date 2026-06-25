namespace BuildingBlocks.Abstractions.Domain;

/// <summary>
/// Define uma entidade de domínio com identidade e informações de auditoria.
/// </summary>
/// <typeparam name="TId">Tipo do identificador da entidade.</typeparam>
public interface IAuditableEntity<out TId> : IEntity<TId>, IHaveAudit;

/// <summary>
/// Define uma entidade auditável com uma identidade fortemente tipada.
/// </summary>
/// <typeparam name="TIdentity">Tipo da identidade da entidade.</typeparam>
/// <typeparam name="TId">Tipo primitivo armazenado pela identidade.</typeparam>
public interface IAuditableEntity<out TIdentity, TId> : IAuditableEntity<TIdentity>
    where TIdentity : Identity<TId>;

/// <summary>
/// Define uma entidade auditável com o identificador padrão.
/// </summary>
public interface IAuditableEntity : IAuditableEntity<Identity<long>, long>;
