using DataService.Entities;
using DataService.Queries;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
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

namespace GestaoTrabalhos.Views.Gestao.Artigos
{
	public partial class ArtigosDetailView : DevExpress.XtraEditors.XtraUserControl
	{
		private ArtigosEntity _crtArtigo = null;

		public ArtigosDetailView() => InitializeComponent();

		#region FUNCOES

		internal void LoadData(ArtigosEntity artigo)
		{
			_crtArtigo = artigo;
			artigosEntityBindingSource.DataSource = _crtArtigo;
			dataLayoutControl.BestFit();
		}

		internal async Task<(bool, ArtigosEntity)> SaveData()
		{
			dataLayoutControl.Focus();
			artigosEntityBindingSource.EndEdit();

			if (!ValidateData())
			{
				XtraMessageBox.Show("Preencher os campos que faltam!", "Campos Inválidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return (false, null);
			}

			bool saved = await ArtigosQuery.SaveArtigo(_crtArtigo);

			return (saved, _crtArtigo);
		}

		internal void ResetForm()
		{
			dxErrorProvider.ClearErrors();
			artigosEntityBindingSource.DataSource = new ArtigosEntity();
		}

		private bool ValidateData()
		{

			dxErrorProvider.ClearErrors();

			if (string.IsNullOrWhiteSpace(_crtArtigo.Codigo))
				dxErrorProvider.SetError(CodigoTextEdit, "Necessário preencher código!");

			if (string.IsNullOrWhiteSpace(_crtArtigo.Nome))
				dxErrorProvider.SetError(NomeTextEdit, "Necessário preencher nome!");



			return !dxErrorProvider.HasErrors;
		}

		#endregion
	}
}
