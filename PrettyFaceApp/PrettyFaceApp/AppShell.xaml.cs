using PrettyFaceApp.Views;
using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PrettyFaceApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }

        private void HomePageMenuItem_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new HomePage();
        }
    }
}
