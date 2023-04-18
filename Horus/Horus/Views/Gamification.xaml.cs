using Horus.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Horus.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Gamification : ContentPage
    {
        public Gamification()
        {
            InitializeComponent();
           // BindingContext = new GamificationViewModel();
        }
    }
}