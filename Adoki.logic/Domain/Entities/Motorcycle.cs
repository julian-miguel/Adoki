using Adoki.logic.Domain.Aggregates;
using Adoki.logic.Domain.ValueObjects;

namespace Adoki.logic.Domain.Entities;

public class Motorcycle
{
    public Registration Registration { get; init; }
    public TypeMotorcycle TypeMotorcycle { get; init; }
    public History History { get; init; }

    public Motorcycle(Registration registration, TypeMotorcycle typeMotorcycle)
    {
        Registration = registration;
        TypeMotorcycle = typeMotorcycle;
        History = new([]);
    }
    public Motorcycle(Registration registration, TypeMotorcycle typeMotorcycle, History history)
    {
        Registration = registration;
        TypeMotorcycle = typeMotorcycle;
        History = history;
    }
    public override string ToString()
    {
        var text = $"Registro: {Registration}\nMarca: {TypeMotorcycle.Marca}\nModelo: {TypeMotorcycle.Modelo}\n";
        return text;
    }
}