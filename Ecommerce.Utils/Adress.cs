namespace Ecommerce.Utils
{
    public class Adress
    {
        public string Street { get; private set; }
        public string Neighborhood { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string Country { get; private set; }
        public string Zip { get; private set; }
        public bool UniqueZip { get; private set; }

        public Adress(string street, string neighborhood, string city, string state, string zip, bool uniqueZip)
        {
            Street = street;
            Neighborhood = neighborhood;
            City = city;
            State = state;
            Country = "Brasil";
            Zip = zip;
            UniqueZip = uniqueZip;
        }

        public Adress()
        {
        }
    }
}
