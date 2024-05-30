using Accounting.DataLayer;
using Accounting.DataLayer.Context;
using Accounting.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Business
{
    public class TransactionAnalysis
    {
        public static AnalyzeViewModel GetAnalyzeView()
        {
            AnalyzeViewModel analyzeView = new AnalyzeViewModel();
            using (UnitOfWork db = new UnitOfWork())
            {
                DateTime startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 01);
                DateTime endDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 30);
                DateTime today = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                var Totalincome = db.TransactionsGenericRepository.Get(t => t.TypeID == 1 && t.DateTime.Day >= startDate.Day && t.DateTime.Day <= endDate.Day).Select(a => a.Amount).ToList();
                var Totaloutcome = db.TransactionsGenericRepository.Get(t => t.TypeID == 2 && t.DateTime.Day >= startDate.Day && t.DateTime.Day <= endDate.Day).Select(a => a.Amount).ToList();
                var todayIncome = db.TransactionsGenericRepository.Get(t => t.TypeID == 1 && t.DateTime.Day >= today.Day && t.DateTime.Day <= today.Day).Select(a => a.Amount).ToList();
                var todayOutcome = db.TransactionsGenericRepository.Get(t => t.TypeID == 2 && t.DateTime.Day >= today.Day && t.DateTime.Day <= today.Day).Select(a => a.Amount).ToList();

                analyzeView.TotalIncome = (ulong)Totalincome.Sum();
                analyzeView.TodayIncome = (ulong)todayIncome.Sum();
                if (Totalincome.Count() < 2)
                {
                    analyzeView.AverageIncome = (ulong)Totalincome.Sum();
                }
                else
                {
                    analyzeView.AverageIncome = (ulong)Totalincome.Sum() / (ulong)Totalincome.Count();
                }
                analyzeView.TotalOutcome = (ulong)Totaloutcome.Sum();
                analyzeView.TodayOutcome = (ulong)todayOutcome.Sum();
                if (Totaloutcome.Count() < 2)
                {
                    analyzeView.AverageOutcome = (ulong)Totaloutcome.Sum();
                }
                else
                {
                    analyzeView.AverageOutcome = (ulong)Totaloutcome.Sum() / (ulong)Totaloutcome.Count();
                }

            }
            return analyzeView;
        }
    }
}
