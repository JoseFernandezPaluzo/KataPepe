using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormsKatas.Katas_UI.Kata_r.Modelos;

namespace XamarinFormsKatas.Katas_UI.Kata_r
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataR : ContentPage
	{
        private List<ClienteProveedor> clpr = new List<ClienteProveedor>();

		public KataR ()
		{
			InitializeComponent ();
            BindingContext = clpr;
		}
        
        protected override void OnAppearing()
        {
            clpr.Add(new Cliente() { Nombre = "Juan", DNI = "30281932J" });
            clpr.Add(new Cliente() { Nombre = "Marcos", DNI = "30454321M" });
            clpr.Add(new Cliente() { Nombre = "Alberto", DNI = "30212345A" });

            clpr.Add(new Proveedor() { Nombre = "IKEA", Producto = "Mesas" });
            clpr.Add(new Proveedor() { Nombre = "MERCADONA", Producto = "Yogurt" });
            clpr.Add(new Proveedor() { Nombre = "CASH FRESH", Producto = "Hielos" });

            ShopManageList.ItemsSource = clpr.ToString();

            base.OnAppearing();
        }
    }
}