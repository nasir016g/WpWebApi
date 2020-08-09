
using Wp.Core.Domain.Expenses;
using System.Linq;
using Wp.Data;
using Wp.Core;
using Wp.Core.Interfaces.Repositories;

namespace Wp.Services.Expenses
{
    public class ExpenseCategoryService : EntityService<ExpenseCategory>, IExpenseCategoryService
    {
        private IBaseRepository<ExpenseCategory> expenseCategoryRepo;
        // IExpenseCategoryRepository expenseCategoryRepo; // with includes

        public ExpenseCategoryService(IUnitOfWork unitOfWork,
            IBaseRepository<ExpenseCategory> expenseCategoryRepo) : base(unitOfWork, expenseCategoryRepo)
        {
            this.expenseCategoryRepo = expenseCategoryRepo;
        }

        public ExpenseCategory GetByName(string name)
        {
            return expenseCategoryRepo.Table.Where(x => x.Name.ToLower() == name.ToLower()).FirstOrDefault();
        }
    }
}
