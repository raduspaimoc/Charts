using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var hybridWebView = new HybridWebView
            {
                Uri = "index.html",
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand
            };
            //hybridWebView.RegisterAction(data => DisplayAlert("Alert", "Hello " + data, "OK"));
            Padding = new Thickness(0, 20, 0, 0);
            Content = hybridWebView;
        }    
    }
}
