using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Login
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (Application.Current.Properties.ContainsKey("user"))
            {
                ShowWindowWelcome();
            }
        }

        private void ClickButtonSignIn(object sender, EventArgs e)
        {
            if (entryUser.Text == "jonmid" && entryPass.Text == "123")
            {
                Application.Current.Properties["user"] = entryUser.Text;
                ShowWindowWelcome();
            }
            else
            {
                DisplayAlert("Error", "El usuario no existe", "OK");
            }
        }

        async private void ShowWindowWelcome()
        {
            await Navigation.PushModalAsync(new Welcome());
        }
    }
}
