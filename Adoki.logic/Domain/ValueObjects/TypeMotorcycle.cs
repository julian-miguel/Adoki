namespace Adoki.logic.Domain.ValueObjects;

record TypeMotorcycle(string Marca, string Modelo)
{
    public string Marca
    {
        get; init => field = value.Replace(" ", "") ??
        throw new ArgumentNullException(nameof(value));
    } = Marca;
    public string Modelo
    {
        get; init => field = value.Replace(" ", "") ??
        throw new ArgumentNullException(nameof(value));
    } = Modelo;
    public List<MaintenanceInterval> MaintenanceIntervals { get; set; } = [];
}