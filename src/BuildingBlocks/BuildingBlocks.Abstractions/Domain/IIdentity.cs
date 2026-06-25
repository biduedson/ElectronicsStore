namespace BuildingBlocks.Abstractions.Domain;

/// <summary>
/// Define o contrato base para uma identidade fortemente tipada.
/// </summary>
/// <typeparam name="TId">Tipo primitivo usado como valor da identidade.</typeparam>
public interface IIdentity<out TId>
{
    /// <summary>
    /// Valor interno da identidade.
    /// </summary>
    public TId Value { get; }
}
