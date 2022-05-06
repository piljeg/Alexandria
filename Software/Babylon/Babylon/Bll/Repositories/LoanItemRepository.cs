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
    public class LoanItemRepository : GenericRepository<LoanItem>
    {
        private AppDbContext _dbContext { get; set; }

        public LoanItemRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            _dbContext = _appDbContext;
            _dbContext.Configuration.ProxyCreationEnabled = false;
            _dbContext.Configuration.LazyLoadingEnabled = false;
        }

        public List<LoanItem> GetAllLoanItems()
        {
            return _dbContext.LoanItems.Include(x => x.Loan).Include(x => x.Literature).Include(x => x.Literature.Author).ToList();
        }

    }
}
