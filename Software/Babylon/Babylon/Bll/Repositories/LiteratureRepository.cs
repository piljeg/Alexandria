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
    public class LiteratureRepository : GenericRepository<Literature>
    {
        private AppDbContext _dbContext { get; set; }


        public LiteratureRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            _dbContext = _appDbContext;
        }

        public List<Literature> GetAllLiteratures()
        {
            return _dbContext.Literatures.Include(u => u.Author).Include(x => x.Category).ToList();
        }

        public bool IsLoaned(int id)
        {
            var loanItems = _appDbContext.Literatures.Include("LoanItem").FirstOrDefault(l => l.Id == id).LoanItem;
            bool isLoaned = false;
            foreach (var loanItem in loanItems)
            {
                var newLoanItem = _appDbContext.LoanItems.Include("Loan").FirstOrDefault(li => li.Id == loanItem.Id);
                if (loanItem.Loan.DateTo >= DateTime.Now)
                {
                    isLoaned = true;
                    break;
                }
            }

            return isLoaned;
        }
        
    }
}
