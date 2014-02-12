using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Volumetry
{
	public class Sensor
	{
		String PortName;
		Int32 BaudRate;
		Int32 Databits;
		System.IO.Ports.Parity Parity;
		System.IO.Ports.StopBits Stopbits;
		System.IO.Ports.SerialPort serial;
		Int32 sensorDistance = 0;

		public Sensor()
		{
			this.PortName = Volumetry.Instance.Configuration.configuration.sensor.PortName;
			this.BaudRate = Volumetry.Instance.Configuration.configuration.sensor.BaudRate;
			this.Databits = Volumetry.Instance.Configuration.configuration.sensor.Databits;
			this.Parity = Volumetry.Instance.Configuration.configuration.sensor.Parity;
			this.Stopbits = Volumetry.Instance.Configuration.configuration.sensor.Stopbits;
			serial = new System.IO.Ports.SerialPort(PortName, BaudRate, Parity, Databits, Stopbits);
			this.sensorDistance = Volumetry.Instance.Configuration.configuration.sensor.SensorDistance;
		}

		public bool Start()
		{
			try
			{
				serial.Open();
				serial.ReceivedBytesThreshold = 5;
				serial.DiscardInBuffer();
			}
			catch
			{
				return false;
			}
			return true;
		}

		public bool Stop()
		{
			try
			{
				serial.Close();
			}
			catch
			{
				return false;
			}
			return true;
		}

		public float GetReading()
		{
			string response;
			if (serial.IsOpen)
			{
				
				response = serial.ReadLine();
				float distance = sensorDistance - float.Parse(response.TrimEnd('\r').Replace('.',','));
				return distance;
			}
			return -1f;
		}
	}
}
