namespace Adoki.logic.Domain.ValueObjects;
using Adoki.logic.Domain.Enums;

public class MaintenanceInterval(Maintenance Type, uint Interval)
{
    public override string ToString() => $"{Type} | {Interval}";
}