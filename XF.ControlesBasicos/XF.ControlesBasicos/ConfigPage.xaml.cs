using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF.ControlesBasicos
{
	public partial class ConfigPage : ContentPage
	{
        private MainPage parent;

		public ConfigPage (MainPage parent)
		{
			InitializeComponent();
            this.parent = parent;
            emailSwitch.On = parent.isEmailAuthorized;
            emailEntry.Text = parent.email;
        }

        private void SwitchCell_OnChanged(object sender, EventArgs e)
        {
            emailEntry.IsEnabled = emailSwitch.On;
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            this.parent.email = emailEntry.Text;
            this.parent.isEmailAuthorized = emailSwitch.On;
        }

    }
}