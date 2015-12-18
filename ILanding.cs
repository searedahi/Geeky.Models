using System.Collections.Generic;

namespace Geeky.Models.Boating
{
    public interface ILanding : IGeekyThing
    {
        int Id { get; set; }
        IAddress Address { get; set; }
        IEnumerable<IBoat> Fleet { get; set; }
        IEnumerable<IImage> Images { get; set; }
        IImage MainImage { get; set; }
    }
}
