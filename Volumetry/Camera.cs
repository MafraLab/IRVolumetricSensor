using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Emgu.CV;
using Emgu.Util;
using Emgu.CV.UI;
using Emgu.CV.Structure;
using System.Drawing;
using System.Windows.Forms;

namespace Volumetry
{
	public class Camera
	{
		private Int32 CannyLinkingThreshold;
		private Int32 CannyThreshold;
		private Int32 DetectionTimeout;
		private Int32 DistanceResolutionPixels;
		private float FieldOfView;
		private Int32 GapBetweenLines;
		private Int32 LineThreshold;
		private Int32 MinimumLineWidth;
		private Int32 RectangleCount;
		private Int32 RectangleMinSize;

		public List<MCvBox2D> boxList = new List<MCvBox2D>();
		private Capture capture;
		Image<Bgr, byte> screenShot;


		public Camera()
		{
			CannyLinkingThreshold = Volumetry.Instance.Configuration.configuration.camera.CannyLinkingThreshold;
			CannyThreshold = Volumetry.Instance.Configuration.configuration.camera.CannyThreshold;
			DetectionTimeout = Volumetry.Instance.Configuration.configuration.camera.DetectionTimeout;
			DistanceResolutionPixels = Volumetry.Instance.Configuration.configuration.camera.DistanceResolutionPixels;
			FieldOfView = Volumetry.Instance.Configuration.configuration.camera.FieldOfView;
			GapBetweenLines = Volumetry.Instance.Configuration.configuration.camera.GapBetweenLines;
			LineThreshold = Volumetry.Instance.Configuration.configuration.camera.LineThreshold;
			MinimumLineWidth = Volumetry.Instance.Configuration.configuration.camera.MinimumLineWidth;
			RectangleCount = Volumetry.Instance.Configuration.configuration.camera.RectangleCount;
			RectangleMinSize = Volumetry.Instance.Configuration.configuration.camera.RectangleMinSize;
			capture = new Capture();
			capture.SetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FRAME_WIDTH, 1280);
			capture.SetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FRAME_HEIGHT, 720);

		}

		public bool GetMask(Image<Bgr, byte> images)
		{

			Image<Gray, Byte> cannyEdges = new Image<Gray, byte>(1, 1, new Gray(1));

			Image<Bgr, byte> back = new Image<Bgr, byte>("mask.bmp").SmoothMedian(5);
			Image<Gray, byte> temp;
			temp = back.Sub(images.SmoothMedian(5)).Convert<Gray, byte>();



			cannyEdges = temp.Canny(new Gray(200), new Gray(80));
			LineSegment2D[] lines = cannyEdges.HoughLinesBinary(
				this.MinimumLineWidth, //Distance resolution in pixel-related units
				Math.PI / 45.0, //Angle resolution measured in radians.
				this.LineThreshold, //threshold
				this.MinimumLineWidth, //min Line width
				this.GapBetweenLines //gap between lines
				)[0]; //Get the lines from the first channel

			#region Find triangles and rectangles



			using (MemStorage storage = new MemStorage()) //allocate storage for contour approximation
				for (Contour<Point> contours = cannyEdges.FindContours(); contours != null; contours = contours.HNext)
				{
					Contour<Point> currentContour = contours.ApproxPoly(contours.Perimeter * 0.05, storage);

					if (contours.Area > this.RectangleMinSize) //only consider contours with area greater than 250
					{
						if (currentContour.Total == 4) //The contour has 4 vertices.
						{
							#region determine if all the angles in the contour are within the range of [80, 100] degree
							bool isRectangle = true;
							Point[] pts = currentContour.ToArray();
							LineSegment2D[] edges = PointCollection.PolyLine(pts, true);

							for (int j = 0; j < edges.Length; j++)
							{
								double angle = Math.Abs(
								   edges[(j + 1) % edges.Length].GetExteriorAngleDegree(edges[j]));
								if (angle < 75 || angle > 110)
								{
									isRectangle = false;
									break;
								}
							}
							#endregion

							if (isRectangle)
							{
								boxList.Add(currentContour.GetMinAreaRect());

							}
						}
					}
				}
			#endregion


			foreach (MCvBox2D box in boxList)
				images.Draw(box, new Bgr(Color.DarkOrange), 2);

			screenShot = images;

			if (boxList.Count > this.RectangleCount)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public Image<Bgr, byte> QueryImage()
		{
			capture.QueryFrame();
			capture.QueryFrame();
			capture.QueryFrame();
			System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
			sw.Start();
			boxList.Clear();
			bool bStop = false;
			while (!bStop && boxList.Count < 10)
			{
				if (sw.Elapsed.Seconds > 15)
				{
					MessageBox.Show("Timeout: Failed to capture image");
					break;
				}
				bStop = GetMask(capture.QueryFrame());
			}
			
			return screenShot;

		}

	}
}
