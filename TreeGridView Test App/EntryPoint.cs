using System;
using System.Windows.Forms;

namespace AdvancedDataGridView
{
	static class EntryPoint
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
            Application.EnableVisualStyles();
			Application.Run(new Form1());
		}
	}
}
