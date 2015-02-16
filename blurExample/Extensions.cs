
using MonoTouch.UIKit;
using MonoTouch.CoreImage;
using System.Drawing;

namespace blurExample
{
	public static class Extensions
	{
		public static UIImage Blur(this UIImage image, float blurRadius = 25f)
		{
			if (image != null)
			{
				// Create a new blurred image.
				var imageToBlur = new CIImage (image);
				var blur = new CIGaussianBlur ();
				blur.Image = imageToBlur;
				blur.Radius = blurRadius;

				var blurImage = blur.OutputImage;
				var context = CIContext.FromOptions (new CIContextOptions { UseSoftwareRenderer = false });
				var cgImage = context.CreateCGImage (blurImage, new RectangleF (new PointF (0, 0), image.Size));
				var newImage = UIImage.FromImage (cgImage);

				// Clean up
				imageToBlur.Dispose ();
				context.Dispose ();
				blur.Dispose ();
				blurImage.Dispose ();
				cgImage.Dispose ();

				return newImage;
			}
			return null;
		}
	}
}

