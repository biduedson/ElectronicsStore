using Microsoft.AspNetCore.Http;

namespace BuildingBlocks.Core.Exception;

/// <summary>
/// Representa uma exceção para acessos proibidos.
/// </summary>
public class ForbiddenException : IdentityException
{
    /// <summary>
    /// Inicializa uma nova instância de <see cref="ForbiddenException"/>.
    /// </summary>
    public ForbiddenException(string message, System.Exception? innerException = null)
        : base(message, statusCode: StatusCodes.Status403Forbidden, innerException) { }
}
