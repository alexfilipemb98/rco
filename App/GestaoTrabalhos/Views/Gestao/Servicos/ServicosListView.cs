using DataService.Entities;
using DataService.Queries;
using DevExpress.XtraEditors;
using GestaoTrabalhos.Helpers;
using GestaoTrabalhos.Views.Gestao.Clientes;
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
	public partial class ServicosListView : DevExpress.XtraEditors.XtraUserControl
	{
		public ServicosListView() => InitializeComponent();

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
				if (gridView.GetRow(gridView.FocusedRowHandle) is ServicosEntity servico && servico != null)
					ShowEditor(servico);
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
				(bool saved, ServicosEntity servico) = await xucServicosDetailView.SaveData();

				if (saved)
				{
					XtraMessageBox.Show("Guardado", "Serviço guardado com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
					ShowList(servico);
				}
			}
			catch (Exception ex)
			{
				AppHelper.ErrorHelper(ex);
			}
		}

		private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			try
			{
				if (gridView.GetRow(gridView.FocusedRowHandle) is ServicosEntity servico && servico != null)
				{
					//TODO validar se já tem movimentos associados!
					DialogResult result = XtraMessageBox.Show($"Deseja mesmo apagar '{servico.Nome}'?", "Apagar Serviço?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if (result == DialogResult.Yes)
					{
						//TODO: apagar o servico!
					}
				}
			}
			catch (Exception ex)
			{
				AppHelper.ErrorHelper(ex);
			}
		}

		private void gridView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
		{
			if (e.Button == MouseButtons.Right && gridView.GetRow(gridView.FocusedRowHandle) is ServicosEntity sercico && sercico != null)
				popupMenu.ShowPopup(Control.MousePosition);

		}

		#region FUNCOES

		internal async Task LoadData()
		{
			servicosEntityBindingSource.DataSource = await ServicosQuery.GetServicos();
		}

		private async void ShowEditor(ServicosEntity servico = null)
		{
			if (servico == null)
			{
				servico = new ServicosEntity();
				servico.EmModoEdicao = false;
				servico.Ativo = true;
				servico.Codigo = await ServicosQuery.GerarProximoCodigoAsync();


				servico.DataCriacao = DateTime.Now;
				servico.DataAtualizacao = DateTime.Now;
			}

			bbiEdit.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
			bbiReload.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

			bbiBack.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
			bbiSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;

			xucServicosDetailView.LoadData(servico);
			navigationFrame.SelectedPage = npEditor;
		}

		private void ShowList(ServicosEntity servico = null)
		{
			bbiEdit.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
			bbiReload.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;

			bbiBack.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
			bbiSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

			if (servico != null)
			{
				List<ServicosEntity> lista = servicosEntityBindingSource.DataSource as List<ServicosEntity>;
				if (lista.Any(w => w.Id == servico.Id))
					gridView.UpdateCurrentRow();
				else
					servicosEntityBindingSource.Add(servico);
			}

			navigationFrame.SelectedPage = npList;
			xucServicosDetailView.ResetForm();
		}

		#endregion

	}
}
