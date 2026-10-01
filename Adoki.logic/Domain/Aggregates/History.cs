using Adoki.logic.Domain.Entities;
using Adoki.logic.Domain.ValueObjects;
namespace Adoki.logic.Domain.Aggregates;

class History(List<Read> Items)
{
    public List<Read> Items { get; init; } = Items.Count > 0
        ? (List<Read>)(
            from item in Items
            orderby item.Date
            select item
            ) : Items;

    public void Append(Read read)
    {
        var fechaExistente = Items.Any(r => r.Date == read.Date);

        if (!fechaExistente)
            Items.Add(read);
        else
            throw new ExisteReadException("Lectura ya añadida anteriormente, solo actualizable.");
    }
    public void UpdateRead(List<int> operation)
    {
        int last;
        if (Items.Count >= 1)
        {
            last = Items.Count - 1;
            Items[last].Maintenance.AddRange(operation);
        }
    }
    public void UpdateRead(Kilometer kilometer)
    {
        int last;
        if (Items.Count >= 1)
        {
            last = Items.Count() - 1;
            Items[last].Kilometers += kilometer;
        }
    }
    public void UpdateRead(List<int> operation, Kilometer kilometer)
    {
        int last;
        if (Items.Count >= 1)
        {
            last = Items.Count() - 1;
            Items[last].Maintenance.AddRange(operation);
            Items[last].Kilometers += kilometer;
        }

    }
}

public class ExisteReadException : Exception
{
    // Constructor por defecto (hereda del padre)
    public ExisteReadException() : base()
    {
    }
    // Constructor con mensaje personalizado
    public ExisteReadException(string message) : base(message)
    {
    }
    // Constructor con mensaje y pila de llamadas (stack trace)
    public ExisteReadException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}