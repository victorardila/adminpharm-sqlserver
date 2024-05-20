using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Presentacion
{
    public class FacturacionElectronicaAPI
    {
        private readonly string _baseUrl = "https://api.siigo.com/v1";
        private readonly string _token;

        public FacturacionElectronicaAPI(string token)
        {
            _token = token;
        }

        public async Task<string> EnviarFacturaAsync(object factura)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {_token}");

                var json = JsonConvert.SerializeObject(factura);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PostAsync($"{_baseUrl}/invoices", content);

                response.EnsureSuccessStatusCode();

                return await response.Content.ReadAsStringAsync();
            }
        }
    }
}
