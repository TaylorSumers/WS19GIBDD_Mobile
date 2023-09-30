using GIBDD_Mobile.Entities;
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
    public partial class AccidentInfoPage : ContentPage
    {
        private Accident _accident;

        public AccidentInfoPage(Accident accident)
        {
            InitializeComponent();
            _accident = accident;
        }
    }
}