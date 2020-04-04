using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PrettyFaceApp.Services;
using PrettyFaceApp.Views;

namespace PrettyFaceApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Device.SetFlags(new[] { "CarouselView_Experimental", "IndicatorView_Experimental" });
            DependencyService.Register<MockDataStore>();
            //MainPage = new AppShell();
            MainPage = new HomePage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
