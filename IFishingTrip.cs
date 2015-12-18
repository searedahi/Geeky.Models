using System;
using System.Collections.Generic;

namespace Geeky.Models.Boating
{
    public interface IFishingTrip : IGeekyThing
    {
        int Id { get; set; }
        string Name { get; set; }
        DateTime ReportDate { get; set; }
        ITripType TripType { get; set; }
        int AnglerCount { get; set; }
        IEnumerable<IFishCatch> FishCount { get; set; }
        IEnumerable<IImage> Images { get; set; }
        IImage MainImage { get; set; }
    }
}
