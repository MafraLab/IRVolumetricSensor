using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Volumetry
{
	// This class gets the scale readings
	public class Scale
	{
		String PortName;
		Int32 BaudRate;
		Int32 Databits;
		System.IO.Ports.Parity Parity;
		System.IO.Ports.StopBits Stopbits;
		System.IO.Ports.SerialPort serial;

		/*
		Constructor
		*/
		public Scale()
		{
			// set serial port connection
			this.PortName = Volumetry.Instance.Configuration.configuration.scale.PortName;
			this.BaudRate = Volumetry.Instance.Configuration.configuration.scale.BaudRate;
			this.Databits = Volumetry.Instance.Configuration.configuration.scale.Databits;
			this.Parity = Volumetry.Instance.Configuration.configuration.scale.Parity;
			this.Stopbits = Volumetry.Instance.Configuration.configuration.scale.Stopbits;
			serial = new System.IO.Ports.SerialPort(PortName, BaudRate, Parity, Databits, Stopbits);
		}

		/*
		Opens the serial port connection to the scale
		*/
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

		/*
		Closes the serial port connection to the scale
		*/
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

		/*
		Gets readings from the scale.
		This code was done to work with a mettler toledo scale
		Some abstraction for this would be a good idea
		*/
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
