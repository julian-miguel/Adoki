namespace Adoki.logic.Domain.ValueObjects;

public class Kilometer(uint Value)
{
    public uint Value { get; init; } = Value % MAX_ODOMETRY;
    private static readonly uint MAX_ODOMETRY = 99999;

    // Operadores Aritméticos
    public static Kilometer operator +(Kilometer a, Kilometer b)
    {
        uint result = a.Value + b.Value;
        if (result >= MAX_ODOMETRY)
            result -= MAX_ODOMETRY;
        return new(result);
    }

    public static Kilometer operator -(Kilometer a, Kilometer b)
    {
        if (a < b)
            return new(a.Value + MAX_ODOMETRY - b.Value);
        return new(a.Value - b.Value);
    }

    // Operadores Comparativos
    public static bool operator <(Kilometer a, Kilometer b) => a.Value < b.Value;
    public static bool operator >(Kilometer a, Kilometer b) => a.Value > b.Value;
    public static bool operator <=(Kilometer a, Kilometer b) => a.Value <= b.Value;
    public static bool operator >=(Kilometer a, Kilometer b) => a.Value >= b.Value;

    public override string ToString() => $"{Value:D5} km";

    public string ToString(bool _) => $"{Value} km";
}