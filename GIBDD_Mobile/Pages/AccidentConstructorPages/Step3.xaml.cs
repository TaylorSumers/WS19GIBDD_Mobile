using GIBDD_Mobile.Entities;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GIBDD_Mobile.Pages.AccidentConstructorPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Step3 : ContentPage
    {
        private Accident _accident;

        public Step3(Accident accident)
        {
            InitializeComponent();
            _accident = accident;
        }

        private void btnNext_Clicked(object sender, EventArgs e)
        {
            // TODO: Проверки
            DbContext.Accidents.Add(_accident);
            DisplayAlert("Успешно", "Информация о ДТП сохранена", "ОК");
            for(int i = 0; i < 3; i++) 
                Navigation.PopAsync();
        }
    }
}