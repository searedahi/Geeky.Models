namespace Geeky.Models.Boating
{
    public class FIshCatch : IFishCatch
    {
        public IFish Fish { get; set; }
        public int FishCaught { get; set; }
    }
}
