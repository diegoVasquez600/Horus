using Horus.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
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
                Timeout = Timeout.InfiniteTimeSpan
            };
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"{App.LoggedUser.AuthorizationToken}");
        }

        public async Task<List<Challenge>> GetChallengesAsync()
        {
            try
            {
                var response = await _httpClient.GetStringAsync("Challenges");
                var challenges = JsonConvert.DeserializeObject<List<Challenge>>(response);
                return challenges;
                //return new List<Challenge>()
                //{
                //    new Challenge()
                //    {
                //        Id = "1",
                //        Title = "Invitar Amigos II",
                //        Description = "Invita a 10 amigos a participar en el proyecto para que compartan sus looks.",
                //        CurrentPoints = 47,
                //        TotalPoints = 50,
                //    },
                //    new Challenge()
                //    {
                //        Id = "2",
                //        Title = "Experta en Looks",
                //        Description = "Publica 50 looks y convertite en experta.",
                //        CurrentPoints = 10,
                //        TotalPoints = 10,
                //    }
                //};
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
