using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dll.Model
{
    public class Category
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        public string Description { get; set; }
        public List<Literature> Literature { get; set; }

        public Category()
        {

        }
        public Category(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
