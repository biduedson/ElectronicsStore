using BuildingBlocks.Abstractions.Events;

namespace BuildingBlocks.Abstractions.Domain;

/// <summary>
/// Define o contrato base para agregados que controlam eventos de domínio e regras de negócio.
/// </summary>
public interface IAggregateBase
{
    /// <summary>
    /// Adiciona um evento de domínio à lista de eventos ainda não confirmados.
    /// </summary>
    /// <param name="domainEvent">Evento de domínio que será adicionado ao agregado.</param>
    void AddDomainEvents(IDomainEvent domainEvent);

    /// <summary>
    /// Indica se o agregado possui eventos de domínio ainda não confirmados no armazenamento.
    /// </summary>
    /// <returns>Verdadeiro quando existem eventos pendentes; caso contrário, falso.</returns>
    public bool HasUncommittedDomainEvents();

    /// <summary>
    /// Obtém os eventos não confirmados deste agregado e os marca como confirmados.
    /// </summary>
    /// <returns>Lista somente leitura com os eventos de domínio pendentes.</returns>
    IReadOnlyList<IDomainEvent> DequeueUncommittedDomainEvents();

    /// <summary>
    /// Obtém a lista de eventos não confirmados deste agregado.
    /// </summary>
    /// <returns>Lista somente leitura com os eventos de domínio pendentes.</returns>
    IReadOnlyList<IDomainEvent> GetUncommittedDomainEvents();

    /// <summary>
    /// Remove todos os eventos de domínio do agregado.
    /// </summary>
    void ClearDomainEvents();

    /// <summary>
    /// Verifica uma regra de negócio do agregado e lança uma exceção quando ela não é satisfeita.
    /// </summary>
    /// <param name="rule">Regra de negócio que será validada.</param>
    void CheckRule(IBusinessRule rule);
}
