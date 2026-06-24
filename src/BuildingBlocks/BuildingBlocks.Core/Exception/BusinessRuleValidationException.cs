using BuildingBlocks.Abstractions.Domain;

namespace BuildingBlocks.Core.Exception;

/// <summary>
/// Representa uma exceção gerada quando uma regra de negócio é violada.
/// </summary>
public class BusinessRuleValidationException : DomainException
{
    /// <summary>
    /// Obtém a regra de negócio violada.
    /// </summary>
    public IBusinessRule BrokenRule { get; }

    /// <summary>
    /// Obtém os detalhes da violação da regra de negócio.
    /// </summary>
    public string Details { get; }

    /// <summary>
    /// Inicializa uma nova instância de <see cref="BusinessRuleValidationException"/>.
    /// </summary>
    public BusinessRuleValidationException(IBusinessRule brokenRule)
        : base(brokenRule.Message)
    {
        BrokenRule = brokenRule;
        Details = brokenRule.Message;
    }

    /// <summary>
    /// Retorna uma representação textual da regra de negócio violada.
    /// </summary>
    public override string ToString()
    {
        return $"{BrokenRule.GetType().FullName}: {BrokenRule.Message}";
    }
}
