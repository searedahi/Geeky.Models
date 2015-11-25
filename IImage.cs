namespace Geeky.Models
{
    public interface IImage
    {
        int Id { get; set; }
        string Url { get; set; }
        /// <summary>
        /// Kilobytes
        /// </summary>
        int Size { get; set; }
    }
}
