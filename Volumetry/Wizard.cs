using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.Util;
using Emgu.CV.UI;
using Emgu.CV.Structure;

namespace Volumetry
{
	public partial class Wizard : Form
	{
		Capture capture; //create a camera captue
		Image<Bgr, byte> image;


		public Wizard()
		{
			InitializeComponent();
			
			
			pnlCamera.Visible = true;
			capture = new Capture();
			radioClean.Checked = true;
			radioTClean.Checked = true;
			if (MaskExist())
			{
				radioMask.Enabled = true;
				radioCanny.Enabled = true;
				radioContour.Enabled = true;
				radioResult.Enabled = true;
			}
			else
			{
				radioMask.Enabled = false;
				radioCanny.Enabled = false;
				radioContour.Enabled = false;
				radioResult.Enabled = false;
			}

			cbCOM.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
			cbBaud.Items.AddRange(new string[] { "4800", "9600", "19200", "28800", "38400", "57600", "115200" });
			cbDatabits.Items.AddRange(new string[] { "5", "6", "7", "8", "9" });
			cbParity.Items.AddRange(Enum.GetNames(typeof(System.IO.Ports.Parity)));
			cbStopbits.Items.AddRange(Enum.GetNames(typeof(System.IO.Ports.StopBits)));

			cbScalePort.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
			cbScaleBaud.Items.AddRange(new string[] { "4800", "9600", "19200", "28800", "38400", "57600", "115200" });
			cbScaleDatabits.Items.AddRange(new string[] { "5", "6", "7", "8", "9" });
			cbScaleParity.Items.AddRange(Enum.GetNames(typeof(System.IO.Ports.Parity)));
			cbScaleStopbits.Items.AddRange(Enum.GetNames(typeof(System.IO.Ports.StopBits)));

			if (System.IO.File.Exists("config.xml"))
			{
				textBox1.Text = Volumetry.Instance.Configuration.configuration.camera.FieldOfView.ToString();
				textBox8.Text = Volumetry.Instance.Configuration.configuration.camera.DetectionTimeout.ToString();
				tbThreshold.Value = Volumetry.Instance.Configuration.configuration.camera.CannyThreshold;
				tbLineThresh.Value = Volumetry.Instance.Configuration.configuration.camera.CannyLinkingThreshold;
				textBox2.Text = Volumetry.Instance.Configuration.configuration.camera.DistanceResolutionPixels.ToString();
				textBox3.Text = Volumetry.Instance.Configuration.configuration.camera.LineThreshold.ToString();
				textBox4.Text = Volumetry.Instance.Configuration.configuration.camera.MinimumLineWidth.ToString();
				textBox5.Text = Volumetry.Instance.Configuration.configuration.camera.GapBetweenLines.ToString();
				textBox6.Text = Volumetry.Instance.Configuration.configuration.camera.RectangleMinSize.ToString();

				cbScaleParity.SelectedText = Volumetry.Instance.Configuration.configuration.scale.PortName;
				cbScaleBaud.SelectedText = Volumetry.Instance.Configuration.configuration.scale.BaudRate.ToString();
				cbScaleParity.SelectedText = Volumetry.Instance.Configuration.configuration.scale.Parity.ToString();
				cbScaleDatabits.SelectedText = Volumetry.Instance.Configuration.configuration.scale.Databits.ToString();
				cbScaleStopbits.SelectedValue = Volumetry.Instance.Configuration.configuration.sensor.Stopbits.ToString();

				cbCOM.SelectedValue = Volumetry.Instance.Configuration.configuration.sensor.PortName;
				cbBaud.SelectedValue = Volumetry.Instance.Configuration.configuration.sensor.BaudRate.ToString();
				cbParity.SelectedValue = Volumetry.Instance.Configuration.configuration.sensor.Parity.ToString();
				cbDatabits.SelectedValue = Volumetry.Instance.Configuration.configuration.sensor.Databits.ToString();
				cbStopbits.SelectedValue = Volumetry.Instance.Configuration.configuration.sensor.Stopbits.ToString();
			}
		}

		
		#region Camera
		private void pnlCamera_VisibleChanged(object sender, EventArgs e)
		{
			
			EventHandler eventhandler = new EventHandler(Application_Idle);
			if (pnlCamera.Visible)
			{
				
				capture.SetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FRAME_WIDTH, 1280);
				capture.SetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FRAME_HEIGHT, 720);
				
