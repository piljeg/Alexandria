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
    public class ReceiptItemRepository : GenericRepository<ReceiptItem>
    {
        private AppDbContext _dbContext { get; set; }

        public ReceiptItemRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            _dbContext = _appDbContext;
        }

        public List<ReceiptItem> GetAllReceiptItems()
        {
            return _dbContext.ReceiptItems.Include(x => x.Loan).Include(x => x.Receipt).ToList();
        }
    }
}
