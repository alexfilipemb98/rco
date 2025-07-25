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

namespace GestaoTrabalhos.Views.Gestao.Clientes
{
	public partial class ClientesDetailView : DevExpress.XtraEditors.XtraUserControl
	{
		private ClientesEntity _crtCliente = null;

		public ClientesDetailView() => InitializeComponent();

		#region FUNCOES

		internal void LoadData(ClientesEntity cliente)
		{
			_crtCliente = cliente;
			clientesEntityBindingSource.DataSource = _crtCliente;
			dataLayoutControl.BestFit();
		}

		internal async Task<(bool, ClientesEntity)> SaveData()
			{
			dataLayoutControl.Focus();
			clientesEntityBindingSource.EndEdit();

			if (!ValidateData())
			{
				XtraMessageBox.Show("Preencher os campos que faltam!", "Campos Inválidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return (false, null);
			}

			bool saved = await ClientesQuery.SaveCliente(_crtCliente);

			return (saved, _crtCliente);
		}

		internal void ResetForm()
		{
			dxErrorProvider.ClearErrors();
			clientesEntityBindingSource.DataSource = new ClientesEntity();
		}

		private bool ValidateData()
		{

			dxErrorProvider.ClearErrors();

			if (string.IsNullOrWhiteSpace(_crtCliente.Codigo))
				dxErrorProvider.SetError(CodigoTextEdit, "Necessário preencher código!");

			if (string.IsNullOrWhiteSpace(_crtCliente.Nome))
				dxErrorProvider.SetError(NomeTextEdit, "Necessário preencher nome!");

			if (string.IsNullOrWhiteSpace(_crtCliente.Telefone))
				dxErrorProvider.SetError(TelefoneTextEdit, "Necessário preencher telefone!");

			if (!string.IsNullOrWhiteSpace(_crtCliente.Email))
			{
				if (!AppHelper.IsValidEmail(_crtCliente.Email))
					dxErrorProvider.SetError(EmailTextEdit, "Email está inválido!");

			}

			return !dxErrorProvider.HasErrors;
		}

	}

	#endregion

}
