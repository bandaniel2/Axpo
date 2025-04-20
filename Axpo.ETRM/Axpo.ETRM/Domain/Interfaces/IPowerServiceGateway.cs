namespace Axpo.ETRM.Domain.Interfaces;

using Models;

public interface IPowerServiceGateway
{
    Task<List<Hour>> GetHourlyVolumes();
}