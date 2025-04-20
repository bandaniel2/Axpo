namespace Axpo.ETRM.FileGateway;

using Domain.Interfaces;
using Domain.Models;

internal class FileGateway(string FolderPath) : IFileGateway
{
    public void SaveToCSV(List<Hour> hours)
    {
        string fileName = $"PowerPosition_{DateTime.Now.ToString("yyyyMMdd_HHmm")}.csv";

        using var writer = new StreamWriter($"{FolderPath}/{fileName}");
        {
            writer.WriteLine("Local Time,Volume");

            foreach(var hour in hours)
            {
                writer.WriteLine($"{hour.Time.ToString("HH:mm")},{hour.Volume}");
            }
        }
    }
}