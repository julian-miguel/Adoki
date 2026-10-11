namespace Adoki.logic.Domain.Enums;

[Flags]
public enum Maintenance
{
    NONE = 0,
    ACEITE = 2,
    CADENA = 4,
    GOMA = 8,
    FILTRO = 16,
    ALL = ACEITE | CADENA | GOMA | FILTRO
}