using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using BuildingBlocks.Core.Exception;

namespace BuildingBlocks.Core.Extensions;

/// <summary>
/// Fornece métodos de extensão para validações comuns de argumentos e valores.
/// </summary>
public static class ValidationExtensions
{
    private static readonly HashSet<string> AllowedCurrency = ["USD", "EUR", "BRL"];

    /// <summary>
    /// Garante que o argumento informado não seja nulo.
    /// </summary>
    public static T NotBeNull<T>(
        [NotNull] this T? argument,
        [CallerArgumentExpression("argument")] string? argumentName = null
    )
    {
        if (argument == null)
        {
            throw new ValidationException(message: $"{argumentName} não pode ser nulo ou vazio.");
        }

        return argument;
    }

    /// <summary>
    /// Garante que o argumento informado não seja nulo e lança a exceção especificada quando inválido.
    /// </summary>
    public static T NotBeNull<T>([NotNull] this T? argument, System.Exception exception)
    {
        if (argument == null)
        {
            throw exception;
        }

        return argument;
    }

    /// <summary>
    /// Garante que a string informada não esteja vazia.
    /// </summary>
    public static string NotBeEmpty(
        this string argument,
        [CallerArgumentExpression("argument")] string? argumentName = null
    )
    {
        if (argument.Length == 0)
        {
            throw new ValidationException($"{argumentName} não pode ser nulo ou vazio.");
        }

        return argument;
    }

    /// <summary>
    /// Garante que a string informada não seja nula nem vazia.
    /// </summary>
    public static string NotBeEmptyOrNull(
        [NotNull] this string? argument,
        [CallerArgumentExpression("argument")] string? argumentName = null
    )
    {
        if (string.IsNullOrEmpty(argument))
        {
            throw new ValidationException($"{argumentName} não pode ser nulo ou vazio.");
        }

        return argument;
    }

    /// <summary>
    /// Garante que a string informada não seja nula, vazia ou composta apenas por espaços em branco.
    /// </summary>
    public static string NotBeNullOrWhiteSpace(
        [NotNull] this string? argument,
        [CallerArgumentExpression("argument")] string? argumentName = null
    )
    {
        if (string.IsNullOrWhiteSpace(argument))
        {
            throw new ValidationException($"{argumentName} não pode ser nulo ou conter apenas espaços em branco.");
        }

        return argument;
    }

    /// <summary>
    /// Garante que o identificador informado não esteja vazio.
    /// </summary>
    public static Guid NotBeEmpty(
        this Guid argument,
        [CallerArgumentExpression("argument")] string? argumentName = null
    )
    {
        if (argument == Guid.Empty)
        {
            throw new ValidationException($"{argumentName} não pode ser vazio.");
        }

        return argument;
    }

    /// <summary>
    /// Garante que o identificador nullable informado não seja nulo nem vazio.
    /// </summary>
    public static Guid NotBeEmpty(
        [NotNull] this Guid? argument,
        [CallerArgumentExpression("argument")] string? argumentName = null
    )
    {
        if (argument is null)
        {
            throw new ValidationException(message: $"{argumentName} não pode ser nulo ou vazio.");
        }

        return argument.Value.NotBeEmpty(argumentName);
    }

    /// <summary>
    /// Garante que o número inteiro informado seja maior que zero.
    /// </summary>
    public static int NotBeNegativeOrZero(
        this int argument,
        [CallerArgumentExpression("argument")] string? argumentName = null
    )
    {
        if (argument <= 0)
        {
            throw new ValidationException($"{argumentName} não pode ser negativo ou zero.");
        }

        return argument;
    }

    /// <summary>
    /// Garante que o número longo nullable informado não seja nulo e seja maior que zero.
    /// </summary>
    public static long NotBeNegativeOrZero(
        [NotNull] this long? argument,
        [CallerArgumentExpression("argument")] string? argumentName = null
    )
    {
        if (argument is null)
        {
            throw new ValidationException(message: $"{argumentName} não pode ser nulo ou vazio.");
        }

        return argument.Value.NotBeNegativeOrZero(argumentName);
    }

    /// <summary>
    /// Garante que o número longo informado seja maior que zero.
    /// </summary>
    public static long NotBeNegativeOrZero(
        this long argument,
        [CallerArgumentExpression("argument")] string? argumentName = null
    )
    {
        if (argument <= 0)
        {
            throw new ValidationException($"{argumentName} não pode ser negativo ou zero.");
        }

        return argument;
    }

    /// <summary>
    /// Garante que o número inteiro nullable informado não seja nulo e seja maior que zero.
    /// </summary>
    public static int NotBeNegativeOrZero(
        [NotNull] this int? argument,
        [CallerArgumentExpression("argument")] string? argumentName = null
    )
    {
        if (argument is null)
        {
            throw new ValidationException(message: $"{argumentName} não pode ser nulo ou vazio.");
        }

        return argument.Value.NotBeNegativeOrZero(argumentName);
    }

    /// <summary>
    /// Garante que o número decimal informado seja maior que zero.
    /// </summary>
    public static decimal NotBeNegativeOrZero(
        this decimal argument,
        [CallerArgumentExpression("argument")] string? argumentName = null
    )
    {
        if (argument <= 0)
        {
            throw new ValidationException($"{argumentName} não pode ser negativo ou zero.");
        }

        return argument;
    }

