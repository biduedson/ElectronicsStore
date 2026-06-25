using Microsoft.AspNetCore.Http;

namespace BuildingBlocks.Core.Exception;

/// <summary>
/// Representa uma exceção gerada a partir de uma resposta HTTP com erro.
/// </summary>
public class HttpResponseException : CustomException
{
    /// <summary>
    /// Obtém o conteúdo retornado pela resposta HTTP.
    /// </summary>
    public string? ResponseContent { get; }

    /// <summary>
    /// Obtém os cabeçalhos retornados pela resposta HTTP.
    /// </summary>
    public IReadOnlyDictionary<string, IEnumerable<string>>? Headers { get; }

    /// <summary>
    /// Inicializa uma nova instância de <see cref="HttpResponseException"/>.
    /// </summary>
    public HttpResponseException(
        string responseContent,
        int statusCode = StatusCodes.Status500InternalServerError,
        IReadOnlyDictionary<string, IEnumerable<string>>? headers = null,
        System.Exception? inner = null
    )
        : base(responseContent, statusCode, inner)
    {
        StatusCode = statusCode;
        ResponseContent = responseContent;
        Headers = headers;
    }

    /// <summary>
    /// Retorna uma representação textual da resposta HTTP com erro.
    /// </summary>
    public override string ToString()
    {
        return $"HTTP Response: \n\n{ResponseContent}\n\n{base.ToString()}";
    }
}
