namespace BuildingBlocks.Abstractions.Domain;

/// <summary>
/// Define informações de auditoria de criação e última alteração.
/// </summary>
public interface IHaveAudit : IHaveCreator
{
    /// <summary>
    /// Data e hora da última alteração do objeto.
    /// </summary>
    DateTime? LastModified { get; }

    /// <summary>
    /// Identificador do usuário ou processo que realizou a última alteração.
    /// </summary>
    int? LastModifiedBy { get; }
}
