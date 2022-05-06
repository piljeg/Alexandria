using Bll.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.Services
{
    public class UnitOfWork
    {
        protected AppDbContext _appDbContext { get; set; }
        public UserRepository Users { get; set; }
        public PickingInRepository PickingIns { get; set; }
        public AuthorRepository Authors { get; set; }
        public CategoryRepository Categories { get; set; }
        public LiteratureRepository Literatures { get; set; }
        public LoanRepository Loans { get; set; }
        public LoanItemRepository LoanItems { get; set; }
        public MembershipRepository Memberships { get; set; }
        public PickingInItemRepository PickingInItems { get; set; }
        public PickingOutRepository PickingOuts { get; set; }
        public ReceiptRepository Receipts { get; set; }
        public ReceiptItemRepository ReceiptItems { get; set; }
        public RoleRepository Roles { get; set; }

        public UnitOfWork(AppDbContext dbContext)
        {
            _appDbContext = dbContext;
            Roles = new RoleRepository(_appDbContext);
            Users = new UserRepository(_appDbContext);
            PickingIns = new PickingInRepository(_appDbContext);
            Authors = new AuthorRepository(_appDbContext);
            Categories = new CategoryRepository(_appDbContext);
            Literatures = new LiteratureRepository(_appDbContext);
            Loans = new LoanRepository(_appDbContext);
            LoanItems = new LoanItemRepository(_appDbContext);
            Memberships = new MembershipRepository(_appDbContext);
            PickingInItems = new PickingInItemRepository(_appDbContext);
            PickingOuts = new PickingOutRepository(_appDbContext);
            Receipts = new ReceiptRepository(_appDbContext);
            ReceiptItems = new ReceiptItemRepository(_appDbContext);
        }

        public int Complete()
        {
            return _appDbContext.SaveChanges();
        }
    }
}
