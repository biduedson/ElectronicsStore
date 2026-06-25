using Microsoft.AspNetCore.Http;

namespace BuildingBlocks.Core.Exception;

/// <summary>
/// Representa uma exceção para recursos não encontrados.
/// </summary>
public class NotFoundException(string message, System.Exception? innerException = null)
    : CustomException(message, StatusCodes.Status404NotFound, innerException);

/// <summary>
/// Representa uma exceção de aplicação para recursos não encontrados.
/// </summary>
public class NotFoundAppException(string message, System.Exception? innerException = null)
    : AppException(message, StatusCodes.Status404NotFound, innerException);

/// <summary>
/// Representa uma exceção de domínio para recursos ou regras não encontrados.
/// </summary>
public class NotFoundDomainException : DomainException
{
    /// <summary>
    /// Inicializa uma nova instância de <see cref="NotFoundDomainException"/>.
    /// </summary>
    public NotFoundDomainException(string message)
        : base(message, StatusCodes.Status404NotFound) { }

    /// <summary>
    /// Inicializa uma nova instância de <see cref="NotFoundDomainException"/> com o tipo da regra de negócio violada.
    /// </summary>
    public NotFoundDomainException(Type businessRuleType, string message)
        : base(businessRuleType, message, StatusCodes.Status404NotFound) { }
}
