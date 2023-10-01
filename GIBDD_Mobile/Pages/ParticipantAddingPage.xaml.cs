using GIBDD_Mobile.Entities;
using GIBDD_Mobile.Pages.AccidentConstructorPages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GIBDD_Mobile.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ParticipantAddingPage : ContentPage
	{
		private AccidentParticipant _participant;

		public ParticipantAddingPage ()
		{
			InitializeComponent();
			_participant = new AccidentParticipant();
			BindingContext = _participant;
		}

        private void btnSave_Clicked(object sender, EventArgs e)
        {
            Step1.accident.Participants.Add(_participant);
			Navigation.PopAsync();
        }
    }
}