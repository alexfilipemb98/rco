using DataService.Helpers;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace GestaoTrabalhos
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);


			CultureInfo cultura = new CultureInfo("pt-PT");
			Thread.CurrentThread.CurrentCulture = cultura;
			Thread.CurrentThread.CurrentUICulture = cultura;

			DbHelper.CheckDbFile();

			Application.Run(new MainForm());
		}
	}
}
