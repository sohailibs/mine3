using System;
using UsageStatsApp.Services;
using UsageStatsApp.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UsageStatsApp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            //  MainPage = new AppShell();
            MainPage = new TestPage();
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
