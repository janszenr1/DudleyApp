using System;
using DudleyApp.Services;
using DudleyApp.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DudleyApp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
