namespace Geeky.Models
{
    public interface IFishCatch
    {
        IFish Fish { get; set; }
        int FishCaught { get; set; }

    }
}
