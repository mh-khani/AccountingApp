using DataLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace Business
{
    public class MonthlyReport
    {
        public static ReportViewModel report()
        {
            ReportViewModel viewModel = new ReportViewModel();
            var startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            var endDate = startDate.AddMonths(1).AddDays(-1);

            using (UnitOfWork db = new UnitOfWork())
            {
                var income = db.AccountingRepository.Get(a => a.TypeId == 1 && a.DateTime >= startDate && a.DateTime <= endDate).Select(a => a.Amount).ToList();
                var expense = db.AccountingRepository.Get(a => a.TypeId == 2 && a.DateTime >= startDate && a.DateTime <= endDate).Select(a => a.Amount).ToList();

                viewModel.Income = income.Sum();
                viewModel.Expense = expense.Sum();
                viewModel.Balance = viewModel.Income - viewModel.Expense;
            }

            return viewModel;
        }
    }
}
