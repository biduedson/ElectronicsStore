using Microsoft.AspNetCore.Http;

namespace BuildingBlocks.Core.Exception;

/// <summary>
/// Representa uma exceção para conflitos de requisição.
/// </summary>
public class ConflictException(string message, System.Exception? innerException = null)
    : CustomException(message, StatusCodes.Status409Conflict, innerException);

/// <summary>
/// Representa uma exceção de aplicação para conflitos de requisição.
/// </summary>
public class ConflictAppException(string message, System.Exception? innerException = null)
    : AppException(message, StatusCodes.Status409Conflict, innerException);

/// <summary>
/// Representa uma exceção de domínio para conflitos de regra de negócio.
/// </summary>
public class ConflictDomainException : DomainException
{
    /// <summary>
    /// Inicializa uma nova instância de <see cref="ConflictDomainException"/>.
    /// </summary>
    public ConflictDomainException(string message)
        : base(message, StatusCodes.Status409Conflict) { }

    /// <summary>
    /// Inicializa uma nova instância de <see cref="ConflictDomainException"/> com o tipo da regra de negócio violada.
    /// </summary>
    public ConflictDomainException(Type businessRuleType, string message)
        : base(businessRuleType, message, StatusCodes.Status409Conflict) { }
}
