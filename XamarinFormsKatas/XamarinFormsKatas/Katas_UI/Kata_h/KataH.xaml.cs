using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_h
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataH : ContentPage
	{
		public KataH ()
		{
			InitializeComponent ();
		}
        private async void OnStartAnimationButtonClicked(object sender, EventArgs e) //No se me mostraba la animación en el móvil.
        {
            await buttonWithAnimation.TranslateTo(0,-100); //Se desplaza pero no se gira el botón.
            await buttonWithAnimation.RotateTo(360, 350);
            //buttonWithAnimation.Rotation = 0;
        }
    }
}