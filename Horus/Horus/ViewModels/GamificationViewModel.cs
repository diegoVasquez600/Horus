using Horus.Models;
using Horus.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Horus.ViewModels
{
    public class GamificationViewModel : BaseViewModel
    {
        private DataStoreChallenges _dataStoreChanlenges = new DataStoreChallenges();

        public GamificationViewModel()
        {
            _dataStoreChanlenges = new DataStoreChallenges();
        }


        public ObservableCollection<Challenge> ChallengeCollection { get; set; }

    }

}
