using System.Collections.Generic;

namespace Geeky.Models
{
    public interface IFish : IGeekyThing
    {
        int Id { get; set; }
        string Name { get; set; }
        IEnumerable<IImage> Images { get; set; }
        IImage MainImage { get; set; }
    }
}
