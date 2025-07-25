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
	public partial class ClientesListView : DevExpress.XtraEditors.XtraUserControl
	{
		public ClientesListView() => InitializeComponent();

		private async void bbiReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			try
			{
				await LoadData();
			}
			catch (Exception ex)
			{
				AppHelper.ErrorHelper(ex);
			}
		}

		private void bbiNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			try
			{
				ShowEditor();
			}
			catch (Exception ex)
			{
				AppHelper.ErrorHelper(ex);
			}
		}

		private void bbiEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			try
			{
				if (gridView.GetRow(gridView.FocusedRowHandle) is ClientesEntity cliente && cliente != null)
				{
					ShowEditor(cliente);
				}
			}
			catch (Exception ex)
			{
				AppHelper.ErrorHelper(ex);
			}
		}

		private async void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			try
			{
				(bool saved, ClientesEntity cliente) = await xucClientesDetailView.SaveData();

				if (saved)
				{
					XtraMessageBox.Show("Guardado", "Cliente guardado com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
					ShowList(cliente);
				}
			}
			catch (Exception ex)
			{
				AppHelper.ErrorHelper(ex);
			}
		}

		private void bbiBack_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			try
			{
				ShowList();
			}
			catch (Exception ex)
			{
				AppHelper.ErrorHelper(ex);
			}
		}

		private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if (gridView.GetRow(gridView.FocusedRowHandle) is ClientesEntity cliente && cliente != null)
			{
				//TODO validar se já tem movimentos associados!
				DialogResult result = XtraMessageBox.Show($"Deseja mesmo apagar '{cliente.Nome}'?", "Apagar Cliente?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result == DialogResult.Yes)
				{
					//TODO: apagar o cliente!
				}
			}
		}

		#region FUNCOES

		internal async Task LoadData()
		{
			clientesEntityBindingSource.DataSource = await ClientesQuery.GetClientes();
		}

		private async void ShowEditor(ClientesEntity cliente = null)
		{
			if (cliente == null)
			{
				cliente = new ClientesEntity();
				cliente.EmModoEdicao = false;
				cliente.Ativo = true;
				cliente.Codigo = await ClientesQuery.GerarProximoCodigoAsync();

				cliente.DataCriacao = DateTime.Now;
				cliente.DataAtualizacao = DateTime.Now;
			}

			bbiEdit.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
			bbiReload.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

			bbiBack.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
			bbiSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;

			xucClientesDetailView.LoadData(cliente);
			navigationFrame.SelectedPage = npEditor;
		}

		private void ShowList(ClientesEntity cliente = null)
		{
			bbiEdit.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
			bbiReload.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;

			bbiBack.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
			bbiSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

			if (cliente != null)
			{
				List<ClientesEntity> lista = clientesEntityBindingSource.DataSource as List<ClientesEntity>;
				if (lista.Any(w => w.Id == cliente.Id))
					gridView.UpdateCurrentRow();
				else
					clientesEntityBindingSource.Add(cliente);
			}

			navigationFrame.SelectedPage = npList;
			xucClientesDetailView.ResetForm();
		}

		#endregion

		private void gridView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
		{
			if (e.Button == MouseButtons.Right && gridView.GetRow(gridView.FocusedRowHandle) is ClientesEntity cliente && cliente != null)
				popupMenu.ShowPopup(Control.MousePosition);

		}

	}
}
