namespace Axpo.ETRM.Domain.Interfaces;

using Domain.Models;

public interface IFileGateway
{
    void SaveToCSV(List<Hour> hours);
}