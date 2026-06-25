namespace BuildingBlocks.Abstractions.Domain;

/// <summary>
/// Representa o identificador fortemente tipado de um agregado.
/// </summary>
/// <typeparam name="T">Tipo primitivo usado como valor do identificador.</typeparam>
public record AggregateId<T> : Identity<T>
{
    // Construtor protegido usado pelo EF.
    protected AggregateId(T value)
    {
        Value = value;
    }


    // Validações devem ficar nos métodos de criação, não no construtor.
    public static implicit operator T(AggregateId<T> id)
    {
        return id.Value;
    }

}

/// <summary>
/// Representa o identificador padrão de agregado usando long como valor.
/// </summary>
public record AggregateId : AggregateId<long>
{
    // Construtor protegido usado pelo EF.
    protected AggregateId(long value)
        : base(value) { }

    // Validações devem ficar nos métodos de criação, não no construtor.
    public new static AggregateId CreateAggregateId(long value)
    {
        return new AggregateId(value);
    }

    public static implicit operator long(AggregateId? id) => id?.Value ?? default;
}
