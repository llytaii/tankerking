// See https://aka.ms/new-console-template for more information

using System.Text.Json;

public class Program
{
    static readonly HttpClient httpClient = new HttpClient();
    public static async Task Main()
    {
        string base_url = "https://creativecommons.tankerkoenig.de/json/";
        string api_key = "";

        string url = "https://tankerkoenig.de/ajax_v3_public/get_stations_near_postcode.php?postcode=82362&radius=2&gasType=diesel&sort=price";

        HttpResponseMessage response = await httpClient.GetAsync(url);

        if (response.IsSuccessStatusCode)
        {
            var json_text = await response.Content.ReadAsStringAsync();
            if(string.IsNullOrEmpty(json_text)) return;

            ApiData? apiData = JsonSerializer.Deserialize<ApiData>(json_text);
            if(apiData == null) return;

            foreach(var station in apiData.stations){
                Console.WriteLine($"{station})");
            }

        }

    }
}
