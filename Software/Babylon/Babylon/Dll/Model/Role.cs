using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dll.Model
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AuthorisationLevel { get; set; }
        public List<User> User { get; set; }

        public Role()
        {
        }
    }
}
