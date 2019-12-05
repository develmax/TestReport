using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TestReport
{
    public class ReportSpecific2 : IReportSpecific<Item2>
    {
        public ReportSpecific2(string agentId, DateTime dateTime)
        {

        }

        public string Name => "report2";

        public async Task<List<Filter>> GetFilter(Parameters parameters)
        {
            await Task.Delay(100);

            return new List<Filter>();
        }

        public List<Item2> FormData(Grid grid)
        {
            return new List<Item2>();
        }
    }
}