namespace Axpo.ETRM.ReportService;

using Domain.Interfaces;
using Interfaces;

internal class ReportService(IPowerServiceGateway powerServiceGateway, IFileGateway fileGateway) : IReportService
{
    public async Task GetReport()
    {
        var trades = await powerServiceGateway.GetHourlyVolumes();
        fileGateway.SaveToCSV(trades);
    }
}