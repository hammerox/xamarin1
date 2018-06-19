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
		public ConfigPage ()
		{
			InitializeComponent();
        }

        private void SwitchCell_OnChanged(object sender, EventArgs e)
        {
            var switchCell = sender as SwitchCell;
            emailEntry.IsEnabled = switchCell.On;
        }


    }
}