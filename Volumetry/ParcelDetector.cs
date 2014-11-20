using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using Emgu.CV;
using Emgu.CV.Structure;

namespace Volumetry
{
	/*
	This class uses openCV to be able to detect the size of the box presented on the image
	*/
	public class ParcelDetector
	{
		// Get a collection of estimated boxes on screen
		public List<MCvBox2D> EstimatedBoxes { get; private set; }
		
		// Get a reference of the realsize of each pixel
		public SizeF PixelSize { get; private set; }
		
		// Get the area of a box in pixels
		public float PixelArea { get; private set; }
		
		// Get the real size of the box
		public SizeF RealSize { get; private set; }
		
		// Get the real area of the box
		public float RealArea { get; private set; }
		
		// Gets the distance that the box is from the camera
		public float Distance { get; private set; }

		// Compute the detected boxes
		public ParcelDetector(List<MCvBox2D> boxes, float distance)
		{
			this.EstimatedBoxes = boxes;
			this.Distance = distance;
			CalculateAverageBox();
			CalculateRealSize();
		}

		// Compute the real size of the box using some trigonometry
		private void CalculateRealSize()
		{
			double pixelDiagonal = Math.Sqrt(Math.Pow(1280, 2) + Math.Pow(720, 2));
			float FOV = 73;
			float radian = (float)(FOV / 2) * (float)(Math.PI / 180);
			double realHeight = (((PixelSize.Height / 2) / ((pixelDiagonal / 2) / Math.Tan(radian))) * (Volumetry.Instance.Configuration.configuration.sensor.SensorDistance - Distance)) * 2;
			
			double realWidth = (((PixelSize.Width / 2) / ((pixelDiagonal / 2) / Math.Tan(radian))) * (Volumetry.Instance.Configuration.configuration.sensor.SensorDistance - Distance)) * 2;
			
			RealSize = new SizeF((float)realWidth, (float)realHeight);
			RealArea = RealSize.Width * RealSize.Height;
		}

		// This will allow to have the best approach of the box size
		// This is needed because each frame may have variations on the box size
		// and surelly the avg is the best approach
		private void CalculateAverageBox()
		{
			float twidth = 0;
			float theight = 0;
			for (int i = 0; i < EstimatedBoxes.Count; i++)
			{
				twidth += EstimatedBoxes[i].size.Width;
				theight += EstimatedBoxes[i].size.Height;
			}
			this.PixelSize = new SizeF((twidth / EstimatedBoxes.Count), (theight / EstimatedBoxes.Count));
			this.PixelArea = PixelSize.Height * PixelSize.Width;
		}
	}
}
