using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_l
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataL : ContentPage
	{
		public KataL ()
		{
			InitializeComponent ();
		}
        
        // Te he hecho arriba y abajo también por probar :D

        private void swipeLeftScreen(object sender, EventArgs e)
        {
            labelTextChanged.Text = "Se ha deslizado a la Izquierda";
        }
        private void swipeRightScreen(object sender, EventArgs e)
        {
            labelTextChanged.Text = "Se ha deslizado a la Derecha";
        }
        private void swipeUpScreen(object sender, EventArgs e)
        {
            labelTextChanged.Text = "Se ha deslizado hacia Arriba";
        }
        private void swipeDownScreen(object sender, EventArgs e)
        {
            labelTextChanged.Text = "Se ha deslizado a la Abajo";
        }
        private void tapInScreen(object sender, EventArgs e)
        {
            labelTextChanged.Text = "Se ha hecho un Tap";
        }
        private void pinchInScreen(object sender, EventArgs e)
        {
            labelTextChanged.Text = "Se ha Pellizcado la pantalla";
        }
    }
}