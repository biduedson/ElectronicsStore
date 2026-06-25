using Microsoft.AspNetCore.Http;

namespace BuildingBlocks.Core.Exception;

/// <summary>
/// Representa uma exceção para requisições inválidas.
/// </summary>
public class BadRequestException(string message, System.Exception? innerException = null, params string[] errors)
    : CustomException(message, StatusCodes.Status400BadRequest, innerException, errors);
