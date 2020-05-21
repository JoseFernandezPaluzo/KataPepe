using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_b
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataB : ContentPage
	{
		public KataB ()
		{
			InitializeComponent ();            
        }

        private void RoundedButton_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Kata_a.KataA());
        }
    }
}