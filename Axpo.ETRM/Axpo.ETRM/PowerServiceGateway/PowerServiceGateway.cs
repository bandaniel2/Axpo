namespace Axpo.ETRM.PowerServiceGateway;

using Axpo;
using Domain.Models;
using Domain.Interfaces;

internal class PowerServiceGateway(IPowerService powerService) : IPowerServiceGateway
{
    public async Task<IEnumerable<Hour>> GetHourlyVolumes()
    {
        var trades = await powerService.GetTradesAsync(DateTime.Today.AddDays(1));

        return Enumerable.Range(0,24)
            .Select(i => new Hour
            {
                Time = new TimeOnly((i + 23) % 24,0),
                Volume = trades.Sum(trade => trade.Periods[i].Volume)
            });
    }
}