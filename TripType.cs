namespace Geeky.Models.Boating
{
    public class TripType : ITripType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }
    }
}
