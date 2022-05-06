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
    public class MembershipRepository : GenericRepository<Membership>
    {
        private AppDbContext _dbContext { get; set; }

        public MembershipRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            _dbContext = _appDbContext;
            _dbContext.Configuration.ProxyCreationEnabled = false;
            _dbContext.Configuration.LazyLoadingEnabled = false;
        }

        public List<Membership> GetAllMemberships()
        {
            return _dbContext.Memberships.Include(u => u.User).ToList();
        }
    }
}
