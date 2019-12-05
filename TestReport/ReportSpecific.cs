using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestReport
{
    public interface IReportSpecific<T>
    {
        string Name { get; }
        Task<List<Filter>> GetFilter(Parameters parameters);
        List<T> FormData(Grid grid);
    }

    public abstract class ReportSpecific<T> : IReportSpecific<T>
    {
        public abstract string Name { get; }

        public abstract Task<List<Filter>> GetFilter(Parameters parameters);

        public abstract List<T> FormData(Grid grid);
    }
}