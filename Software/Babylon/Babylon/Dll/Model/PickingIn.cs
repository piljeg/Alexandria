using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dll.Model
{
    public class PickingIn
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public List<PickingInItem> PickingInItem { get; set; }

        public PickingIn()
        {
            Date = DateTime.Now;
            PickingInItem = new List<PickingInItem>();
        }
    }
}
