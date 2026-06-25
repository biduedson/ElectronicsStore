using Microsoft.AspNetCore.Http;

namespace BuildingBlocks.Core.Exception;

/// <summary>
/// Representa uma exceção de domínio.
/// </summary>
public class DomainException : CustomException
{
    private readonly Type? _brokenRuleType;

    /// <summary>
    /// Inicializa uma nova instância de <see cref="DomainException"/>.
    /// </summary>
    public DomainException(string message, int statusCode = StatusCodes.Status400BadRequest)
        : base(message, statusCode) { }

    /// <summary>
    /// Inicializa uma nova instância de <see cref="DomainException"/> com o tipo da regra de negócio violada.
    /// </summary>
    public DomainException(Type businessRuleType, string message, int statusCode = StatusCodes.Status400BadRequest)
        : base(message, statusCode)
    {
        _brokenRuleType = businessRuleType;
    }

    /// <summary>
    /// Retorna o título usado no campo title do Problem Details.
    /// </summary>
    public override string ToString()
    {
        if (_brokenRuleType is not null)
        {
            return $"{GetType().FullName}:{_brokenRuleType.FullName}";
        }

        return $"{GetType().FullName}";
    }
}
