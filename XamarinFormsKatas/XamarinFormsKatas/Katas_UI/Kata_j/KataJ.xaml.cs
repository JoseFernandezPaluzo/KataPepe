using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormsKatas.Katas_UI.Kata_j;

namespace XamarinFormsKatas.Katas_UI.Kata_j
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataJ : ContentPage
	{
		public KataJ ()
		{
			InitializeComponent ();
            BindingContext = new LoginViewModel();
        }
	}
}