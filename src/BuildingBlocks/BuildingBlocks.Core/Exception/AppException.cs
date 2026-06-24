using Microsoft.AspNetCore.Http;

namespace BuildingBlocks.Core.Exception;

/// <summary>
/// Representa uma exceção de aplicação com código de status HTTP associado.
/// </summary>
public class AppException(
    string message,
    int statusCode = StatusCodes.Status400BadRequest,
    System.Exception? innerException = null
) : CustomException(message, statusCode, innerException)
{
    /// <summary>
    /// Cria uma exceção de aplicação para respostas 400 Bad Request.
    /// </summary>
    public static AppException BadRequest(string message, System.Exception? innerException = null) =>
        new(message, StatusCodes.Status400BadRequest, innerException);

    /// <summary>
    /// Cria uma exceção de aplicação para respostas 404 Not Found.
    /// </summary>
    public static AppException NotFound(string message, System.Exception? innerException = null) =>
        new(message, StatusCodes.Status404NotFound, innerException);
}
