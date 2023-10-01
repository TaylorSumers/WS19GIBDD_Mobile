using GIBDD_Mobile.Entities;
using System;
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
            BindingContext = accident;
            accident.Participants.Add(new AccidentParticipant
            {
                Name = "Test",
                Surname = "Test",
                Patronymic = "Test",
                LicenseNum = "Test"
            });
            lwParticipants.ItemsSource = accident.Participants;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            lwParticipants.ItemsSource = null;
            lwParticipants.ItemsSource = accident.Participants;

            lwVehicles.ItemsSource = null;
            lwVehicles.ItemsSource = accident.Vehicles;
        }

        private void btnNext_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(accident.Type) ||
                accident.ParticipantsAmount == 0 ||
                string.IsNullOrWhiteSpace(accident.Place?.Street) ||
                accident.Vehicles.Count == 0)
            {
                DisplayAlert("Ошибка", "Не все обязательные поля заполнены", "ОК");
                return;
            }

            accident.Date = dpAccidentDate.Date + tpAccidentTime.Time;
            Navigation.PushAsync(new Step2(accident));
        }

        private void btnAddParticipant_Clicked(object sender, EventArgs e) => Navigation.PushAsync(new ParticipantAddingPage());

        private void btnAddCar_Clicked(object sender, EventArgs e) => Navigation.PushAsync(new CarAddingPage());
    }
}