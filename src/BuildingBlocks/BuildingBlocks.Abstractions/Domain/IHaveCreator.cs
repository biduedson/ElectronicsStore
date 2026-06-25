namespace BuildingBlocks.Abstractions.Domain;

/// <summary>
/// Define informações de auditoria sobre a criação de um objeto de domínio.
/// </summary>
public interface IHaveCreator
{
    /// <summary>
    /// Data e hora em que o objeto foi criado.
    /// </summary>
    DateTime CreatedAt { get; }

    /// <summary>
    /// Identificador do usuário ou processo que criou o objeto.
    /// </summary>
    int? CreatedBy { get; }
}
