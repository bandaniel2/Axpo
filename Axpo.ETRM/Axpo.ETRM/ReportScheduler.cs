using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Axpo.ETRM.ReportService.Interfaces;
using Axpo.ETRM;

public class ReportScheduler(
        IReportService reportService,
        Configuration config,
        ILogger<ReportScheduler> logger) : BackgroundService
{

    protected override async Task ExecuteAsync(CancellationToken cancellationToken)
    {
        while (!cancellationToken.IsCancellationRequested)
        {
            try
            {
                logger.LogInformation($"Running report at: {DateTime.Now}");
                await reportService.GetReport();
                logger.LogInformation($"Report generated successfully");
            }
            catch (Exception ex)
            {
                logger.LogError($"Failed to generate report: {ex.Message}");
            }

            TimeSpan interval = TimeSpan.FromMinutes(config.TimeSpan);
            await Task.Delay(interval, cancellationToken);
        }
    }
}
