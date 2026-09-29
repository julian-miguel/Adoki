namespace Adoki.logic.Domain.ValueObjects;

public record MaintenanceInterval(long Action, string Type, uint Interval)
{
    public override string ToString() => $"{Action} : {Type} | {Interval}";
}