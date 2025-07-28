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

namespace GestaoTrabalhos.Views.Gestao.Artigos
{
	public partial class ArtigosListView : DevExpress.XtraEditors.XtraUserControl
	{
		public ArtigosListView() => InitializeComponent();

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

		#region CLICK

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

		private async void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			try
			{
				(bool saved, ArtigosEntity artigo) = await xucArtigosDetailView.SaveData();

				if (saved)
				{
					XtraMessageBox.Show("Guardado", "Cliente guardado com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
					ShowList(artigo);
				}
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
				if (gridView.GetRow(gridView.FocusedRowHandle) is ArtigosEntity artigo && artigo != null)
				{
					ShowEditor(artigo);
				}
			}
			catch (Exception ex)
			{
				AppHelper.ErrorHelper(ex);
			}
		}

		private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if (gridView.GetRow(gridView.FocusedRowHandle) is ArtigosEntity artigo && artigo != null)
			{
				//TODO validar se já tem movimentos associados!
				DialogResult result = XtraMessageBox.Show($"Deseja mesmo apagar '{artigo.Nome}'?", "Apagar Cliente?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result == DialogResult.Yes)
				{
					//TODO: apagar o artigo!
				}
			}
		}

		private void gridView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
		{
			if (e.Button == MouseButtons.Right && gridView.GetRow(gridView.FocusedRowHandle) is ArtigosEntity artigo && artigo != null)
				popupMenu.ShowPopup(Control.MousePosition);

		}

		#endregion
	
		#region FUNCOES

		internal async Task LoadData()
		{
			artigosEntityBindingSource.DataSource = await ArtigosQuery.GetArtigos();
		}

		private async void ShowEditor(ArtigosEntity artigo = null)
		{
			if (artigo == null)
			{
				artigo = new ArtigosEntity();
				artigo.EmModoEdicao = false;
				artigo.Ativo = true;
				artigo.Codigo  = await ArtigosQuery.GerarProximoCodigoAsync();

				artigo.DataCriacao = DateTime.Now;
				artigo.DataAtualizacao = DateTime.Now;
			}

			bbiEdit.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
			bbiReload.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

			bbiBack.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
			bbiSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;

			xucArtigosDetailView.LoadData(artigo);
			navigationFrame.SelectedPage = npEditor;
		}

		private void ShowList(ArtigosEntity cliente = null)
		{
			bbiEdit.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
			bbiReload.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;

			bbiBack.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
			bbiSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

			if (cliente != null)
			{
				List<ArtigosEntity> lista = artigosEntityBindingSource.DataSource as List<ArtigosEntity>;
				if (lista.Any(w => w.Id == cliente.Id))
					gridView.UpdateCurrentRow();
				else
					artigosEntityBindingSource.Add(cliente);
			}

			navigationFrame.SelectedPage = npList;
			xucArtigosDetailView.ResetForm();
		}

		#endregion

	}
}
