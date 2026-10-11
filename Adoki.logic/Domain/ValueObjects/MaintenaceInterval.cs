namespace Adoki.logic.Domain.ValueObjects;

public class MaintenanceInterval(Maintenance Type, uint Interval)
{
    public override string ToString() => $"{Type.Description} | {Interval}";
}