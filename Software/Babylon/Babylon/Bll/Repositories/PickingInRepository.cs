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
    public class PickingInRepository : GenericRepository<PickingIn>
    {
        private AppDbContext _dbContext { get; set; }

        public PickingInRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            _dbContext = _appDbContext;
        }

        public List<PickingIn> GetAllPickingsIn()
        {
            return _dbContext.PickingsIn.Include(u => u.PickingInItem).ToList();
        }

        public List<PickingInItem> GetAllPickingInItems(PickingIn pickingIn)
        {
            return _dbContext.PickingsIn.Include(u => u.PickingInItem).FirstOrDefault(p => p.Id == pickingIn.Id).PickingInItem;
        }
    }
}
