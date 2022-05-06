using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dll.Model
{
    public class Membership
    {
        public int Id { get; set; }
        public User User { get; set; }
        public DateTime DateFrom{ get; set; }
        public DateTime DateTo{ get; set; }

        [NotMapped]
        public string UserName
        {
            get
            {
                return User.UserName;
            }

        }

        public Membership()
        {
            DateFrom = DateTime.Now;
            DateTo = DateFrom.AddYears(1);
        }
    }
}
