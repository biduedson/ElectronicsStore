

using MediatR;

namespace BuildingBlocks.Abstractions.Events;

/// <summary>
/// Define o contrato base para eventos publicados pela aplicação.
/// </summary>
public interface IEvent : INotification
{
    /// <summary>
    /// Obtém o identificador único do evento.
    /// </summary>
    Guid EventId { get; }

    /// <summary>
    /// Obtém a versão do evento ou da raiz do agregado.
    /// </summary>
    long EventVersion { get; }

    /// <summary>
    /// Obtém a data em que o <see cref="IEvent" /> ocorreu.
    /// </summary>
    DateTime OccurredOn { get; }

    /// <summary>
    /// Obtém o instante do evento com deslocamento de fuso horário.
    /// </summary>
    DateTimeOffset TimeStamp { get; }

    /// <summary>
    /// Obtém o tipo deste evento.
    /// </summary>
    public string EventType { get; }
}
