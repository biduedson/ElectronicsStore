namespace BuildingBlocks.Core.Exception;

/// <summary>
/// Representa uma exceção para falhas de validação.
/// </summary>
public class ValidationException(string message, System.Exception? innerException = null, params string[] errors)
    : BadRequestException(message, innerException, errors);
