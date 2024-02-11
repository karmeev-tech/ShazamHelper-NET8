using System.Net.Http.Headers;
using MetaMusic.Integrations.Facade.Client.Exceptions;
using Newtonsoft.Json;

namespace MetaMusic.Integrations.Facade.Client;

public static class ShazamClient
{
    public static async Task<T> MakeRequest<T>(string base64)
    where T: class
    {
        const string rapidApiKey = "";
        try
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://shazam.p.rapidapi.com/songs/detect"),
                Headers =
                {
                    { "X-RapidAPI-Key", rapidApiKey },
                    { "X-RapidAPI-Host", "shazam.p.rapidapi.com" },
                },
                Content = new StringContent(base64)
                {
                    Headers =
                    {
                        ContentType = new MediaTypeHeaderValue("text/plain")
                    }
                }
            };
            using var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
        
            var jsonString = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<T>(jsonString);

            if (result is null) throw new EmptyResultException("result is null");
            return result;
        }
        catch (HttpRequestException ex)
        {
            throw new Exception("Status is not 200! |" + ex.Message);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}