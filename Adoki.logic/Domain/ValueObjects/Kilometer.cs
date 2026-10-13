namespace Adoki.logic.Domain.ValueObjects;

public class Kilometer
{
    public uint Value { get; init; }
    public static readonly uint MAX_ODOMETER = 99999;

    public Kilometer() => Value = 0;
    public Kilometer(uint Value) => this.Value = Value % MAX_ODOMETER;

    // Operadores Aritméticos
    public static Kilometer operator +(Kilometer a, Kilometer b)
    {
        uint result = a.Value + b.Value;
        if (result >= MAX_ODOMETER)
            result -= MAX_ODOMETER;
        return new(result);
    }

    public static Kilometer operator -(Kilometer a, Kilometer b)
    {
        if (a < b)
            return new(a.Value + MAX_ODOMETER - b.Value);
        return new(a.Value - b.Value);
    }

    // Operadores Comparativos
    public static bool operator <(Kilometer a, Kilometer b) => a.Value < b.Value;
    public static bool operator >(Kilometer a, Kilometer b) => a.Value > b.Value;
    public static bool operator <=(Kilometer a, Kilometer b) => a.Value <= b.Value;
    public static bool operator >=(Kilometer a, Kilometer b) => a.Value >= b.Value;

    public override string ToString() => $"{Value:D5} km";

    //public string ToString(bool _) => $"{Value} km";
}