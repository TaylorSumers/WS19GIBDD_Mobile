using GIBDD_Mobile.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static Xamarin.Essentials.Permissions;

namespace GIBDD_Mobile.Pages.AccidentConstructorPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Step2 : ContentPage
    {
        private Accident _accident;

        public Step2(Accident accident)
        {
            InitializeComponent();
            _accident = accident;
        }

        private void btnNext_Clicked(object sender, EventArgs e)
        {
            // TODO: Проверки
            Navigation.PushAsync(new Step3(_accident));
        }

        private async void btnTakePhoto_Clicked(object sender, EventArgs e)
        {
            //var photo = await MediaPicker.CapturePhotoAsync(new MediaPickerOptions
            //{
            //    Title = $"accident.{DateTime.Now}.png"
            //});

            //var newFile = Path.Combine(FileSystem.AppDataDirectory, photo.FileName);
            //using (var readStream = await photo.OpenReadAsync())
            //{
            //    using (var writeStream = File.OpenWrite(newFile))
            //    {
            //        await readStream.CopyToAsync(writeStream);
            //    }
            //}

            //var displayImg = new Image
            //{
            //    HeightRequest = 50,
            //    WidthRequest = 50,
            //    Source = ImageSource.FromFile(newFile)
            //};

            //flPhotos.Children.Add(displayImg);
        }
    }
}