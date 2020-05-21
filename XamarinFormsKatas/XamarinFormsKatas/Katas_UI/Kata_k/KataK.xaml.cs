using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_k
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataK : ContentPage
	{
        List<Persona> people = new List<Persona>();
		public KataK ()
		{
			InitializeComponent ();
		}        
        
        protected override void OnAppearing()
        {
            people.Add(new Persona() { Nombre = "Juan", Edad = 19 });
            people.Add(new Persona() { Nombre = "Pepe", Edad = 20 });
            people.Add(new Persona() { Nombre = "Pedro", Edad = 22 });
            people.Add(new Persona() { Nombre = "Tomás", Edad = 19 });

            PullRefreshList.ItemsSource = people;

            PullRefreshList.RefreshCommand = new Command(() =>
            {
                PullRefreshList.IsRefreshing = true;                
                PullRefreshList.IsRefreshing = false;
            });            

            base.OnAppearing();
        }
    }
}