using Horus.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Horus.Services
{
    public class DataStoreChallenges
    {
        private readonly HttpClient _httpClient;
        
        public DataStoreChallenges()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri($"{App.APIUrl}"),
            };
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"{App.LoggedUser.AuthorizationToken}");
        }

        public async Task<IEnumerable<Challenge>> GetChallengesAsync()
        {
            try
            {
                var response = await _httpClient.GetStringAsync("Challenges");
                var challenges = JsonConvert.DeserializeObject<List<Challenge>>(response);
                return challenges;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
