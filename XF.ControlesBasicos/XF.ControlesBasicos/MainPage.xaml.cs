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
		public MainPage()
		{
			InitializeComponent();
		}

        private void Send_Clicked(object sender, EventArgs e)
        {
            (sender as Button).Text = "I was just clicked!";
        }

        private void Config_Clicked(object sender, EventArgs e)
        {
            (sender as Button).Text = "I was just clicked!";
        }
    }
}
