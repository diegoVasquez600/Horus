using Horus.Models;
using Horus.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace Horus.ViewModels
{
    public class GamificationViewModel : BaseViewModel
    {
        private readonly DataStoreChallenges _dataStoreChallenges;

        public GamificationViewModel()
        {
            _dataStoreChallenges = new DataStoreChallenges();
            LoadChallengesAsync();
        }


        public ObservableCollection<Challenge> ChallengeCollection { get; set; }
        public int CompletedChallenges { get; set; }
        public int TotalChallenges { get; set; }

        public async void LoadChallengesAsync()
        {
            try
            {
                int completedChallenges = 0;
                int totalChallenges = 0;
                var challenges = await _dataStoreChallenges.GetChallengesAsync();
                ChallengeCollection = new ObservableCollection<Challenge>();
                foreach (var item in challenges)
                {
                    ChallengeCollection.Add(item);
                    if (item.Porcentage == 100) // check if challenge is completed
                    {
                        completedChallenges++;
                    }
                    totalChallenges++;
                }
                CompletedChallenges = completedChallenges;
                TotalChallenges = totalChallenges;
                OnPropertyChanged(nameof(CompletedChallenges));
                OnPropertyChanged(nameof(ChallengeCollection));
                OnPropertyChanged(nameof(TotalChallenges));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }

}
