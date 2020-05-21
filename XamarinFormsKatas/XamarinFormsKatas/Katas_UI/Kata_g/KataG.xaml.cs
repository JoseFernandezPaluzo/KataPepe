using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_g
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataG : ContentPage
	{
		public KataG ()
		{
			InitializeComponent ();
		}

        private async void OnStartAnimationButtonClicked(object sender, EventArgs e) //No se me mostraba la animación en el móvil.
        {            
            await buttonWithAnimation.RotateTo(360, 350);
            //buttonWithAnimation.Rotation = 0;
        }
    }
}   