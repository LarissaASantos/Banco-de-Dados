using App1;
using System;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using XF_CollectinViewBasico.ViewModels;

namespace XF_CollectinViewBasico
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public ICommand TapCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }
        private void PressMeButton_Pressed(object sender, System.EventArgs e)
        {
            (sender as Button).Text = "Você gostou!";
        }

        private void PressMeButton_Clicked(object sender, EventArgs e)
        {
            (sender as Button).Text = "Obrigada!";
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
        }
        private void ButtonTapped(object sender, SelectionChangedEventArgs e)
        {
            Button selectedButton = e.CurrentSelection.FirstOrDefault() as Button;

            UpdateConstantsWithSelectedButton(selectedButton).Wait();
            var buttonPage = new MainPage();
            Navigation.PushAsync(buttonPage);
        }

        private async Task UpdateConstantsWithSelectedButton(Button selectedButton)
        {
            Constants.SelectedButton = selectedButton;

        }
    }
}
