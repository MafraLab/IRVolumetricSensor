using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Volumetry
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			if (!System.IO.File.Exists("config.xml"))
			{
				Wizard w = new Wizard();
				DialogResult dr = w.ShowDialog();
				if (DialogResult.Cancel== dr)
				{
					MessageBox.Show("The Wizard must be completed otherwise there is no configuration file");
					Environment.Exit(0);
				}
			}
			Application.Run(new Form1());
		}
	}

	public sealed class Volumetry
	{
		private static readonly Volumetry instance = new Volumetry();

		public Volumetry()
		{
			Configuration = new ConfigurationTools();
		}

		public ConfigurationTools Configuration
		{
			get;
			private set;
		}

		public static Volumetry Instance
		{
			get
			{
				return instance;
			}
		}
	}
}
