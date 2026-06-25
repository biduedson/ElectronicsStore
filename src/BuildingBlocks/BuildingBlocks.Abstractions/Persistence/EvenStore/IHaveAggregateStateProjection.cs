namespace BuildingBlocks.Abstractions.Persistence.EvenStore;

/// <summary>
/// Define uma projeção capaz de reconstruir o estado de um agregado a partir de eventos.
/// </summary>
public interface IHaveAggregateStateProjection
{
    /// <summary>
    /// Aplica um evento ao estado atual da projeção.
    /// </summary>
    /// <param name="event">Evento que será aplicado à projeção.</param>
    void When(object @event);

    /// <summary>
    /// Incorpora um evento ao estado da projeção durante a reconstrução do agregado.
    /// </summary>
    /// <param name="event">Evento que será incorporado ao estado.</param>
    void Fold(object @event);
}
