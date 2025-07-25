using DataService.Entities;
using DataService.Helpers;
using DataService.Queries;
using DevExpress.Internal.WinApi;
using DevExpress.XtraBars.Customization;
using DevExpress.XtraDataLayout;
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

namespace GestaoTrabalhos.Views.Home.Trabalhos
{
	public partial class TrabalhosView : DevExpress.XtraEditors.XtraUserControl
	{
		private bool loaded = false;
		private TrabalhosEntity _crtTrabalho;

		public TrabalhosView() => InitializeComponent();

		private async void seNumDoc_EditValueChanged(object sender, EventArgs e)
		{
			try
			{
				if (!loaded) return;

				int ano = (int)seAnoDocumento.Value;
				int numDoc = (int)seNumDoc.Value;

				_crtTrabalho = await TrabalhosQuery.DevolveTrabalho(ano, numDoc);

				if (_crtTrabalho != null)
				{
					linhasTrabalhoArtigosEntityBindingSource.DataSource = _crtTrabalho.Artigos;
					linhasTrabalhoServicosEntityBindingSource.DataSource = _crtTrabalho.Servicos;
					trabalhosEntityBindingSource.DataSource = _crtTrabalho;
				}
				else
				{
					NovoDocumento();
					await DevolveNumDocs();
				}
			}
			catch (Exception ex)
			{
				AppHelper.ErrorHelper(ex);
			}
		}

		private async void seAnoDocumento_EditValueChangedAsync(object sender, EventArgs e)
		{
			try
			{
				if (!loaded) return;

				await DevolveNumDocs();
				//NovoDocumento();
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
				dataLayoutControl1.Focus();
				servicosEntityBindingSource.EndEdit();

				_crtTrabalho.Ano = (int)seAnoDocumento.Value;
				_crtTrabalho.NumDoc = (int)seNumDoc.Value;

				bool saved = await TrabalhosQuery.GuardarTrabalho(_crtTrabalho);
				if (saved)
				{
					XtraMessageBox.Show("Trabalho guardado!", "Guardar Trabalho", MessageBoxButtons.OK, MessageBoxIcon.Information);
					
					NovoDocumento();

					await DevolveNumDocs();
				}
			}
			catch (Exception ex)
			{
				AppHelper.ErrorHelper(ex);
			}
		}

		private async void bbiNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			try
			{
				loaded = false;

				NovoDocumento();

				int anoMax = DateTime.Now.Year;
				seAnoDocumento.Properties.MaxValue = anoMax;
				seAnoDocumento.EditValue = anoMax;

				await DevolveNumDocs();

				loaded = true;
			}
			catch (Exception ex)
			{
				AppHelper.ErrorHelper(ex);
			}
		}

		private async void repoServicos_EditValueChanged(object sender, EventArgs e)
		{
			try
			{

				if (gvServicos.GetRow(gvServicos.FocusedRowHandle) is LinhasTrabalhoServicosEntity servicos)
				{
					BaseEdit editor = sender as DevExpress.XtraEditors.BaseEdit;
					if (editor != null)
					{
						int selectedValue = int.Parse(editor.EditValue?.ToString());

						ServicosEntity dbServico = await ServicosQuery.DevolveServico(selectedValue);

						servicos.Descricao = dbServico.Nome;
						servicos.Preco = dbServico.Custo;
						servicos.Duracao = dbServico.Duracao;

					}
				}
			}
			catch (Exception ex)
			{
				AppHelper.ErrorHelper(ex);
			}
		}

		private void gvServicos_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
		{
			atualizaValoresCabecalho();
		}

		private void deDataInicial_EditValueChanged(object sender, EventArgs e)
		{
			try
			{
				if (!loaded) return;

				_crtTrabalho.DataInicio = deDataInicial.DateTime;
				atualizaValoresCabecalho();
			}
			catch (Exception ex)
			{
				AppHelper.ErrorHelper(ex);
			}
		}

		#region FUNCOES

		internal async Task LoadData()
		{
			loaded = false;

			clientesEntityBindingSource.DataSource = await ClientesQuery.GetClientes();
			artigosEntityBindingSource.DataSource = await ArtigosQuery.GetArtigos();
			servicosEntityBindingSource.DataSource = await ServicosQuery.GetServicos();

			NovoDocumento();

			int anoMax = DateTime.Now.Year;
			seAnoDocumento.Properties.MaxValue = anoMax;
			seAnoDocumento.EditValue = anoMax;

			await DevolveNumDocs();

			loaded = true;
		}

		private void NovoDocumento()
		{
			_crtTrabalho = new TrabalhosEntity();

			DateTime dataAtual = DateTime.Now;
			_crtTrabalho.DataCriacao = dataAtual;
			_crtTrabalho.DataAtualizacao = dataAtual;
			_crtTrabalho.DataInicio = dataAtual;
			_crtTrabalho.DataFinal = dataAtual;
			_crtTrabalho.EmModoEdicao = false;

			_crtTrabalho.Artigos = new List<LinhasTrabalhoArtigosEntity>();
			_crtTrabalho.Servicos = new List<LinhasTrabalhoServicosEntity>();

			trabalhosEntityBindingSource.DataSource = _crtTrabalho;
			linhasTrabalhoArtigosEntityBindingSource.DataSource = _crtTrabalho.Artigos;
			linhasTrabalhoServicosEntityBindingSource.DataSource = _crtTrabalho.Servicos;

			atualizaValoresCabecalho();
		}

		private async Task DevolveNumDocs()
		{
			int numDoc = await TrabalhosQuery.DevolveProximo((int)seAnoDocumento.Value);
			seNumDoc.Properties.MaxValue = numDoc;
			seNumDoc.EditValue = numDoc;
		}

		private void atualizaValoresCabecalho()
		{
			dataLayoutControl1.Focus();
			servicosEntityBindingSource.EndEdit();

			decimal totalPrecoSercicos = _crtTrabalho.Servicos.Sum(x => x.Preco);
			decimal totalPrecoArtigos = _crtTrabalho.Artigos.Sum(x => x.Preco);
			int totalDuracaoServicos = _crtTrabalho.Servicos.Sum(x => x.Duracao);

			_crtTrabalho.Custo = totalPrecoSercicos + totalPrecoArtigos;
			_crtTrabalho.Duracao = totalDuracaoServicos;

			teTotalCusto.Text = _crtTrabalho.Custo.ToString("c2");
			teTotalDuracao.Text = ConversoesHelper.ConverterMinutosParaHorasEMinutos(_crtTrabalho.Duracao);

			_crtTrabalho.DataFinal = _crtTrabalho.DataInicio.AddMinutes(_crtTrabalho.Duracao);
			deFinal.EditValue = _crtTrabalho.DataFinal;
		}


		#endregion

		private void lueCliente_EditValueChanged(object sender, EventArgs e)
		{
			if (int.TryParse(lueCliente.EditValue?.ToString(), out int id))
			{
				_crtTrabalho.IdCliente = id;
			}
		}
	}
}
