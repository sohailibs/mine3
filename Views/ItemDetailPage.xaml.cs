using System.ComponentModel;
using UsageStatsApp.ViewModels;
using Xamarin.Forms;

namespace UsageStatsApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}