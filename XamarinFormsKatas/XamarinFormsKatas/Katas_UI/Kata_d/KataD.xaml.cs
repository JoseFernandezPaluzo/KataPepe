using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_d
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataD : ContentPage
	{
        private List<Persona> people = new List<Persona>();
        public KataD()
        {
            InitializeComponent();
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
    }
}