using BuildingBlocks.Abstractions.Domain;
using BuildingBlocks.Core.Extensions;

namespace ElectronicsStore.Catalog.Brands.ValueObjects;

/// <summary>
/// Representa o identificador único de uma marca.
/// </summary>
public record BrandId : AggregateId
{
    private BrandId(long value)
        : base(value) { }

    /// <summary>
    /// Converte implicitamente o identificador da marca para seu valor numérico.
    /// </summary>
    public static implicit operator long(BrandId id) => id.Value;

    /// <summary>
    /// Cria um identificador de marca válido.
    /// </summary>
    public static BrandId Of(long id) => new(id.NotBeNegativeOrZero());
}
