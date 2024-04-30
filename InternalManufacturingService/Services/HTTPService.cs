using Models;

namespace InternalManufacturingService.Services;

public class HTTPService : IHTTPService
{
    private readonly IHttpClientFactory _httpClientFactory;

    public HTTPService(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<ExternalCar> GetCarPartsAsync(string registrationNumber)
    {
        HttpClient client = _httpClientFactory.CreateClient();
        // Define the URL for fetching car parts data (replace with your actual URL)
        string apiUrl = $"http://external-manufacturing-service:80/Car?registrationNumber={registrationNumber}";

        try
        {
            Console.WriteLine(apiUrl);
            // Send the HTTP GET request
            HttpResponseMessage response = await client.GetAsync(apiUrl);

            // Check if the request was successful (status code 200)
            if (response.IsSuccessStatusCode)
            {
                // Read the response content as a string
                string responseBody = await response.Content.ReadAsStringAsync();

                // Deserialize the JSON response to ExternalCar object
                ExternalCar carParts = Newtonsoft.Json.JsonConvert.DeserializeObject<ExternalCar>(responseBody);

                // Return the ExternalCar object
                return carParts;
            }
            else
            {
                // Handle the case when the request fails
                Console.WriteLine($"HTTP request failed with status code {response.StatusCode}");
                return null;
            }
        }
        catch (HttpRequestException e)
        {
            // Handle the case when an exception occurs during the HTTP request
            Console.WriteLine($"HTTP request failed: {e.Message}");
            return null;
        }
    }
}