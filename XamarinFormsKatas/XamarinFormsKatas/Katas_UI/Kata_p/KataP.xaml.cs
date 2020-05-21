using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_p
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataP : ContentPage
	{
		public KataP ()
		{
			InitializeComponent ();
            ActivityIndicator();
		}
        protected override void OnAppearing()
        { 
            base.OnAppearing();
        }
        private async void ActivityIndicator()
        {
            stackPanel.IsEnabled = false;
            await Task.Delay(5000);
            activityIndicator.IsRunning = false;
            activityIndicator.IsVisible = false;
            stackPanel.IsEnabled = true;
        }
    }
}