    /// <summary>
    /// Garante que o número decimal nullable informado não seja nulo e seja maior que zero.
    /// </summary>
    public static decimal NotBeNegativeOrZero(
        [NotNull] this decimal? argument,
        [CallerArgumentExpression("argument")] string? argumentName = null
    )
    {
        if (argument is null)
        {
            throw new ValidationException(message: $"{argumentName} não pode ser nulo ou vazio.");
        }

        return argument.Value.NotBeNegativeOrZero(argumentName);
    }

    /// <summary>
    /// Garante que o número de ponto flutuante informado seja maior que zero.
    /// </summary>
    public static double NotBeNegativeOrZero(
        this double argument,
        [CallerArgumentExpression("argument")] string? argumentName = null
    )
    {
        if (argument <= 0)
        {
            throw new ValidationException($"{argumentName} não pode ser zero.");
        }

        return argument;
    }

    /// <summary>
    /// Garante que o número de ponto flutuante nullable informado não seja nulo e seja maior que zero.
    /// </summary>
    public static double NotBeNegativeOrZero(
        [NotNull] this double? argument,
        [CallerArgumentExpression("argument")] string? argumentName = null
    )
    {
        if (argument is null)
        {
            throw new ValidationException(message: $"{argumentName} não pode ser nulo ou vazio.");
        }

        return argument.Value.NotBeNegativeOrZero(argumentName);
    }

    /// <summary>
    /// Garante que o e-mail informado tenha um formato válido.
    /// </summary>
    public static string NotBeInvalidEmail(
        this string email,
        [CallerArgumentExpression("email")] string? argumentName = null
    )
    {
        // Usa Regex para validar o formato do e-mail.
        var regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        if (!regex.IsMatch(email))
        {
            throw new ValidationException($"{argumentName} não é um endereço de e-mail válido.");
        }

        return email;
    }

    /// <summary>
    /// Garante que o telefone informado tenha um formato válido.
    /// </summary>
    public static string NotBeInvalidPhoneNumber(
        this string phoneNumber,
        [CallerArgumentExpression("phoneNumber")] string? argumentName = null
    )
    {
        // Usa Regex para validar o formato do telefone.
        // Telefones válidos: +10----------, (+10)----------.
        var regex = new Regex(@"^[+]?[(]?[+]?[0-9]{1,4}[)]?[-\s./0-9]{9,12}$");

        if (!regex.IsMatch(phoneNumber))
        {
            throw new ValidationException($"{argumentName} não é um número de telefone válido.");
        }

        return phoneNumber;
    }

    /// <summary>
    /// Garante que o celular informado tenha um formato válido.
    /// </summary>
    public static string NotBeInvalidMobileNumber(
        this string mobileNumber,
        [CallerArgumentExpression("mobileNumber")] string? argumentName = null
    )
    {
        // Usa Regex para validar o formato do celular.
        var regex = new Regex(@"^(?:\+|00)?(\(\d{1,3}\)|\d{1,3})?([1-9]\d{9})$");

        if (!regex.IsMatch(mobileNumber))
        {
            throw new ValidationException($"{argumentName} não é um número de celular válido.");
        }

        return mobileNumber;
    }

    /// <summary>
    /// Garante que a moeda informada esteja entre as moedas permitidas.
    /// </summary>
    public static string NotBeInvalidCurrency(
        this string currency,
        [CallerArgumentExpression("currency")] string? argumentName = null
    )
    {
        currency = currency.ToUpperInvariant();
        if (!AllowedCurrency.Contains(currency))
        {
            throw new ValidationException($"{argumentName} não é uma moeda válida.");
        }

        return currency;
    }

    /// <summary>
    /// Garante que o enum nullable informado não seja nulo nem vazio.
    /// </summary>
    public static TEnum NotBeEmptyOrNull<TEnum>(
        [NotNull] this TEnum? enumValue,
        [CallerArgumentExpression("enumValue")] string argumentName = ""
    )
        where TEnum : Enum
    {
        if (enumValue is null)
        {
            throw new ValidationException(message: $"{argumentName} não pode ser nulo ou vazio.");
        }

        enumValue.NotBeEmpty(argumentName);

        return enumValue;
    }

    /// <summary>
    /// Garante que o enum informado corresponda a um valor definido.
    /// </summary>
    public static TEnum NotBeEmpty<TEnum>(
        [NotNull] this TEnum enumValue,
        [CallerArgumentExpression("enumValue")] string? argumentName = null
    )
        where TEnum : Enum
    {
        enumValue.NotBeNull(argumentName);

        // Retorna true se enumValue corresponder a um dos valores definidos em TEnum.
        if (!Enum.IsDefined(typeof(TEnum), enumValue))
        {
            throw new ValidationException(
                $"O valor de '{argumentName}' não é válido para o enum '{typeof(TEnum).Name}'."
            );
        }

        return enumValue;
    }

    /// <summary>
    /// Garante que a data informada não seja o valor padrão.
    /// </summary>
    public static void NotBeEmpty(
        this DateTime dateTime,
        [CallerArgumentExpression("dateTime")] string? argumentName = null
    )
    {
        var isEmpty = dateTime == DateTime.MinValue;
        if (isEmpty)
        {
            throw new ValidationException(
                $"O valor de '{argumentName}' não pode ser o valor padrão de '{dateTime}'."
            );
        }
    }
}
