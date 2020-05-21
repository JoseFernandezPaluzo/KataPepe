using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_m
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataM : ContentPage
	{
        public KataM()
		{
			InitializeComponent ();
		}

        private void LabelAdd(object sender, EventArgs e)
        {
            Label label = new Label();
            label.Text = "Soy un label";
            label.FontSize = 28;
            label.HorizontalOptions = LayoutOptions.CenterAndExpand; 

            stack.Children.Add(label);
        }
    }
}