				Application.Idle += eventhandler;
			}
			else
			{
				Application.Idle -= eventhandler;
				capture = null;
			}
		}

		void Application_Idle(object sender, EventArgs e)
		{
			this.image = GetCleanImage();
			if (radioClean.Checked)
			{
				
				if (radioTClean.Checked)
				{
					pictureBox1.Image = image.Resize(762, 569, Emgu.CV.CvEnum.INTER.CV_INTER_AREA, true).ToBitmap();
				}
				else if (radioContour.Checked)
				{
					pictureBox1.Image = GetContourLines(image, image).Resize(762, 569, Emgu.CV.CvEnum.INTER.CV_INTER_AREA, true).ToBitmap();
				}
				else if (radioResult.Checked)
				{
					pictureBox1.Image = GetResultLines(image, image).Resize(762, 569, Emgu.CV.CvEnum.INTER.CV_INTER_AREA, true).ToBitmap();
				}
			}
			else if (radioMask.Checked)
			{
				if (radioTClean.Checked)
				{
					pictureBox1.Image = GetMaskImage(image).Resize(762, 569, Emgu.CV.CvEnum.INTER.CV_INTER_AREA, true).ToBitmap();
				}
				else if (radioContour.Checked)
				{
					pictureBox1.Image = GetContourLines(image, image).Resize(762, 569, Emgu.CV.CvEnum.INTER.CV_INTER_AREA, true).ToBitmap();
				}
				else if (radioResult.Checked)
				{
					pictureBox1.Image = GetResultLines(image, GetMaskImage(image)).Resize(762, 569, Emgu.CV.CvEnum.INTER.CV_INTER_AREA, true).ToBitmap();
				}

			}
			else
			{
				if (radioTClean.Checked)
				{
					pictureBox1.Image = GetCannyImage(image).Resize(762, 569, Emgu.CV.CvEnum.INTER.CV_INTER_AREA, true).ToBitmap();
				}
				else if (radioContour.Checked)
				{
					pictureBox1.Image = GetContourLines(image, GetCannyImage(image)).Resize(762, 569, Emgu.CV.CvEnum.INTER.CV_INTER_AREA, true).ToBitmap();
				}
				else if (radioResult.Checked)
				{
					pictureBox1.Image = GetResultLines(image, GetCannyImage(image)).Resize(762, 569, Emgu.CV.CvEnum.INTER.CV_INTER_AREA, true).ToBitmap();
				}
			}
		}

		/// <summary>
		/// Retrieve a clean image
		/// </summary>
		/// <returns></returns>
		public Image<Bgr, byte> GetCleanImage()
		{
			return capture.QueryFrame();
		}

		/// <summary>
		/// Retrieve the result of a subtraction between the the captured image
		/// and the mask image
		/// </summary>
		/// <returns></returns>
		public Image<Bgr, byte> GetMaskImage(Image<Bgr, byte> imgClean)
		{
			if (MaskExist())
			{
				Image<Gray, Byte> cannyEdges = new Image<Gray, byte>(1, 1, new Gray(1));
				Image<Bgr, byte> back = new Image<Bgr, byte>("mask.bmp").SmoothMedian(5);
				Image<Gray, byte> temp;
				temp = back.Sub(imgClean.SmoothMedian(5)).Convert<Gray, byte>();
				cannyEdges = null;
				back = null;
				return temp.Convert<Bgr, byte>();// cannyEdges.Convert<Bgr, byte>();
			}
			else
			{
				return GetCleanImage();
			}
		}                                                                                              

		/// <summary>
		/// Retrieve the result of a Canny algorithm on the masked image
		/// </summary>
		/// <returns></returns>
		public Image<Bgr, byte> GetCannyImage(Image<Bgr, byte> imgClean)
		{
			if (MaskExist())
			{
				Image<Gray, Byte> cannyEdges = new Image<Gray, byte>(1, 1, new Gray(1));
				Image<Bgr, byte> back = new Image<Bgr, byte>("mask.bmp").SmoothMedian(5);
				Image<Gray, byte> temp;
				temp = back.Sub(imgClean.SmoothMedian(5)).Convert<Gray, byte>();
				cannyEdges = temp.Canny(new Gray(tbThreshold.Value), new Gray(tbLineThresh.Value));
				return cannyEdges.Convert<Bgr, byte>();
			}
			else
			{
				return imgClean;
			}
		}

		private bool MaskExist()
		{
			return System.IO.File.Exists("mask.bmp");
		}

		public Image<Bgr, byte> GetResultLines(Image<Bgr, byte> imgClean, Image<Bgr, byte> imgOver)
		{
			Image<Gray, Byte> cannyEdges = null;
			Image<Bgr, byte> back = new Image<Bgr, byte>("mask.bmp");
			Image<Gray, byte> temp;
			temp = back.Sub(imgClean.SmoothMedian(5)).Convert<Gray, byte>();
			cannyEdges = temp.Canny(new Gray(tbThreshold.Value), new Gray(tbLineThresh.Value));

			LineSegment2D[] lines = cannyEdges.HoughLinesBinary(
				Convert.ToInt32(textBox2.Text), //Distance resolution in pixel-related units
				Math.PI / 45.0, //Angle resolution measured in radians.
				Convert.ToInt32(textBox3.Text), //threshold
				Convert.ToInt32(textBox4.Text), //min Line width
				Convert.ToInt32(textBox5.Text) //gap between lines
				)[0]; //Get the lines from the first channel

			List<MCvBox2D> boxList = new List<MCvBox2D>();

			using (MemStorage storage = new MemStorage()) //allocate storage for contour approximation
				for (Contour<Point> contours = cannyEdges.FindContours(); contours != null; contours = contours.HNext)
				{
					Contour<Point> currentContour = contours.ApproxPoly(contours.Perimeter * 0.05, storage);

					if (contours.Area > Convert.ToInt32(textBox6.Text)) //only consider contours with area greater than 250
					{
						if (currentContour.Total == 4) //The contour has 4 vertices.
						{
							#region determine if all the angles in the contour are within the range of [80, 100] degree
							bool isRectangle = true;
							Point[] pts = currentContour.ToArray();
							LineSegment2D[] edges = PointCollection.PolyLine(pts, true);

							for (int i = 0; i < edges.Length; i++)
							{
								double angle = Math.Abs(
								edges[(i + 1) % edges.Length].GetExteriorAngleDegree(edges[i]));
								if (angle < 80 || angle > 100)
								{
									isRectangle = false;
									break;
								}
							}
							#endregion

							if (isRectangle) boxList.Add(currentContour.GetMinAreaRect());
						}
					}
				}
		#endregion

			//originalImageBox.Image = img;

			#region draw triangles and rectangles

			foreach (MCvBox2D box in boxList)
				imgOver.Draw(box, new Bgr(Color.DarkOrange), 2);
			return imgOver;
			#endregion
		}

		public Image<Bgr, byte> GetContourLines(Image<Bgr, byte> imgClean, Image<Bgr, byte> imgOver)
		{
			Image<Gray, Byte> cannyEdges = new Image<Gray, byte>(1, 1, new Gray(1));
			Image<Bgr, byte> back = new Image<Bgr, byte>("mask.bmp").SmoothMedian(5);
			Image<Gray, byte> temp;
			temp = back.Sub(imgClean.SmoothMedian(5)).Convert<Gray, byte>();
			cannyEdges = temp.Canny(new Gray(tbThreshold.Value), new Gray(tbLineThresh.Value));
			LineSegment2D[] lines = cannyEdges.HoughLinesBinary(
				Convert.ToInt32(textBox2.Text), //Distance resolution in pixel-related units
				Math.PI / 45.0, //Angle resolution measured in radians.
				Convert.ToInt32(textBox3.Text), //threshold
				Convert.ToInt32(textBox4.Text), //min Line width
				Convert.ToInt32(textBox5.Text) //gap between lines
				)[0]; //Get the lines from the first channel

			using (MemStorage storage = new MemStorage()) //allocate storage for contour approximation
				for (Contour<Point> contours = cannyEdges.FindContours(); contours != null; contours = contours.HNext)
				{
					Contour<Point> currentContour = contours.ApproxPoly(contours.Perimeter * 0.05, storage);
				}
			#region draw lines
			foreach (LineSegment2D line in lines)
				imgOver.Draw(line, new Bgr(Color.Green), 2);
			return imgOver;
			#endregion
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if ((System.IO.Ports.StopBits)(Enum.Parse(typeof(System.IO.Ports.StopBits), cbStopbits.SelectedItem.ToString())) != System.IO.Ports.StopBits.None)
			{
				SerialSensor.PortName = cbCOM.SelectedItem.ToString();
				SerialSensor.BaudRate = Convert.ToInt32(cbBaud.SelectedItem);
				SerialSensor.StopBits = (System.IO.Ports.StopBits)(Enum.Parse(typeof(System.IO.Ports.StopBits), cbStopbits.SelectedItem.ToString()));
				SerialSensor.Parity = (System.IO.Ports.Parity)Enum.Parse(typeof(System.IO.Ports.Parity), cbParity.SelectedItem.ToString(), true);
				SerialSensor.DataBits = Convert.ToInt32(cbDatabits.SelectedItem);
				try
				{
					SerialSensor.Open();
					SerialSensor.ReadTimeout = 4000;
					SerialSensor.Write(" ");
					string test = SerialSensor.ReadLine();
					
					if (!String.IsNullOrEmpty(test))
					{
						MessageBox.Show("Connection Succeded: "+ test);
					}
					else
					{
						MessageBox.Show("Connection Failed!");
					}
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
				SerialSensor.Close();
			}
			else
			{
				MessageBox.Show("Can't have stopbits = 'None'");
			}
			
			
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if ((System.IO.Ports.StopBits)(Enum.Parse(typeof(System.IO.Ports.StopBits), cbScaleStopbits.SelectedItem.ToString())) != System.IO.Ports.StopBits.None)
			{
				SerialScale.PortName = cbScalePort.SelectedItem.ToString();
				SerialScale.BaudRate = Convert.ToInt32(cbScaleBaud.SelectedItem);
				SerialScale.StopBits = (System.IO.Ports.StopBits)(Enum.Parse(typeof(System.IO.Ports.StopBits), cbScaleStopbits.SelectedItem.ToString()));
				SerialScale.Parity = (System.IO.Ports.Parity)Enum.Parse(typeof(System.IO.Ports.Parity), cbScaleParity.SelectedItem.ToString(), true);
				SerialScale.DataBits = Convert.ToInt32(cbScaleDatabits.SelectedItem);
				try
				{
					SerialScale.Open();
					SerialScale.ReadTimeout = 1000;
					SerialScale.WriteLine("I2");
					string test = SerialScale.ReadLine();
					SerialScale.Close();
					if (!String.IsNullOrEmpty(test))
					{
						MessageBox.Show("Connection Succeded: " + test);
					}
					else
					{
						MessageBox.Show("Connection Failed!");
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
					SerialScale.Close();
				}

			}
			else
			{
				MessageBox.Show("Can't have stopbits = 'None'");
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			ConfigurationTools conf = new ConfigurationTools();
			conf.configuration.camera.CannyLinkingThreshold = Convert.ToInt32(this.tbLineThresh.Value);
			conf.configuration.camera.CannyThreshold = Convert.ToInt32(this.tbThreshold.Value);
			conf.configuration.camera.DetectionTimeout = (!String.IsNullOrEmpty(this.textBox8.Text))?Convert.ToInt32(this.textBox8.Text):0;
			conf.configuration.camera.DistanceResolutionPixels = (!String.IsNullOrEmpty(this.textBox2.Text)) ? Convert.ToInt32(this.textBox2.Text) : 0;
			conf.configuration.camera.LineThreshold = (!String.IsNullOrEmpty(this.textBox3.Text)) ? Convert.ToInt32(this.textBox3.Text) : 0;
			conf.configuration.camera.MinimumLineWidth = (!String.IsNullOrEmpty(this.textBox4.Text)) ? Convert.ToInt32(this.textBox4.Text) : 0;
			conf.configuration.camera.GapBetweenLines = (!String.IsNullOrEmpty(this.textBox5.Text)) ? Convert.ToInt32(this.textBox5.Text) : 0;
			conf.configuration.camera.RectangleMinSize = (!String.IsNullOrEmpty(this.textBox6.Text)) ? Convert.ToInt32(this.textBox6.Text) : 0;
			conf.configuration.camera.FieldOfView = (!String.IsNullOrEmpty(this.textBox1.Text)) ? Convert.ToInt32(this.textBox1.Text) : 0;

			conf.configuration.sensor.PortName = cbCOM.SelectedItem.ToString();
			conf.configuration.sensor.BaudRate = Convert.ToInt32(cbBaud.SelectedItem.ToString());
			conf.configuration.sensor.Databits = Convert.ToInt32(cbDatabits.SelectedItem.ToString());
			conf.configuration.sensor.Parity = (System.IO.Ports.Parity)Enum.Parse(typeof(System.IO.Ports.Parity), cbParity.SelectedItem.ToString(), true);
			conf.configuration.sensor.Stopbits = (System.IO.Ports.StopBits)(Enum.Parse(typeof(System.IO.Ports.StopBits), cbStopbits.SelectedItem.ToString()));
			conf.configuration.sensor.SensorDistance = Convert.ToInt32(textBox7.Text);

			conf.configuration.scale.PortName = cbScalePort.SelectedItem.ToString();
			conf.configuration.scale.BaudRate = Convert.ToInt32(cbScaleBaud.SelectedItem.ToString());
			conf.configuration.scale.Databits = Convert.ToInt32(cbScaleDatabits.SelectedItem.ToString());
			conf.configuration.scale.Parity = (System.IO.Ports.Parity)Enum.Parse(typeof(System.IO.Ports.Parity), cbScaleParity.SelectedItem.ToString(), true);
			conf.configuration.scale.Stopbits = (System.IO.Ports.StopBits)(Enum.Parse(typeof(System.IO.Ports.StopBits), cbScaleStopbits.SelectedItem.ToString()));
			
			conf.WriteConfiguration();
			this.Close();
		}

		private void btSave_Click(object sender, EventArgs e)
		{
			capture.QueryFrame().Save("mask.bmp");
			MessageBox.Show("Mask Saved Sucessfully!");
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{
			if ((((TextBoxBase)(sender)).Text == "0") || (String.IsNullOrEmpty(((TextBoxBase)(sender)).Text)))
			{
				((TextBox)(sender)).Text="1";
			}
		}

	}
}
