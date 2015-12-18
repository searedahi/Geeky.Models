using System.Collections.Generic;

namespace Geeky.Models.Boating
{
    public class Landing:ILanding
    {
        public int Id { get; set; }
        public IAddress Address { get; set; }
        public IEnumerable<IBoat> Fleet { get; set; }
        public IEnumerable<IImage> Images { get; set; }
        public IImage MainImage { get; set; }
    }
}
