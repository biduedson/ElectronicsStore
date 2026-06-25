using Microsoft.AspNetCore.Http;

namespace BuildingBlocks.Core.Exception;

/// <summary>
/// Representa uma exceção relacionada à identidade ou autenticação.
/// </summary>
public class IdentityException(
    string message,
    int statusCode = StatusCodes.Status400BadRequest,
    System.Exception? innerException = null,
    params string[] errors
) : CustomException(message, statusCode, innerException, errors);
