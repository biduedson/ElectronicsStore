namespace BuildingBlocks.Abstractions.Domain;

/// <summary>
/// Define uma regra de negócio que pode ser validada por um agregado.
/// </summary>
public interface IBusinessRule
{
    /// <summary>
    /// Mensagem exibida quando a regra de negócio é violada.
    /// </summary>
    string Message { get; }

    /// <summary>
    /// Código de status associado à violação da regra.
    /// </summary>
    int StatusCode { get; }

    /// <summary>
    /// Indica se a regra de negócio foi violada.
    /// </summary>
    /// <returns>Verdadeiro quando a regra foi violada; caso contrário, falso.</returns>
    bool IsBroken();
}