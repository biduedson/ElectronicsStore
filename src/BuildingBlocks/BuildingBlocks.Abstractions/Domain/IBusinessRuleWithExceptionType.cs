namespace BuildingBlocks.Abstractions.Domain;

/// <summary>
/// Define uma regra de negócio que pode ser validada por um agregado e lança uma exceção quando violada.
/// </summary>
/// <typeparam name="TException">Tipo da exceção lançada quando a regra é violada.</typeparam>
public interface IBusinessRuleWithExceptionType<TException>
    where TException : Exception
{
    /// <summary>
    /// Exceção lançada quando a regra de negócio é violada.
    /// </summary>
    TException Exception { get; }

    /// <summary>
    /// Indica se a regra de negócio foi violada.
    /// </summary>
    /// <returns>Verdadeiro quando a regra foi violada; caso contrário, falso.</returns>
    bool IsBroken();

}