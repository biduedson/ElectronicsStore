using Microsoft.AspNetCore.Http;

namespace BuildingBlocks.Core.Exception;

/// <summary>
/// Representa uma exceção genérica da API com código de status HTTP associado.
/// </summary>
public class ApiException : CustomException
{
    /// <summary>
    /// Inicializa uma nova instância de <see cref="ApiException"/>.
    /// </summary>
    public ApiException(string message, int statusCode = StatusCodes.Status500InternalServerError)
        : base(message)
    {
        StatusCode = statusCode;
    }
}
