using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.ViewModels
{
    public class AnalyzeViewModel
    {
        public ulong TotalIncome { get; set; }
        public ulong TodayIncome { get; set; }
        public ulong AverageIncome { get; set; }
        public ulong TotalOutcome { get; set; }
        public ulong TodayOutcome { get; set; }
        public ulong AverageOutcome { get; set; }
    }
}
