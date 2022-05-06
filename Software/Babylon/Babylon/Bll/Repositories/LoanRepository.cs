using Dll.Model;
using Bll.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Bll.Repositories
{
    public class LoanRepository : GenericRepository<Loan>
    {
        private AppDbContext _dbContext { get; set; }

        public LoanRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            _dbContext = _appDbContext;
        }
        public List<Loan> GetAllLoans()
        {
            return _dbContext.Loans.Include(x => x.User).Include(y => y.LoanItem).ToList();
        }

        public List<LoanItem> GetAllLoanItems(Loan loan)
        {
            return _dbContext.Loans.Include(x => x.LoanItem).FirstOrDefault(x => x.Id == loan.Id).LoanItem;
        }

    }
}
