using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace RestCountries
{
    public class Country
    {
        public Name Name { get; set; }
        public string Region { get; set; }
        public string SubRegion { get; set; }
        public List<double> LatLng { get; set; }
        public double Area { get; set; }
        public int Population { get; set; }
    }

    public class Name
    {
        public string Common { get; set; }
    }
}
