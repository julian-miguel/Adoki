namespace Adoki.logic.Domain.ValueObjects;

public class Maintenance
{
    public int? Id { get; set; }
    public string? Description { get; set; }

    public Maintenance(int Id, string Description)
    {
        this.Id = Id;
        this.Description = Description;
    }

    public Maintenance(){}
}