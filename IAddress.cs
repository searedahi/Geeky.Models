namespace Geeky.Models
{
    public interface IAddress
    {
        int Id { get; set; }
        string Street { get; set; }
        string City { get; set; }
        string State { get; set; }
        string Zip { get; set; }
        string Country { get; set; }
        string County { get; set; }
    }
}
