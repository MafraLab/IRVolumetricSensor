using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Volumetry
{
	public class Scale
	{
		String PortName;
		Int32 BaudRate;
		Int32 Databits;
		System.IO.Ports.Parity Parity;
		System.IO.Ports.StopBits Stopbits;
		System.IO.Ports.SerialPort serial;

		public Scale()
		{
			this.PortName = Volumetry.Instance.Configuration.configuration.scale.PortName;
			this.BaudRate = Volumetry.Instance.Configuration.configuration.scale.BaudRate;
			this.Databits = Volumetry.Instance.Configuration.configuration.scale.Databits;
			this.Parity = Volumetry.Instance.Configuration.configuration.scale.Parity;
			this.Stopbits = Volumetry.Instance.Configuration.configuration.scale.Stopbits;
			serial = new System.IO.Ports.SerialPort(PortName, BaudRate, Parity, Databits, Stopbits);
		}

		public bool Start()
		{
			try
			{
				serial.Open();
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

		public string GetReading()
		{
			string response;
			if (serial.IsOpen)
			{
				serial.WriteLine("SI");
				response = serial.ReadLine();
				response = response.Substring(3);
				response = response.TrimStart();
				return response;
			}
			return "Error";
		}
	}
}
