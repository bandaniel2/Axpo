namespace Axpo.ETRM;

using Axpo.ETRM.FileGateway.Modules;

public record Configuration
{
    public FileConfiguration FileGateway {get; set;} = new();
    public int TimeSpan {get; set;} = 5;
}