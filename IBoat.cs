using System.Collections.Generic;

namespace Geeky.Models.Boating
{
    public interface IBoat : IGeekyThing
    {
        int Id { get; set; }
        string Name { get; set; }
        IEnumerable<string> Owners { get; set; }
        IEnumerable<string> Skippers { get; set; }
        double Length { get; set; }
        double Width { get; set; }
        int YearBuilt { get; set; }
        bool HotGalley { get; set; }
        int SfrId { get; set; }
        int Capacity { get; set; }
        IEnumerable<IFishingTrip> FishingTrips { get; set; }
        IEnumerable<IImage> Images { get; set; }
        IImage MainImage { get; set; }
        int BunkCount { get; set; }
        IEnumerable<IBunk> Bunks { get; set; }
        int StateRoomCount { get; set; }
        IEnumerable<IStateRoom> StateRooms { get; set; }
        string PhoneNumber { get; set; }
    }
}
