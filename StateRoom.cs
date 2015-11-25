using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Geeky.Models
{
    public class StateRoom : IStateRoom
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Capacity { get; set; }
        public IEnumerable<IBunk> Beds { get; set; }
    }
}
