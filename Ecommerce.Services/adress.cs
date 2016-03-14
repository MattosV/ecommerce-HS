namespace Ecommerce.Services
{
    public class Adress
    {
        public string Street { get; private set; }
        public string Neighborhood { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string Country { get; private set; }   

        public Adress(string street, string neighborhood, string city, string state)
        {
            Street = street;
            Neighborhood = neighborhood;
            City = city;
            State = state;
            Country = "Brasil";
        }

        public Adress()
        {
        }
    }
}
