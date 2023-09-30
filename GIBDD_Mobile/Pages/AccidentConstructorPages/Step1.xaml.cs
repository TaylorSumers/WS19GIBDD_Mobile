using GIBDD_Mobile.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GIBDD_Mobile.Pages.AccidentConstructorPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Step1 : ContentPage
    {
        public static Accident accident;

        public Step1()
        {
            InitializeComponent();
            accident = new Accident();
            accident.Participants.Add(new AccidentParticipant
            {
                Name = "Test",
                Surname = "Test",
                Patronymic = "Test",
                LicenseNum = "Test"
            });
            lwParticipants.ItemsSource = accident.Participants;
        }

        private void btnNext_Clicked(object sender, EventArgs e)
        {
            // TODO: Проверки
            Navigation.PushAsync(new Step2(accident));
        }

        private void btnAddParticipant_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ParticipantAddingPage());
        }

        private void btnAddCar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CarAddingPage());
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            lwParticipants.ItemsSource = null;
            lwParticipants.ItemsSource = accident.Participants;

            lwVehicles.ItemsSource = null;
            lwVehicles.ItemsSource = accident.Vehicles;
        }
    }
}