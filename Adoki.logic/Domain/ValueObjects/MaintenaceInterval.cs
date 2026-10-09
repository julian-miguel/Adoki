namespace Adoki.logic.Domain.ValueObjects;

public record MaintenanceInterval(Maintenance Type, uint Interval)
{
    public override string ToString() => $"{Type.Description} | {Interval}";
}