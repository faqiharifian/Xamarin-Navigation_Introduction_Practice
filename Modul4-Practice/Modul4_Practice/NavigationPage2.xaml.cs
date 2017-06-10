using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Modul4_Practice
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NavigationPage2 : ContentPage
	{
		public NavigationPage2 ()
		{
			InitializeComponent ();

            btnBack.Clicked += async (sender, e) =>
            {
                await Navigation.PopAsync(true);
            };
		}
	}
}