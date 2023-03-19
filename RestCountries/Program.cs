// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using RestCountries;


CountryService countryService = new CountryService();

countryService.GenerateCountryDataFiles();

Console.WriteLine("Done");