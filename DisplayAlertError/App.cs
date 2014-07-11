using System;
using Xamarin.Forms;


namespace DisplayAlertError
{
	public class App
	{
		public static Page GetMainPage ()
		{	
			var button = new Button {
				Text = "Show Alert",
				VerticalOptions = LayoutOptions.CenterAndExpand,
				HorizontalOptions = LayoutOptions.CenterAndExpand
			};

			var content = new ContentPage {			
				Content =	new StackLayout { 
					Padding = new Thickness(10, 20),
					Children = {
						button,
						new Label {
							Text = "Forms Page!",
							VerticalOptions = LayoutOptions.CenterAndExpand,
							HorizontalOptions = LayoutOptions.CenterAndExpand,
						}
					}
				}
			};

			button.Clicked += (sender, e) => content.DisplayAlert ("Test alert", "Test alert message", "Ok", "Cancel");;

			return content;
		}
	}
}

