using DataService.Queries;
using DevExpress.XtraEditors;
using GestaoTrabalhos.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoTrabalhos.Views.Home.Calendario
{
	public partial class CalendarioView : DevExpress.XtraEditors.XtraUserControl
	{
		public CalendarioView()
		{
			InitializeComponent();
		}

		private async void bbiReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			try
			{
				agendaModelBindingSource.DataSource = await GeralQuery.GetAgenda();
			}
			catch (Exception ex)
			{
				AppHelper.ErrorHelper(ex);
			}
		}
	}
}
