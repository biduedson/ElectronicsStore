using Microsoft.AspNetCore.Http;

namespace BuildingBlocks.Core.Exception;

/// <summary>
/// Classe base para exceções customizadas com mensagens de erro e código de status HTTP.
/// </summary>
public class CustomException : System.Exception
{
    /// <summary>
    /// Inicializa uma nova instância de <see cref="CustomException"/>.
    /// </summary>
    protected CustomException(
        string message,
        int statusCode = StatusCodes.Status500InternalServerError,
        System.Exception? innerException = null,
        params string[] errors
    )
        : base(message, innerException)
    {
        ErrorMessages = errors;
        StatusCode = statusCode;
    }

    /// <summary>
    /// Obtém as mensagens de erro relacionadas à exceção.
    /// </summary>
    public IEnumerable<string> ErrorMessages { get; protected set; }

    /// <summary>
    /// Obtém o código de status HTTP associado à exceção.
    /// </summary>
    public int StatusCode { get; protected set; }

    /// <summary>
    /// Retorna o título usado no campo title do Problem Details.
    /// </summary>
    public override string ToString()
    {
        return GetType().FullName ?? GetType().Name;
    }
}
