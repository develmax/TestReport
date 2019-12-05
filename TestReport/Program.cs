using System;
using System.Threading.Tasks;

namespace TestReport
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var agent1 = "agent1";
            var agent2 = "agent2";

            var report1 = new ReportSpecific1(agent1, DateTime.Now.Date);
            var report2 = new ReportSpecific1(agent2, DateTime.Now.Date);

            var reportService = new ReportService();

            var items1 = await reportService.GetData(report1);
            var items2 = await reportService.GetData(report2);

            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
