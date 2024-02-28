using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppTest
{
	public partial class TestPage : ContentPage
	{
        Label counterLabel;
        private int count { get; set; }

        public TestPage()
		{
		
			// Create a ScrollView and a StackLayout
			ScrollView scrollView = new();
            VerticalStackLayout stackLayout = new();

			// Defines the content of the ScrollView
			scrollView.Content = stackLayout;

            // Create page elements
            #region CreatePageElements
            counterLabel = new Label
			{
				Text = "Current count: 0",
				FontSize = 18,
				FontAttributes = FontAttributes.Bold,
				HorizontalOptions = LayoutOptions.Center
			};

			Button counterButton = new Button
			{
				Text = "Click me",
				HorizontalOptions = LayoutOptions.Center,
			};
			#endregion

			// Add elements to the page
			stackLayout.Children.Add(counterLabel);
			stackLayout.Children.Add(counterButton);

            counterButton.Clicked += OnCounterClicked;

			// Set the page content
			this.Content = scrollView;
		}

		private void OnCounterClicked(object sender, EventArgs e)
		{
            count++;
			counterLabel.Text = $"Current count: {count}";

            SemanticScreenReader.Announce(counterLabel.Text);
        }
	}
}