using DevExpress.Internal.WinApi;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoTrabalhos.Helpers
{
	internal static class AppHelper
	{
		internal static void ErrorHelper(Exception ex)
		{
			XtraMessageBox.Show(ex.Message, ex.TargetSite.Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		internal static bool IsValidEmail(string email)
		{
			return Regex.IsMatch(email ?? "", @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
		}

	}
}
