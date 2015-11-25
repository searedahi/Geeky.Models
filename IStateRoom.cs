using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geeky.Models
{
    public interface IStateRoom
    {
        int Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        int Capacity { get; set; }
        IEnumerable<IBunk> Beds { get; set; }
    }
}
