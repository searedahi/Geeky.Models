namespace Geeky.Models
{
    public class FIshCatch : IFishCatch
    {
        public IFish Fish { get; set; }
        public int FishCaught { get; set; }
    }
}
