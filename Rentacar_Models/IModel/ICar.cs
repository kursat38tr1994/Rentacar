namespace Rentacar_Models
{
    public interface ICar
    {
        bool Availability { get; set; }
        Brand Type { get; set; }
        double CurrentPrice { get; set; }
        string Fuel { get; set; }
        int Id { get; set; }
        string LicensePlate { get; set; }
    }
}