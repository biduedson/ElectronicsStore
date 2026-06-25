using ElectronicsStore.Catalog.Brands.ValueObjects;

namespace ElectronicsStore.Catalog.Brands.Contracts;

/// <summary>
/// Define operações para verificar a existência de marcas.
/// </summary>
public interface IBrandChecker
{
    /// <summary>
    /// Verifica se a marca informada existe.
    /// </summary>
    bool BrandExists(BrandId brandId);
}
