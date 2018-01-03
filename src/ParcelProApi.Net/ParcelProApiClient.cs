using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ParcelProApi.Net.Helpers;
using ParcelProApi.Net.Models;

namespace ParcelProApi.Net
{
    public class ParcelProApiClient
    {
        private const string ApiBaseUrl = "http://login.parcelpro.nl/api/";
        private readonly HttpClient _httpClient;
        private readonly int _loginId;
        private readonly string _apiKey;

        /// <summary>
        /// Instantiates a new ParcelProApiClient
        /// </summary>
        /// <param name="loginId"></param>
        /// <param name="apiKey">API key which can be generated on myparcel.nl</param>
        public ParcelProApiClient(int loginId, string apiKey)
        {
            if (string.IsNullOrWhiteSpace(apiKey))
                throw new ArgumentException("Parameter apiKey needs a value");

            _loginId = loginId;
            _apiKey = apiKey;

            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(ApiBaseUrl)
            };
        }

        public async Task<ApiKey> ValidateApiKey()
        {
            var currentTime = GetCurrentTime();
            var hash = CreateHash(_loginId + currentTime, _apiKey);

            var urlBuilder = new StringBuilder("validate_apikey.php");
            var parameters = new Dictionary<string, string>
            {
                {"GebruikerId", _loginId.ToString()},
                {"Datum", currentTime},
                {"HmacSha256", hash}
            };
            urlBuilder.Append(GetQueryString(parameters));
            var response = await _httpClient.GetAsync(urlBuilder.ToString()).ConfigureAwait(false);
            var jsonResult = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return JsonHelper.Deserialize<ApiKey>(jsonResult);
            }
            var error = JsonHelper.Deserialize<Error>(jsonResult);
            throw new Exception(error.Message);
        }

        public async Task<ShipmentType[]> GetShipmentTypes()
        {
            var currentTime = GetCurrentTime();
            var hash = CreateHash(_loginId + currentTime, _apiKey);

            var urlBuilder = new StringBuilder("type.php");
            var parameters = new Dictionary<string, string>
            {
                {"GebruikerId", _loginId.ToString()},
                {"Datum", currentTime},
                {"HmacSha256", hash}
            };
            urlBuilder.Append(GetQueryString(parameters));
            var response = await _httpClient.GetAsync(urlBuilder.ToString()).ConfigureAwait(false);
            var jsonResult = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return JsonHelper.Deserialize<ShipmentType[]>(jsonResult);
            }
            var error = JsonHelper.Deserialize<Error>(jsonResult);
            throw new Exception(error.Message);
        }

        public async Task<PickupLocation[]> GetPickupLocations(string zipCode, string number, string street = "", Carrier? carrier = Carrier.PostNL)
        {
            var currentTime = GetCurrentTime();
            var hash = CreateHash(_loginId + currentTime + zipCode + number + street, _apiKey);

            var urlBuilder = new StringBuilder("uitreiklocatie.php");
            var parameters = new Dictionary<string, string>
            {
                {"GebruikerId", _loginId.ToString()},
                {"Datum", currentTime},
                {"HmacSha256", hash},
                {"Postcode", zipCode},
                {"Nummer", number},
            };
            if (!string.IsNullOrEmpty(street))
                parameters["Straat"] = street;
            if (carrier != null)
                parameters["Carrier"] = carrier.ToString();
            urlBuilder.Append(GetQueryString(parameters));
            var response = await _httpClient.GetAsync(urlBuilder.ToString()).ConfigureAwait(false);
            var jsonResult = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return JsonHelper.Deserialize<PickupLocation[]>(jsonResult);
            }
            var error = JsonHelper.Deserialize<Error>(jsonResult);
            throw new Exception(error.Message);
        }

        public async Task<ShipmentResponse> PostShipment(ShipmentRequest shipment)
        {
            var currentTime = GetCurrentTime();
            var hash = CreateHash(_loginId + currentTime + shipment.SenderPostalcode + shipment.RecipientPostalcode, _apiKey);

            shipment.LoginId = _loginId;
            shipment.Date = currentTime;
            shipment.HmacSha256 = hash;

            var content = new StringContent(JsonHelper.Serialize(shipment));
            var response = await _httpClient.PostAsync("zending.php", content).ConfigureAwait(false);
            var jsonResult = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return JsonHelper.Deserialize<ShipmentResponse>(jsonResult);
            }
            var error = JsonHelper.Deserialize<Error>(jsonResult);
            throw new Exception(error.Message);
        }

        public async Task<Stream> GetShipmentLabel(int shipmentId, bool printPdf = true)
        {
            var gebruikerId = _loginId;
            var hash = CreateHash(gebruikerId + shipmentId.ToString(), _apiKey);

            var urlBuilder = new StringBuilder("label.php");
            var parameters = new Dictionary<string, string>
            {
                {"GebruikerId", gebruikerId.ToString()},
                {"ZendingId", shipmentId.ToString()},
                {"HmacSha256", hash}
            };
            if (printPdf)
                parameters["PrintPdf"] = "true";
            urlBuilder.Append(GetQueryString(parameters));
            var response = await _httpClient.GetAsync(urlBuilder.ToString()).ConfigureAwait(false);
            var stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
            var jsonResult = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return stream;
            }
            var error = JsonHelper.Deserialize<Error>(jsonResult);
            throw new Exception(error.Message);
        }

        public async Task<Subscription> PostSubscription(Subscription subscription)
        {
            var currentTime = GetCurrentTime();
            var hash = CreateHash(_loginId + currentTime, _apiKey);

            subscription.LoginId = _loginId;
            subscription.Date = currentTime;
            subscription.HmacSha256 = hash;

            var content = new StringContent(JsonHelper.Serialize(subscription));
            var response = await _httpClient.PostAsync("triggers.php", content).ConfigureAwait(false);
            var jsonResult = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return JsonHelper.Deserialize<Subscription>(jsonResult);
            }
            var error = JsonHelper.Deserialize<Error>(jsonResult);
            throw new Exception(error.Message);
        }

        private string GetCurrentTime()
        {
            return DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private string GetQueryString(Dictionary<string, string> parameters)
        {
            var queryString = string.Join("&",
                parameters.Select(
                    p =>
                        string.IsNullOrEmpty(p.Value)
                            ? Uri.EscapeDataString(p.Key)
                            : $"{Uri.EscapeDataString(p.Key)}={Uri.EscapeDataString(p.Value)}"));
            return !string.IsNullOrWhiteSpace(queryString) ? "?" + queryString : string.Empty;
        }

        private string CreateHash(string message, string key)
        {
            var encoding = Encoding.UTF8;
            var keyByte = encoding.GetBytes(key);
            using (var hmacsha256 = new HMACSHA256(keyByte))
            {
                byte[] buff = hmacsha256.ComputeHash(encoding.GetBytes(message));
                string sbinary = "";
                for (int i = 0; i < buff.Length; i++)
                    sbinary += buff[i].ToString("x2"); /* hex format */
                return sbinary;
            }
        }
    }
}
