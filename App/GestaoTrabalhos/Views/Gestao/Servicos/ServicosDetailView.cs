using DataService.Entities;
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

namespace GestaoTrabalhos.Views.Gestao.Servicos
{
	public partial class ServicosDetailView : DevExpress.XtraEditors.XtraUserControl
	{
		private ServicosEntity _crtServico = null;

		public ServicosDetailView() => InitializeComponent();

		#region FUNCOES

		internal void LoadData(ServicosEntity servico)
		{
			_crtServico = servico;
			servicosEntityBindingSource.DataSource = _crtServico;
			dataLayoutControl.BestFit();
		}

		internal async Task<(bool, ServicosEntity)> SaveData()
		{
			dataLayoutControl.Focus();
			servicosEntityBindingSource.EndEdit();

			if (!ValidateData())
			{
				XtraMessageBox.Show("Preencher os campos que faltam!", "Campos Inválidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return (false, null);
			}

			bool saved = await ServicosQuery.SaveServico(_crtServico);

			return (saved, _crtServico);
		}

		internal void ResetForm()
		{
			dxErrorProvider.ClearErrors();
			servicosEntityBindingSource.DataSource = new ServicosEntity();
		}

		private bool ValidateData()
		{

			dxErrorProvider.ClearErrors();

			if (string.IsNullOrWhiteSpace(_crtServico.Codigo))
				dxErrorProvider.SetError(CodigoTextEdit, "Necessário preencher código!");

			if (string.IsNullOrWhiteSpace(_crtServico.Nome))
				dxErrorProvider.SetError(NomeTextEdit, "Necessário preencher nome!");


			return !dxErrorProvider.HasErrors;
		}

	}

	#endregion
}

