using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormsKatas.Katas_UI.Kata_d;

namespace XamarinFormsKatas.Katas_UI.Kata_e
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataE : ContentPage
	{
        private Persona p = new Persona();

		public KataE (Persona p)
		{
			InitializeComponent ();
            this.p = p;
            BindingContext = p;
		}

        protected override void OnAppearing()
        {
            
            base.OnAppearing();
        }
    }
}