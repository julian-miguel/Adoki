namespace Adoki.logic.Domain.ValueObjects;

public record MaintenanceInterval(string Type, uint Interval)
{
    public override string ToString() => $"{Type} | {Interval}";
}