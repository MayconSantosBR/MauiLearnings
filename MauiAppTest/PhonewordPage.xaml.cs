using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppTest
{
	public partial class PhonewordPage : ContentPage
	{
		string translatedNumber;

		public PhonewordPage()
		{
			InitializeComponent();
		}

        private void OnTranslate(object sender, EventArgs e)
        {
			string enteredNumber = PhoneNumberText.Text;
			translatedNumber = MauiAppTest.Helpers.PhonewordTranslator.ToNumber(enteredNumber);

			if (!string.IsNullOrEmpty(translatedNumber))
			{
				CallButton.IsEnabled = true;
				CallButton.Text = "Call " + translatedNumber;
			}
			else
			{
				CallButton.IsEnabled = false;
				CallButton.Text = "Call";
			}
        }

		private async void OnCall(object sender, EventArgs e)
		{
			if (await this.DisplayAlert(
				title: "Dial a Number", // title
				message: "Would you like to call " + translatedNumber + "?", // message
				accept: "Yes", // confirm button
				cancel: "No")) // cancel button
			{
				// dial the number
            }
		}
    }
}