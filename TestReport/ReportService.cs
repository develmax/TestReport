using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestReport
{
    public interface IReportService
    {
        Task<List<ReportItem>> GetReports();
        Task<Parameters> GetParameters(ReportItem reportItem);
        Task<Grid> GetData(List<Filter> filters);
    }

    public class ReportService : IReportService
    {
        public async Task<List<T>> GetData<T>(IReportSpecific<T> specific)
        {
            var reports = await GetReports();

            var report = reports.FirstOrDefault(i => i.Name == specific.Name);

            var parameters = await GetParameters(report);

            var filter = await specific.GetFilter(parameters);

            var data = await GetData(filter);

            return specific.FormData(data);
        }

        public async Task<List<ReportItem>> GetReports()
        {
            await Task.Delay(100);

            return new List<ReportItem>();
        }

        public async Task<Parameters> GetParameters(ReportItem reportItem)
        {
            await Task.Delay(100);

            return new Parameters();
        }

        public async Task<Grid> GetData(List<Filter> filters)
        {
            await Task.Delay(100);

            return new Grid();
        }
    }
}