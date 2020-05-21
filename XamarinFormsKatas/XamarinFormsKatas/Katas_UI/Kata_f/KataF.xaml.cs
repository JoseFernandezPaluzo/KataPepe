using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormsKatas.Katas_UI.Kata_d;

namespace XamarinFormsKatas.Katas_UI.Kata_f
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataF : ContentPage
	{
        private List<Persona> people = new List<Persona>();
        public KataF ()
		{
			InitializeComponent ();
            BindingContext = people;
        }

        private async void OnItemSelected(object sender, ItemTappedEventArgs e)
        {
            var p = e.Item as Persona;
            await Navigation.PushAsync(new Katas_UI.Kata_e.KataE(p)); 
        }

        protected override void OnAppearing()
        {
            people.Add(new Persona() { Nombre = "Juan", Edad = 19 }); 
            people.Add(new Persona() { Nombre = "Pepe", Edad = 20 });
            people.Add(new Persona() { Nombre = "Pedro", Edad = 22 });
            people.Add(new Persona() { Nombre = "Tomás", Edad = 19 });

            PersonList.ItemsSource = people;

            base.OnAppearing();
        }
        private void SearchButtonPressed(object sender, TextChangedEventArgs e)
        {
            var countriesSearched = people.Where(x => x.Nombre.ToUpper().Contains(FilterSearchBar.Text.ToUpper()));
            PersonList.ItemsSource = countriesSearched;
        }
    }
}