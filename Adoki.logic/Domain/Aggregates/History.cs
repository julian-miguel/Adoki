using Adoki.logic.Domain.Entities;
//using Adoki.logic.Domain.ValueObjects;
//using Adoki.logic.Domain.Enums;

namespace Adoki.logic.Domain.Aggregates;

public class History
{
    public List<Read> Items { get; init; }

    public History()=> Items = [];
    
    public History(List<Read> Items)
    {
        this.Items = Items.Count > 0
        ? (List<Read>)(
            from item in Items
            orderby item.Date
            select item
            ) : Items;
    }

    public void Append(Read read)
    {
        var fechaExistente = Items.Any(r => r.Date == read.Date);

        if (!fechaExistente)
            Items.Add(read);
        else
            throw new ExisteReadException("Lectura ya añadida anteriormente, solo actualizable.");
    }
    /*
    public void UpdateRead(Maintenance operation)
    {
        int last;
        if (Items.Count >= 1)
        {
            last = Items.Count - 1;
            Items[last].Operation |= operation;
        }
    }
    public void UpdateRead(Kilometer kilometer)
    {
        int last;
        if (Items.Count >= 1)
        {
            last = Items.Count() - 1;
            Items[last].Odometer += kilometer;
        }
    }
    public void UpdateRead(Maintenance operation, Kilometer kilometer)
    {
        UpdateRead(kilometer);
        UpdateRead(operation);
    }
    */
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