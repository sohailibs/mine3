using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsageStatsApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UsageStatsApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TestPage : ContentPage
    {
        public TestPage()
        {
            InitializeComponent();
        }
        private readonly List<Microcharts.Entry> _entries = new List<Microcharts.Entry>()
        {
            new Microcharts.Entry(200)
            {
                Label = "January",
                ValueLabel = "200",
                Color = SKColor.Parse("#FF0033"),
            },
            new Microcharts.Entry(400)
            {
                Label = "February",
                ValueLabel = "400",
                Color = SKColor.Parse("#FF8000"),
            },
            new Microcharts.Entry(300)
            {
                Label = "March",
                ValueLabel = "300",
                Color = SKColor.Parse("#FFE600"),
            },
            new Microcharts.Entry(250)
            {
                Label = "April",
                ValueLabel = "250",
                Color = SKColor.Parse("#1AB34D"),
            },
            new Microcharts.Entry(650)
            {
                Label = "May",
                ValueLabel = "650",
                Color = SKColor.Parse("#1A66FF"),
            },
            new Microcharts.Entry(500)
            {
                Label = "June",
                ValueLabel = "500",
                Color = SKColor.Parse("#801AB3"),
            },
        };
        private async void btn1_Clicked(object sender, EventArgs e)
        {
            emptyLoader.IsVisible = true;
            stkList.IsVisible = false;
            //await Task.Delay(2000);
            var strlist = await DependencyService.Get<IUsageStatcs>().GetUsagePackages();
            if (strlist.Count > 0)
            {
                stkList.IsVisible = true;
                BindableLayout.SetItemsSource(stkList, strlist);
            }
            else
            {
                stkList.IsVisible = false;
            }
            emptyLoader.IsVisible = false;
        }
        private void GetPackageStats()
        {
            DependencyService.Get<IUsageStatcs>().GetUsagePackages();
        }

        private void btn2_Clicked(object sender, EventArgs e)
        {
            DependencyService.Get<IUsageStatcs>().UsageAccessPermission();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                var btn = ((Button)sender).CommandParameter;
                var obj = (PackageInf)btn;
                string appname = obj.PackageName;
                await DependencyService.Get<IOpenApp>().LaunchApp(appname);
            }
            catch (Exception ex)
            {

         
            }
            
        }

        private void loadCharts()
        {
            //SfChart chart = new SfChart()
            //{
            //    HorizontalOptions = LayoutOptions.FillAndExpand,
            //    VerticalOptions = LayoutOptions.FillAndExpand,
            //    HeightRequest = 100,
            //    BackgroundColor = Color.FromHex("#fff")
            //};

            //ChartLegend legend = new ChartLegend();
            //legend.StrokeWidth = 2;
            //legend.Margin = new Thickness(5);
            //legend.CornerRadius = new ChartCornerRadius(5);
            //legend.StrokeDashArray = new double[] { 3, 3 };
            //legend.DockPosition = LegendPlacement.Bottom;
            //legend.OverflowMode = ChartLegendOverflowMode.Wrap;
            //legend.BackgroundColor = Color.FromHex("#fff");
            //chart.Legend = legend;

            //chart.Title.TextAlignment = TextAlignment.Center;
            //chart.PrimaryAxis = new CategoryAxis();
            //chart.SecondaryAxis = new NumericalAxis();
            //chart.SecondaryAxis.LabelStyle.LabelFormat = "0'%'";
            //int i = 0;
            //foreach (var item in graphModels)
            //{
            //    var personDataTemplate = new DataTemplate(() =>
            //    {
            //        //var nameLabel = new Label { Text = item.Store, TextColor = Color.Black };
            //        var valueLabel = new Label() { Text = item.amount.ToString("n"), FontSize = 12, TextColor = Color.Black };
            //        StackLayout stk1 = new StackLayout
            //        {
            //            Orientation = StackOrientation.Horizontal,
            //            Children = { 
            //                //nameLabel, 
            //                valueLabel
            //            },
            //            BackgroundColor = Color.FromHex("#fff"),
            //            Padding = 5
            //        };
            //        return new ViewCell { View = stk1 };
            //    });
            //    ObservableCollection<Model> dataPoints = new ObservableCollection<Model>();
            //    dataPoints.Add(new Model("", item.amount));
            //    StackingBar100Series bar = new StackingBar100Series();
            //    bar.ItemsSource = dataPoints;
            //    bar.TooltipTemplate = personDataTemplate;
            //    bar.XBindingPath = "Month";
            //    bar.Label = item.storeName;
            //    bar.YBindingPath = "Target";
            //    bar.EnableAnimation = true;
            //    bar.EnableTooltip = false;
            //    bar.Spacing = 0.4;
            //    bar.DataMarkerPosition = DataMarkerPosition.Bottom;
            //    bar.Color = Color.FromHex(colors[i]);
            //    chart.Series.Add(bar);
            //    i++;
            //}
            //ChartTooltipBehavior chartTooltipBehavior = new ChartTooltipBehavior();
            //chartTooltipBehavior.FontSize = 12;
            //chartTooltipBehavior.TextColor = Color.Black;
            //chartTooltipBehavior.Duration = 10;
            //chartTooltipBehavior.Margin = 1;
            //chartTooltipBehavior.BorderWidth = 1;

            //chart.ChartBehaviors.Add(chartTooltipBehavior);
            //if (Device.RuntimePlatform == Device.iOS)
            //{
            //    chart.ChartPadding = new Thickness(0, 5, 15, 0);
            //    chart.Margin = new Thickness(5, 10, 10, 0);
            //    chartTooltipBehavior.OffsetY = -8;
            //}
            //else
            //{
            //    chart.ChartPadding = new Thickness(0, 35, 35, 15);
              //}

        }
    }
}