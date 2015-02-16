// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace blurExample
{
	[Register ("BlurView")]
	partial class BlurView
	{
		[Outlet]
		MonoTouch.UIKit.UIButton butBlur { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (butBlur != null) {
				butBlur.Dispose ();
				butBlur = null;
			}
		}
	}
}
