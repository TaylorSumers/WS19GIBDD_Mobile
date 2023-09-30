using GIBDD_Mobile.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GIBDD_Mobile
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnEnter_Clicked(object sender, EventArgs e)
        {
            if (entLogin.Text == "inspector" && entPassword.Text == "inspector")
            {
                entPassword.Text = string.Empty;
                Navigation.PushAsync(new AccidentList());
            }
            else
                DisplayAlert("Ошибка", "Неверно введены данные", "ОК");
        }
    }
}
