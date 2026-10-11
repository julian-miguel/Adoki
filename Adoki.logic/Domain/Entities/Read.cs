namespace Adoki.logic.Domain.Entities;
using Adoki.logic.Domain.ValueObjects;
using Adoki.logic.Domain.Enums;


public class Read
{
    public Read()
    {
        Date = DateTime.Now.Date;
        Odometer = new(0);
        Operation = Maintenance.NONE;
    }
    public Read(DateTime Date, Kilometer Km)
    {
        this.Date = Date.Date;
        Odometer = Km;
        Operation = Maintenance.NONE;
    }

    public DateTime Date { get; set; }
    public Kilometer Odometer { get; set; }
    public Maintenance Operation { get; set; }

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