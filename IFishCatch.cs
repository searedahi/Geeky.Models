namespace Geeky.Models.Boating
{
    public interface IFishCatch
    {
        IFish Fish { get; set; }
        int FishCaught { get; set; }

    }
}
