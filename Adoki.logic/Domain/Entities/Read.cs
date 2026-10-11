namespace Adoki.logic.Domain.Entities;
using Adoki.logic.Domain.ValueObjects;
using Adoki.logic.Domain.Enums;


public class Read(DateTime Date, Kilometer Km)
{
    public DateTime Date { get; set; } = Date.Date;
    public Kilometer Odometer { get; set; } = Km;
    public Maintenance Operation { get; set; } = Maintenance.NONE;

    public static (int, Kilometer) operator -(Read a, Read b)
    {
        int diferenciaDias = (a.Date - b.Date).Days;
        Kilometer diferenciaKm = a.Odometer - b.Odometer;
        return (diferenciaDias, diferenciaKm);
    }
    public override string ToString() => $"Date {
        DateOnly.FromDateTime(Date)}\nOdometer {
            Odometer}\nOperations {Operation}";
}