using PrettyFaceApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PrettyFaceApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        HomePageViewModel vm;

        public HomePage()
        {
            InitializeComponent();
            BindingContext = vm = new HomePageViewModel();

            Device.StartTimer(new TimeSpan(0, 0, 5), () => { carouselView1.ScrollTo(indicator1.Position == indicator1.Count - 1 ? 0 : indicator1.Position + 1); return true; });
        }

        async protected override void OnAppearing()
        {
            base.OnAppearing();

            double offset = 1150;
            int elementIndex = 0;
            foreach (View view in stackLayout1.Children) // Animate each element inside StackLayout
            {
                view.TranslationX = offset;offset *= -1;
                //if (elementIndex>=2)  // Making each element come from different sides. Except for the first two so they come from the same side (in this case the CarouselView and the IndicatorView
                elementIndex++;
            }

            foreach (View view in stackLayout1.Children)
            {
                await Task.WhenAny(view.TranslateTo(0, 0, 2000, Easing.SpringOut), Task.Delay(100));
            }
        }

        private async void ShowOrHideMenu(object sender, EventArgs e)
        {
            if (vm.MenuInvisible)
            {
                vm.MenuInvisible = false;
                await pancakeViewMenu.TranslateTo(0, 0, 400, Easing.SinIn);
            }
            else
            {
                vm.MenuInvisible = true;
                await pancakeViewMenu.TranslateTo(0, 350, 550, Easing.SinOut);
            }
        }

        private async void LateralMenu1_Tapped(object sender, EventArgs e)
        {
            await AnimateLateralMenu((StackLayout)sender);
        }

        private async void LateralMenu2_Tapped(object sender, EventArgs e)
        {
            await AnimateLateralMenu((StackLayout)sender);
        }

        private async void LateralMenu3_Tapped(object sender, EventArgs e)
        {
            await AnimateLateralMenu((StackLayout) sender);
            Application.Current.MainPage = new AppShell();
        }

        private async void LateralMenu4_Tapped(object sender, EventArgs e)
        {
            await AnimateLateralMenu((StackLayout)sender);
        }

        private async Task AnimateLateralMenu(StackLayout sl)
        {
            await sl.ScaleTo(1.1, 20, Easing.Linear);
            await sl.ScaleTo(1, 10, Easing.Linear);
        }
    }
}