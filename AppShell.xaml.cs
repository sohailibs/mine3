using System;
using System.Collections.Generic;
using UsageStatsApp.ViewModels;
using UsageStatsApp.Views;
using Xamarin.Forms;

namespace UsageStatsApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
