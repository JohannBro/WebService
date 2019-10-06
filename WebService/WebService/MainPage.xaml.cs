using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebService.bo;
using WebService.services;
using Xamarin.Forms;

namespace WebService
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        ChuckServiceRest chuckService = new ChuckServiceRest();
        
        public MainPage()
        {
            InitializeComponent();
            ChargerBlagues();


        }

        public async void ChargerBlagues()
        {
            //listBlagues.ItemsSource = await chuckService.GetJokes();
            listBlagues.ItemsSource = new ObservableCollection<Joke>(await chuckService.GetJokes());
        }

        
    }
}
