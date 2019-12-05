using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TestReport
{
    public class ReportSpecific1 : IReportSpecific<Item1>
    {
        public ReportSpecific1(string agentId, DateTime dateTime)
        {

        }

        public string Name => "report1";

        public async Task<List<Filter>> GetFilter(Parameters parameters)
        {
            await Task.Delay(100);

            return new List<Filter>();
        }

        public List<Item1> FormData(Grid grid)
        {
            return new List<Item1>();
        }
    }
}