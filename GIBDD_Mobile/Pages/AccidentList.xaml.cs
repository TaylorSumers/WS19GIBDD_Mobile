using GIBDD_Mobile.Entities;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GIBDD_Mobile.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AccidentList : ContentPage
	{
		public AccidentList()
		{
			InitializeComponent();
			for(int i = 0; i < 15;  i++)
			{
                DbContext.Accidents.Add(new Accident
                {
                    ID = 1,
                    Date = DateTime.Now,
                    Type = "Столкновение",
					Victims = i
                });
            }
			lwAccidents.ItemsSource = DbContext.Accidents;
		}

        private void lwAccidents_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
			if(e.SelectedItem != null)
				Navigation.PushAsync(new AccidentInfoPage(lwAccidents.SelectedItem as Accident));
			((ListView)sender).SelectedItem = null;
        }

        private void btnAddAccident_Clicked(object sender, EventArgs e)
        {
			Navigation.PushAsync(new AccidentConstructorPages.Step1());
        } 
        protected override void OnAppearing()
        {
            base.OnAppearing();

            lwAccidents.ItemsSource = null;
            lwAccidents.ItemsSource = DbContext.Accidents;
        }
    }
}