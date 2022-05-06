using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dll.Model
{
    public class Loan
    {
        public int Id { get; set; }
        public User User { get; set; }
        public bool Started { get; set; }
        public bool Finished { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public List<LoanItem> LoanItem { get; set; }
        public List<ReceiptItem> ReceiptItem { get; set; }

        [NotMapped]
        public string Username
        {
            get
            {
                return User.UserName;
            }
        }

        public Loan()
        {
            LoanItem = new List<LoanItem>();
        }

        public Loan(User user, DateTime dateFrom, DateTime dateTo, bool started = true, bool finished = false)
        {
            LoanItem = new List<LoanItem>();
            User = user;
            Started = started;
            Finished = finished;
            DateFrom = dateFrom;
            DateTo = dateTo;
        }
    }
}
