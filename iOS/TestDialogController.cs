
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

using Xamarin.Forms;

namespace DisplayAlertError.iOS
{
	public partial class TestDialogController : UIViewController
	{
		public TestDialogController () : base ("TestDialogController", null)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			var button = new UIButton(new RectangleF (0, 120, 320, 44));

			button.SetTitle ("Push forms", UIControlState.Normal);
			button.BackgroundColor = UIColor.Blue;
			var label = new UILabel (new RectangleF (0, 90, 320, 44));

			label.Text = "Test Label";

			button.TouchUpInside += (sender, e) => {
				NavigationController.PushViewController(DisplayAlertError.App.GetMainPage().CreateViewController(), true);
			};
			View.Add (label);

			View.Add (button);

			// Perform any additional setup after loading the view, typically from a nib.
		}
	}
}

