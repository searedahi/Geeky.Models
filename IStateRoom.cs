using System.Collections.Generic;

namespace Geeky.Models.Boating
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
