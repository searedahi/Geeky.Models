using System;
using System.Collections.Generic;

namespace Geeky.Models
{
    public class FishingTrip : IFishingTrip
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReportDate { get; set; }
        public ITripType TripType { get; set; }
        public int AnglerCount { get; set; }
        public IEnumerable<IFishCatch> FishCount { get; set; }
        public IEnumerable<IImage> Images { get; set; }
        public IImage MainImage { get; set; }
    }
}
