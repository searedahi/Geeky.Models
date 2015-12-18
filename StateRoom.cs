using System.Collections.Generic;

namespace Geeky.Models.Boating
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
