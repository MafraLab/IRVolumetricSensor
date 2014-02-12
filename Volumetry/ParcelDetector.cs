using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using Emgu.CV;
using Emgu.CV.Structure;

namespace Volumetry
{
	public class ParcelDetector
	{
		public List<MCvBox2D> EstimatedBoxes { get; private set; }
		public SizeF PixelSize { get; private set; }
		public float PixelArea { get; private set; }
		public SizeF RealSize { get; private set; }
		public float RealArea { get; private set; }
		public float Distance { get; private set; }

		public ParcelDetector(List<MCvBox2D> boxes, float distance)
		{
			this.EstimatedBoxes = boxes;
			this.Distance = distance;
			CalculateAverageBox();
			CalculateRealSize();
		}

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
