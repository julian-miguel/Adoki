namespace Adoki.logic.Domain.ValueObjects;

public readonly record struct Registration(string Number = "")
{
    public string Number
    {
        get; init => field = value.ToUpper().Replace(" ", "") ??
        throw new ArgumentNullException(nameof(value));
    } = Number;

    public override string ToString()
    {
        return Number;
    }
}