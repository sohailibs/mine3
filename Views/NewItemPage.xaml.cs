using System;
using System.Collections.Generic;
using System.ComponentModel;
using UsageStatsApp.Models;
using UsageStatsApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UsageStatsApp.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}