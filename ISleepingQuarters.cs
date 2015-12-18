using System.Collections.Generic;

namespace Geeky.Models.Boating
{
    public interface ISleepingQuarters
    {
        int Id { get; set; }

        IEnumerable<IStateRoom> StateRooms { get; set; }
        IEnumerable<IBunk> Bunks { get; set; }
        



    }
}
