using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;


namespace Volumetry
{
	/*
	This class is to configure our solution
	*/
	public class ConfigurationTools
	{
		public Configuration configuration = new Configuration();
		
		/*
		Constructor
		*/
		public ConfigurationTools()
		{
			configuration.camera = new CameraConfig();
			configuration.scale = new ScaleConfig();
			configuration.sensor = new SensorConfig();
			if (File.Exists("config.xml"))
			{
				ReadConfiguration();
			}
		}

		/*
		Load configuration file
		*/
		public void ReadConfiguration()
		{
			System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(configuration.GetType());
			FileStream fs = new FileStream("config.xml", FileMode.Open);			
			configuration = (Configuration)serializer.Deserialize(fs);
			fs.Close();
		}

		/*
		Read the configuration file
		*/
		public void WriteConfiguration()
		{
			System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(configuration.GetType());
			FileStream fs = new FileStream("config.xml", FileMode.Create);
			serializer.Serialize(fs, configuration);
			fs.Close();
		}
	}

	/*
	Configuration is serializable in order to store this set of objects as xml
	Here we store the scale, sensor and camera configuration.
	*/
	[Serializable]
	public class Configuration
	{
		public ScaleConfig scale;
		public SensorConfig sensor;
		public CameraConfig camera;
	}

	/*
	Load camera configuration object to store it in xml
	*/
	[Serializable]
	public class CameraConfig
	{
		public float FieldOfView;
		public int CannyThreshold;
		public int CannyLinkingThreshold;
		public int DistanceResolutionPixels;
		public int LineThreshold;
		public int MinimumLineWidth;
		public int GapBetweenLines;
		public int RectangleCount;
		public int RectangleMinSize;
		public int DetectionTimeout;
	}

	/*
	Load the scale configuration object to store it in xml
	*/
	[Serializable]
	public class ScaleConfig
	{
		public string PortName;
		public Int32 BaudRate;
		public System.IO.Ports.Parity Parity;
		public Int32 Databits;
		public System.IO.Ports.StopBits Stopbits;
	}

	/*
	Load the Sensor configuration object to store it in xml
	*/
	[Serializable]
	public class SensorConfig
	{
		public string PortName;
		public Int32 BaudRate;
		public System.IO.Ports.Parity Parity;
		public Int32 Databits;
		public System.IO.Ports.StopBits Stopbits;
		public Int32 SensorDistance;
	}
}
