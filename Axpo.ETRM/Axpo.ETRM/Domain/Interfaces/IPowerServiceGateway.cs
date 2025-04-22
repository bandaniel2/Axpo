namespace Axpo.ETRM.Domain.Interfaces;

using Models;

public interface IPowerServiceGateway
{
    Task<IEnumerable<Hour>> GetHourlyVolumes();
}