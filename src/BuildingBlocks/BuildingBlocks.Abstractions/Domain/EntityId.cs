namespace BuildingBlocks.Abstractions.Domain;

/// <summary>
/// Representa o identificador fortemente tipado de uma entidade.
/// </summary>
/// <typeparam name="T">Tipo primitivo usado como valor do identificador.</typeparam>
public record EntityId<T> : Identity<T>
{
    // Construtor protegido usado pelo EF.
    protected EntityId(T value)
    {
        Value = value;
    }

    public static implicit operator T(EntityId<T> id)
    {
        ArgumentNullException.ThrowIfNull(id.Value);
        return id.Value;
    }

    public static EntityId<T> Of(T id)
    {
        return new EntityId<T>(id);
    }
}

/// <summary>
/// Representa o identificador padrão de entidade usando long como valor.
/// </summary>
public record EntityId : EntityId<long>
{
    protected EntityId(long value)
        : base(value) { }

    public static implicit operator long(EntityId id)
    {
        return id.Value;
    }

    public static new EntityId Of(long id)
    {
        return new EntityId(id);
    }
}
