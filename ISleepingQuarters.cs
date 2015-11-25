using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geeky.Models
{
    public interface ISleepingQuarters
    {
        int Id { get; set; }

        IEnumerable<IStateRoom> StateRooms { get; set; }
        IEnumerable<IBunk> Bunks { get; set; }
        



    }
}
