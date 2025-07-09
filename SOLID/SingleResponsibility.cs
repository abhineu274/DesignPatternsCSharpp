using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharpp.SOLID
{
    // BAD: One class does too much
    public class Report_Bad
    {
        public string Text { get; set; }

        public void Print()
        {
            Console.WriteLine($"Printing report: {Text}");
        }
    }

    // GOOD: Split responsibilities
    public class Report
    {
        public string Text { get; set; }
    }

    public class ReportPrinter
    {
        public void Print(Report report)
        {
            Console.WriteLine($"Printing report: {report.Text}");
        }
    }

    public static class SingleResponsibility
    {
        public static void Run()
        {
            var report = new Report { Text = "Monthly report" };
            var printer = new ReportPrinter();
            printer.Print(report);
        }
    }
}
