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
        private readonly DataStoreChallenges _dataStoreChanlenges;

        public GamificationViewModel()
        {
            _dataStoreChanlenges = new DataStoreChallenges();
            LoadChallengesAsync();
        }


        public ObservableCollection<Challenge> ChallengeCollection { get; set; }

        public void LoadChallengesAsync()
        {
            try
            {
                var challenges = _dataStoreChanlenges.GetChallengesAsync();
                ChallengeCollection = new ObservableCollection<Challenge>(challenges);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }

}
