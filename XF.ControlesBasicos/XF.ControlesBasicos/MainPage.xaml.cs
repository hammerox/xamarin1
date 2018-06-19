using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XF.ControlesBasicos
{
	public partial class MainPage : ContentPage
	{
        public String email;
        public Boolean isEmailAuthorized = true;

		public MainPage()
		{
			InitializeComponent();
		}

        private void Send_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                DisplayAlert("Atenção", "Email não configurado", "OK");
            }
            else if (isEmailAuthorized == false)
            {
                DisplayAlert("Atenção", "Email não autorizado", "OK");
            }
            else
            {
                DisplayAlert("Sucesso", string.Format("Email enviado para {0}", email), "OK");
            }
                
        }

        private async void Config_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ConfigPage(this));
        }
    }
}
