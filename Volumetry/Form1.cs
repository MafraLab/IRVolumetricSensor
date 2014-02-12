using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;

namespace Volumetry
{
	public partial class Form1 : Form
	{
		Scale scale = new Scale();
		
		Camera camera = new Camera();
		public Form1()
		{
			InitializeComponent();
			Configuration conf = Volumetry.Instance.Configuration.configuration;
			
		}

		private void btScan_Click(object sender, EventArgs e)
		{
			Sensor sensor = new Sensor();
			scale.Start();
			sensor.Start();
			String weight = scale.GetReading();
			
			Image<Bgr, byte> img = camera.QueryImage();
			float lenght = sensor.GetReading();
			ParcelDetector pd = new ParcelDetector(camera.boxList, lenght);
			Console.WriteLine("Area: " + pd.RealArea);
			Console.WriteLine("width: {0} | height: {1} | lenght: {2}", pd.RealSize.Width, pd.RealSize.Height, lenght);
			lblW.Text = pd.RealSize.Width.ToString();
			lblH.Text = pd.RealSize.Height.ToString();
			lblL.Text = lenght.ToString();
			lblVolume.Text = (pd.RealSize.Width * pd.RealSize.Height * lenght).ToString() + "cm2";
			lblWeight.Text = weight.ToString();
			sensor.Stop();
			scale.Stop(); 
			pictureBox1.Image = img.ToBitmap();
		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			Wizard wiz = new Wizard();
			wiz.ShowDialog();
		}
	}
}
