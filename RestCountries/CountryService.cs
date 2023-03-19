using Newtonsoft.Json;

namespace RestCountries
{
    public class CountryService
    {
        public void GenerateCountryDataFiles()
        {
            HttpClient client = new();

            var response = client.GetAsync("https://restcountries.com/v3.1/all").Result;

            var countries = JsonConvert.DeserializeObject<IEnumerable<Country>>(response.Content.ReadAsStringAsync().Result);

            foreach (var country in countries)
            {
                File.WriteAllLines($"D:\\Countries\\{country.Name.Common}.txt", new string[]
                {
                    $"region: {country.Region}",
                    $"subregion: {country.SubRegion}",
                    $"latlng: {string.Join(',', country.LatLng)}",
                    $"area: {country.Area}",
                    $"population: {country.Population}"
                });
            }

        }
    }
}
