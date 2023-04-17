using Horus.Models;
using Horus.Services.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Horus.Services
{
    public class DataStoreLogin : ILogin
    {
        private readonly HttpClient _httpClient;
        public DataStoreLogin()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri($"{App.APIUrl}")
            };
        }

        public async Task<LoginResponse> Login(User user)
        {
            try
            {
                var serializedItem = JsonConvert.SerializeObject(user);
                var response = await _httpClient.PostAsync("UserSignIn", new StringContent(serializedItem, Encoding.UTF8, "application/json"));
                var json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<LoginResponse>(json);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
