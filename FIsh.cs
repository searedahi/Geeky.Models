using System.Collections.Generic;

namespace Geeky.Models.Boating
{
    public class Fish : IFish
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<IImage> Images { get; set; }
        public IImage MainImage { get; set; }
    }
}
