using System.Collections.Generic;

namespace Geeky.Models.Boating
{
    public class Boat: IBoat
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<string> Owners { get; set; }
        public IEnumerable<string> Skippers { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public int YearBuilt { get; set; }
        public bool HotGalley { get; set; }
        public IEnumerable<IFishingTrip> FishingTrips { get; set; }
        public IEnumerable<IImage> Images { get; set; }
        public IImage MainImage { get; set; }
        public int BunkCount { get; set; }
        public int SfrId { get; set; }
        public int Capacity { get; set; }
        public IEnumerable<IBunk> Bunks { get; set; }
        public int StateRoomCount { get; set; }
        public IEnumerable<IStateRoom> StateRooms { get; set; }
        public string PhoneNumber { get; set; }


    }
}
