

using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;
using Validator = System.ComponentModel.DataAnnotations;

namespace WasmPortfolio;
public class EmailServices
{
    private readonly HttpClient _httpClient;

    public EmailServices(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<HttpResponseMessage> SendContactForm(string email, string name, string message)
    {
        // Check for null values
        if (email == null || name == null || message == null)
        {
            return new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.BadRequest,
                Content = new StringContent(JsonSerializer.Serialize(new { success = false, message = "Email, name, or message cannot be null" })),
            };
        }

        // Add other validation logic here...

        var embed = new
        {
            title = "📩 New message from Abkhan",
            description = $">>> {message.Trim()}",
            color = 5759645,
            fields = new[]
            {
                new { name = "🧑‍🦱 Name", value = $"```{name.Trim()}```", inline = true },
                new { name = "📨 Email", value = $"```{email.Trim()}```", inline = true }
            }
        };

        try
        {
            var response = await _httpClient.PostAsJsonAsync("https://discord.com/api/webhooks/1229310254630699099/70H7OzUpehnWZ9x5FFf5pOPSHEjH8nVz3CNLjswPDBt86b_7cMWjESql-l_Ari8UxwV_?wait=true", new
            {
                username = "codewithabkhan",
                avatar_url = "https://sqlepey.com/favicon.ico",
                embeds = new[] { embed }
            });

            return response;
        }
        catch (Exception ex)
        {
            return new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.InternalServerError,
                Content = new StringContent(JsonSerializer.Serialize(new { success = false, message = ex.Message })),
            };
        }
    }
    

}
