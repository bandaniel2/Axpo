namespace Axpo.ETRM.Domain.Models;

public record Hour
{
    public TimeOnly Time { get; set; }
    public double Volume { get; set; }
}