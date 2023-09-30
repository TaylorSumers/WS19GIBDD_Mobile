using GIBDD_Mobile.Entities;
using GIBDD_Mobile.Pages.AccidentConstructorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GIBDD_Mobile.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CarAddingPage : ContentPage
	{
		private Vehicle _vehicle;

		public CarAddingPage()
		{
			InitializeComponent();
			_vehicle = new Vehicle();
			BindingContext = _vehicle;
		}

        private void btnSave_Clicked(object sender, EventArgs e)
        {
			Step1.accident.Vehicles.Add(_vehicle);
			Navigation.PopAsync();
        }
    }
}