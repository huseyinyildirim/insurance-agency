using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using InsuranceAgency.Provider.Models;
using InsuranceAgency.Shared;
using InsuranceAgency.Shared.Dtos;
using static System.Net.Mime.MediaTypeNames;

namespace InsuranceAgency.Provider.Providers
{
    public class AcibademSigortaProvider : IProvider
    {
        private readonly HttpClient _httpClient;

        public AcibademSigortaProvider(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient();
        }

        public AcibademSigortaProvider()
        {
        }

        public async Task<Response<Offer>> GetOfferAsync(Quotation quotation)
        {
            Offer offer = new();

            StringContent offerJson = new(JsonSerializer.Serialize(quotation), Encoding.UTF8, Application.Json);

            var httpClientResponse = await _httpClient.PostAsync("http://localhost:5002/api/AcibademSigorta", offerJson);

            string content = await httpClientResponse.Content.ReadAsStringAsync();

            offer = JsonSerializer.Deserialize<Offer>(content);

            return Response<Offer>.Success(offer, HttpStatusCode.OK);
        }
    }
}
