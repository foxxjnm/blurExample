
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace blurExample
{
	public partial class BlurView : UIViewController
	{
		public BlurView () : base ("BlurView", null)
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

			View.BackgroundColor = UIColor.FromPatternImage (UIImage.FromBundle ("6778807104_27e9c96603_o.png"));

			butBlur.TouchUpInside += delegate
			{
				UIImage toBlur = UIImage.FromBundle ("6778807104_27e9c96603_o.png");
				UIImage blurred = toBlur.Blur();
				View.BackgroundColor = UIColor.FromPatternImage (blurred);
			};
			
			// Perform any additional setup after loading the view, typically from a nib.
		}
	}
}

