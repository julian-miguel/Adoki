namespace Adoki.logic.Domain.Entities;

using Adoki.logic.Domain.ValueObjects;

public class Read(DateTime Date, Kilometer Km)
{
    public DateTime Date { get; set; } = Date.Date;
    public Kilometer Kilometers { get; set; } = Km;
    public List<Maintenance> Maintenances { get; set; } = [];

    public static (int, Kilometer) operator -(Read a, Read b)
    {
        int diferenciaDias = (a.Date - b.Date).Days;
        Kilometer diferenciaKm = a.Kilometers - b.Kilometers;
        return (diferenciaDias, diferenciaKm);
    }
    public override string ToString() => $"Date {DateOnly.FromDateTime(Date)}\nOdometry {Kilometers}\nMantenimiento(s) {Maintenances}";
}